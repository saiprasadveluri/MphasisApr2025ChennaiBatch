using JobSearchMVC.DataDTO;

namespace JobSearchMVC.Models
{
    public class UserMVCRepo
    {
        private readonly HttpClient _httpClient;

        public UserMVCRepo(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://localhost:7103/api/");
        }

        public async Task<HttpResponseMessage> RegisterAsync(UserCandEmp user)
        {
            return await _httpClient.PostAsJsonAsync("User/register", user);
        }

        public async Task<IEnumerable<UserDTO>> GetAllAsync()
        {
            var response = await _httpClient.GetAsync("User");
            if (!response.IsSuccessStatusCode)
                return Enumerable.Empty<UserDTO>();

            return await response.Content.ReadFromJsonAsync<IEnumerable<UserDTO>>();
        }

        public async Task<UserDTO> GetByIdAsync(string id)
        {
            var response = await _httpClient.GetAsync($"User/{id}");
            if (!response.IsSuccessStatusCode)
                return null;

            return await response.Content.ReadFromJsonAsync<UserDTO>();
        }
    }

}