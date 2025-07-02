//using Microsoft.AspNetCore.Mvc;

//namespace JobSearchDatabase
//{
//    public class GenericRepositoryMVC<TEntity> where TEntity : class
//    {
//        private readonly HttpClient _httpClient;
//        private readonly string _endpoGuid;
//        public GenericRepositoryMVC(HttpClient httpClient, string endpoGuid)
//        {
//            _httpClient = httpClient;
//            _endpoGuid = endpoGuid;
//            _httpClient.BaseAddress = new Uri("https://localhost:7082/api/");
//        }
//        public async Task<IEnumerable<TEntity>> GetAllAsync()
//        {
//            var response = await _httpClient.GetAsync(_endpoGuid);
//            if (!response.IsSuccessStatusCode)
//            {
//                throw new InvalidOperationException("Entity not found");
//            }
//            if (response.IsSuccessStatusCode)
//            {
//                return await response.Content.ReadFromJsonAsync<IEnumerable<TEntity>>();
//            }
//            return Enumerable.Empty<TEntity>();
//        }
//        //[HttpGet("{id}")]
//        //public async Task<TEntity> GetByIdAsync(string id)
//        //{
//        //    var response = await _httpClient.GetAsync($"{_endpoGuid}/{id}");
//        //    if (!response.IsSuccessStatusCode)
//        //    {
//        //        throw new InvalidOperationException("Entity not found");
//        //    }

//        //    if (response.IsSuccessStatusCode)
//        //    {
//        //        return await response.Content.ReadFromJsonAsync<TEntity>();
//        //    }
//        //    return null;
//        //}
//        public async Task<TEntity?> GetByIdAsync(string id)
//        {
//            var response = await _httpClient.GetAsync($"{_endpoGuid}/{id}");

//            if (!response.IsSuccessStatusCode)
//                return default;

//            return await response.Content.ReadFromJsonAsync<TEntity>();
//        }

//        public async Task<TEntity> CreateAsync(TEntity entity)
//        {
//            var response = await _httpClient.PostAsJsonAsync(_endpoGuid, entity);
//            return entity;
//        }

//        public async Task<TEntity> UpdateAsync(string id, TEntity entity)
//        {
//            var response = await _httpClient.PutAsJsonAsync($"{_endpoGuid}/{id}", entity);
//            return entity;
//        }

//        public async Task<TEntity> DeleteAsync(string id, TEntity entity)
//        {
//            var response = await _httpClient.DeleteAsync($"{_endpoGuid}/{id}");
//            return entity;
//        }
//    }
//}




using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

public class GenericRepositoryMVC<TEntity> where TEntity : class
{
    private readonly HttpClient _httpClient;
    private readonly string _endpoGuid;

    private readonly JsonSerializerOptions _jsonOptions = new JsonSerializerOptions
    {
        Converters = { new JsonStringEnumConverter() },
        PropertyNameCaseInsensitive = true
    };

    public GenericRepositoryMVC(HttpClient httpClient, string endpoGuid)
    {
        _httpClient = httpClient;
        _endpoGuid = endpoGuid;
        _httpClient.BaseAddress = new Uri("https://localhost:7082/api/");
    }

    public async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        var response = await _httpClient.GetAsync(_endpoGuid);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<IEnumerable<TEntity>>(_jsonOptions);
    }

    public async Task<TEntity?> GetByIdAsync(string id)
    {
        var response = await _httpClient.GetAsync($"{_endpoGuid}/{id}");
        if (!response.IsSuccessStatusCode) return default;
        return await response.Content.ReadFromJsonAsync<TEntity>(_jsonOptions);
    }

    public async Task<TEntity> CreateAsync(TEntity entity)
    {
        var response = await _httpClient.PostAsJsonAsync(_endpoGuid, entity, _jsonOptions);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<TEntity>(_jsonOptions);
    }

    public async Task<TEntity> UpdateAsync(string id, TEntity entity)
    {
        var response = await _httpClient.PutAsJsonAsync($"{_endpoGuid}/{id}", entity, _jsonOptions);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<TEntity>(_jsonOptions);
    }

    public async Task<TEntity> DeleteAsync(string id, TEntity entity)
    {
        var response = await _httpClient.DeleteAsync($"{_endpoGuid}/{id}");
        response.EnsureSuccessStatusCode();
        return entity;
    }
}
