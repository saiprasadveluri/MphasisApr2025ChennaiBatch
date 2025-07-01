namespace OnlineQuiZMVC.DATA
{
    public class CaptchaGenerator
    {
        public static string GenerateCaptchaCode(int v)
        {
            int length = v;
            const string chars = "ABCDEFGHJKLMNPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz23456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
