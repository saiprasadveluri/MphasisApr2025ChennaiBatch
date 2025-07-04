namespace OnlineQuizMVC.Captcha
{
    public class CaptchaGenerator
    {
        public static string GenerateCaptchaCode(int length = 5)
        {
            const string chars = "ABCDEFGHJKLMNPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

    }
}
