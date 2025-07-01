using Microsoft.AspNetCore.Mvc;
using QuizMVC.DTO;
using System.Text.Json;

namespace QuizMVC.ClientServices
{
    public class ServicesMVC
    {
        HttpClient httpClient;
        IConfiguration configuration;
        public ServicesMVC(HttpClient client, IConfiguration config)
        {
            httpClient = client;
            configuration = config;
            var secValue = config.GetValue<string>("ApiUrl:ClientUrl");
            httpClient.BaseAddress = new Uri(secValue);

        }
        public async Task<bool> AddUserData(RegisterUserDTO userDto)
        {
            HttpResponseMessage response = await httpClient.PostAsJsonAsync("User", userDto);
            string result = await response.Content.ReadAsStringAsync();

            bool.TryParse(result, out bool success); // Now this will work
            return success;
        }
        public async Task<GetAccountAdminDTO> GetAdminById(Guid id)
        {
            HttpResponseMessage response = await httpClient.GetAsync($"Admin/GetAdminById?id={id}");
            response.EnsureSuccessStatusCode();

            string jsonString = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<GetAccountAdminDTORes>(jsonString).res;
        }
        public async Task<bool> AddQuiz(QuizQuestionsDTO quizDto)
        {
            HttpResponseMessage response = await httpClient.PostAsJsonAsync("Admin/AddQuiz", quizDto);
            string result = await response.Content.ReadAsStringAsync();

            bool.TryParse(result, out bool success); 
            return success;
        }
    }
}
