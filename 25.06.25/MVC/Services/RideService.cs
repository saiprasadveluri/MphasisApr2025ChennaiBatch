using RideAggregatorMVC.Models;
using System.Net.Http;
using System.Net.Http.Json;



namespace RideAggregatorMVC.Services
{
    public class RideService
    {
        private readonly HttpClient _httpClient;

        public RideService(HttpClient client)
        {
            _httpClient = client;
            _httpClient.BaseAddress = new Uri("https://localhost:7184/api/"); // your actual API base URL
        }

        public async Task<List<RentalsRide>> GetRidesByCustomerAsync(int customerId)
        {
            return await _httpClient.GetFromJsonAsync<List<RentalsRide>>($"RentalsRide/by-customer/{customerId}");
        }

        public async Task BookRideAsync(Ride ride)
        {
            await _httpClient.PostAsJsonAsync("RentalsRide", ride);
        }
        public async Task<List<RentalsRide>> GetRidesForDriverAsync(int driverId)
        {
            return await _httpClient.GetFromJsonAsync<List<RentalsRide>>($"RentalsRide/by-driver/{driverId}");
        }
        

        public async Task CompleteRideAsync(int rideId)
        {
            await _httpClient.PostAsJsonAsync("RentalsRide/complete", rideId);
        }

        public async Task MarkPaymentCompletedAsync(int rideId, string paymentMethod)
        {
            var payload = new { RideId = rideId, PaymentMethod = paymentMethod };
            await _httpClient.PostAsJsonAsync("RentalsRide/payment", payload);
        }

        public async Task SubmitRatingAsync(int rideId, int rating)
        {
            var ratingPayload = new { RideId = rideId, Rating = rating };
            await _httpClient.PostAsJsonAsync("RentalsRide/rate", ratingPayload);
        }
        public async Task AcceptRideAsync(int rideId)
        {
            await _httpClient.PostAsJsonAsync("RentalsRide/accept", rideId);
        }

        //    public async Task AcceptRideAsync(int rideId) =>
        //await _httpClient.PostAsJsonAsync("RentalsRide/accept", rideId);

        //    public async Task CompleteRideAsync(int rideId) =>
        //        await _httpClient.PostAsJsonAsync("RentalsRide/complete", rideId);

        //    public async Task ConfirmPaymentAsync(PaymentDto dto) =>
        //        await _httpClient.PostAsJsonAsync("RentalsRide/payment", dto);

        //    public async Task SubmitRatingAsync(RatingDto dto) =>
        //        await _httpClient.PostAsJsonAsync("RentalsRide/rate", dto);

    }
}
