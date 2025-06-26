namespace BookMyShowAPI.Helper
{
    public interface ICaptchaService
    {
        bool ValidateCaptcha(string input);
    }

    public class CaptchaService : ICaptchaService
    {
        public bool ValidateCaptcha(string input)
        {
            // In production, you'd check against a real captcha.
            return !string.IsNullOrWhiteSpace(input) && input.Length > 3;
        }
    }
}
