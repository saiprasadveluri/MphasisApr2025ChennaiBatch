using System.Drawing;
using static System.Net.Mime.MediaTypeNames;

namespace QuizMVC.Captcha
{
    public class CaptchaGenerator
    {
        public static string GenerateCaptchaCode(int length = 5)
        {
            const string chars = "ABCDEFGHJKLMNPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz23456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        //public static byte[] GenerateImage(string code)
        //{
        //    using var bitmap = new Bitmap(150, 50);
        //    using var graphics = Graphics.FromImage(bitmap);
        //    graphics.Clear(Color.White);
        //    using var font = new Font("Arial", 24, FontStyle.Bold);
        //    using var brush = new SolidBrush(Color.Black);
        //    graphics.DrawString(code, font, brush, new PointF(10, 10));
        //    using var ms = new MemoryStream();
        //    bitmap.Save(ms, ImageFormat.Png);
        //    return ms.ToArray();
        //}
    }
}
