namespace BookMyShowAPI.Helper
{
    using System.Collections.Concurrent;

    public interface IOTPService
    {
        string GenerateOtp(string email);
        bool ValidateOtp(string email, string otp);
    }

    public class OTPService : IOTPService
    {
        private readonly ConcurrentDictionary<string, string> _otpStorage = new();

        public string GenerateOtp(string email)
        {
            var otp = new Random().Next(100000, 999999).ToString();
            _otpStorage[email] = otp;
            return otp;
        }

        public bool ValidateOtp(string email, string otp)
        {
            return _otpStorage.TryGetValue(email, out var storedOtp) && storedOtp == otp;
        }
    }
}
