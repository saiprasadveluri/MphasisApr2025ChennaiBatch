using System.Text;
using System.Text.Json;
using OnlineQuizMVC.DTO;

namespace OnlineQuizMVC.ClientServices
{
    public class QuizServicesMVC
    {
        HttpClient httpClient;
        IConfiguration configuration;
        public QuizServicesMVC(HttpClient client, IConfiguration config)
        {
            httpClient = client;
            configuration = config;
            var secValue = config.GetValue<string>("ApiUrl:ClientUrl");
            httpClient.BaseAddress = new Uri(secValue);

        }
        public async Task<List<GetQuestionWithOptionsDTO>> GetQuesByRandm(Guid quizId)
        {
            var response = await httpClient.GetAsync($"Questions/quiz/{quizId}");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<List<GetQuestionWithOptionsDTO>>(json);
        }

        public async Task<Guid> SubmitQuizAttemptAsync(Guid userId, Guid quizId, Dictionary<Guid, Guid> answers, DateTime startTime)
        {
            var dto = new QuizAttemptDTO
            {
                UserId = userId,
                QuizId = quizId,
                AttemptTime = startTime,
                Score = null,
                Status = JsonSerializer.Serialize(answers)
            };

            var content = new StringContent(JsonSerializer.Serialize(dto), Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("https://your-api-url/api/Quiz", content);
            response.EnsureSuccessStatusCode();
            var result = JsonSerializer.Deserialize<Dictionary<string, string>>(await response.Content.ReadAsStringAsync());
            return Guid.Parse(result["AttemptId"]);
        }
    }
}
