using System.Text.Json;
using OnlineQuizMVC.DTO;

namespace OnlineQuizMVC.ClientServices
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
        public async Task<GetAccountUserDTO> GetUserById(Guid id)
        {
            HttpResponseMessage response = await httpClient.GetAsync($"User/GetUserById?id={id}");
            //response.EnsureSuccessStatusCode();

            string jsonString = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<GetAccountUserDTORes>(jsonString).res;
        }
        public async Task<List<GetQuizDTO>> GetQuizByCatg(string catg)
        {
            HttpResponseMessage response = await httpClient.GetAsync($"User/GetQuizByCatg?catg={catg}");
            response.EnsureSuccessStatusCode();

            string jsonString = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<GetQuiDTORes>(jsonString).res;
        }

        public async Task<bool> AddQuiz(QuizQuestionsDTO quizDto)
        {
            HttpResponseMessage response = await httpClient.PostAsJsonAsync("Admin/AddQuiz", quizDto);
            string result = await response.Content.ReadAsStringAsync();

            bool.TryParse(result, out bool success);
            return success;
        }
        public async Task<GetQuizDTO> QuizDetailsById(Guid id)
        {
            var response = await httpClient.GetAsync($"User/GetQuizByid?id={id}");

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"❌ API call failed: {response.StatusCode}");
            }

            var jsonString = await response.Content.ReadAsStringAsync();

            if (string.IsNullOrWhiteSpace(jsonString))
            {
                throw new Exception("❌ API returned an empty JSON string.");
            }

            try
            {
                var result = JsonSerializer.Deserialize<GetQuiDTORes2>(jsonString);
                if (result?.data == null)
                {
                    throw new Exception("❌ Deserialization succeeded but 'data' property was null.");
                }

                return result.data;
            }
            catch (JsonException jsonEx)
            {
                Console.WriteLine($"🪵 Raw Response JSON: {jsonString}");
                throw new Exception("❌ Failed to deserialize JSON.", jsonEx);
            }
        }
        public async Task<List<GetQuestionWithOptionsDTO>> GetQuesByRandm(Guid id)
        {
            var response = await httpClient.GetAsync($"User/GetRandomQuesByQuiz?id={id}");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<GetQuetionWithOptionsDTOData>(json).data;
        }
        public async Task<List<GetQuizAttemptDTO>> GetUserAttempts(Guid id)
        {
            var response = await httpClient.GetAsync($"User/getAllQuizAttempts/{id}");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<GetQuizAttemptDTOres>(json).res;
        }
        public async Task<bool> SaveQuizAttempt(GetQuizAttemptDTO attempt)
        {
            var response = await httpClient.PostAsJsonAsync("User/SaveQuizAttempt", attempt);
            return response.IsSuccessStatusCode;
        }
        public async Task<bool> AddAdmin(AccountAdminDTO admindto)
        {
            var response = await httpClient.PostAsJsonAsync("Admin", admindto);

            if (response.IsSuccessStatusCode)
                return false;

            string result = await response.Content.ReadAsStringAsync();
            bool.TryParse(result, out bool success);
            return success;
        }
        public async Task<bool> DeleteUser(Guid id)
        {
            var response = await httpClient.DeleteAsync($"Admin?id={id}");
            if (response.IsSuccessStatusCode)
                return false;

            string result = await response.Content.ReadAsStringAsync();
            bool.TryParse(result, out bool success);
            return success;
        }
        public async Task<List<GetAccountUserDTO>> GetAllUsers()

        {

            HttpResponseMessage response = await httpClient.GetAsync($"Admin/getAllUserData");

            response.EnsureSuccessStatusCode();

            string jsonString = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<GetAccountUserDTORes2>(jsonString).data;

        }
        public async Task<bool> EditAdmin(Guid accountId, UpdateAdminDTO data)
        {
            var response = await httpClient.PutAsJsonAsync($"Admin/UpdateAdmin/{accountId}", data);

            if (!response.IsSuccessStatusCode)
                return false;

            return true;
        }
    }
}
