using OnlineQuizWepAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace OnlineQuizWebAPI.DataAccessLayer
{
    public class DataAccess : IQuizRepository
    {
      
            private readonly QuizDbContext _context;

            public DataAccess(QuizDbContext context)
            {
                _context = context;
            }

            public IEnumerable<Quiz> GetAll() =>
                _context.Quizs.Include(q => q.Questions).Include(q => q.UserInfo).ToList();

            public Quiz GetById(Guid quizId) =>
                _context.Quizs.Include(q => q.Questions).FirstOrDefault(q => q.QuizId == quizId);

            public IEnumerable<Quiz> GetScheduledQuizzes() =>
                _context.Quizs.Where(q => q.ScheduleTime > DateTime.UtcNow).ToList();

            public void CreateQuiz(Quiz quiz)
            {
                quiz.QuizId = Guid.NewGuid();
                _context.Quizs.Add(quiz);
            }

            public void UpdateQuiz(Quiz quiz)
            {
                _context.Quizs.Update(quiz);
            }

            public void DeleteQuiz(Guid quizId)
            {
                var quiz = _context.Quizs.Find(quizId);
                if (quiz != null)
                    _context.Quizs.Remove(quiz);
            }

            public void Save() => _context.SaveChanges();
        }
    }

