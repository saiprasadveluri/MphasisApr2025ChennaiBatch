using Microsoft.EntityFrameworkCore;
using OnlineQuizApplicationAPI.DTO;
using OnlineQuizApplicationAPI.Models;
using System.Text.Json;

namespace OnlineQuizApplicationAPI.Services
{
    public class QuizServices
    {
        QuizDbContext context;
        public QuizServices(QuizDbContext ctx)
        {
            context = ctx;
        }
        public async Task<Guid> AddQuizAttemptAsync(QuizAttemptDTO dto)
        {
            var userAnswers = JsonSerializer.Deserialize<Dictionary<Guid, Guid>>(dto.Status);

            // Load questions linked to the Quiz via the many-to-many navigation
            var questions = await context.Quizs
                .Where(q => q.QuizId == dto.QuizId)
                .SelectMany(q => q.Questions)
                .Include(q => q.Options)
                .ToListAsync();

            // Calculate score based on correct answers
            int score = questions.Count(q =>
                userAnswers.ContainsKey(q.QuestionId) &&
                q.Options.FirstOrDefault(o => o.OptionId == userAnswers[q.QuestionId])?.Answer == 1);

            var attempt = new QuizAttempt
            {
                AttemptId = Guid.NewGuid(),
                UserId = dto.UserId,
                QuizId = dto.QuizId,
                AttemptTime = dto.AttemptTime,
                Score = score,
                Status = "completed"
            };

            context.QuizAttempts.Add(attempt);
            await context.SaveChangesAsync();

            return attempt.AttemptId;
        }

        public async Task<GetQuizAttemptDTO> GetQuizAttemptByIdAsync(Guid attemptId)
        {
            var a = await context.QuizAttempts.FindAsync(attemptId);
            return a == null ? null : new GetQuizAttemptDTO
            {
                AttemptId = a.AttemptId,
                UserId = a.UserId,
                QuizId = a.QuizId,
                AttemptTime = a.AttemptTime,
                Score = a.Score,
                Status = a.Status
            };
        }
    }
}
