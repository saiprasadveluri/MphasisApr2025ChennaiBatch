namespace RideAggregatorApi.Models.DTO
{
    public class AuthResponse
    {
        public int Id { get; set; }
        public string Role { get; set; } = string.Empty;
        public string Token { get; set; } = string.Empty;
    }
}
