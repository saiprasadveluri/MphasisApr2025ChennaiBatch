using JobSearchAPI.DataDTO;
using JobSearchDatabase.Data;

namespace JobSearchDatabase.Models
{
    public class UserMVCRepo
    {
        private readonly HttpClient _httpClient;

        public UserMVCRepo(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://localhost:7082/api/");
        }

        public async Task<HttpResponseMessage> RegisterAsync(UserCandEmp user)
        {
            return await _httpClient.PostAsJsonAsync("User/register", user);
        }

        public async Task<IEnumerable<JobSearchAPI.DataDTO.UserDTO>> GetAllAsync()
        {
            var response = await _httpClient.GetAsync("User");
            if (!response.IsSuccessStatusCode)
                return Enumerable.Empty<JobSearchAPI.DataDTO.UserDTO>();

            return await response.Content.ReadFromJsonAsync<IEnumerable<JobSearchAPI.DataDTO.UserDTO>>();
        }

        public async Task<JobSearchAPI.DataDTO.UserDTO> GetByIdAsync(string id)
        {
            var response = await _httpClient.GetAsync($"User/{id}");
            if (!response.IsSuccessStatusCode)
                return null;

            return await response.Content.ReadFromJsonAsync<JobSearchAPI.DataDTO.UserDTO>();
        }
    }

}