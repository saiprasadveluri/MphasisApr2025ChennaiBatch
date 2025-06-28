using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using System.Drawing.Imaging;
using static System.Net.Mime.MediaTypeNames;

namespace OnlineQuiz.Controllers
{[ApiController]
[Route("api/[controller]")]
    public class CaptchaController : Controller
    {
        public IActionResult Generate()
        {
            string code = GenerateCaptchaCode();
            HttpContext.Session.SetString("CaptchaCode", code);

            var image = GenerateCaptchaImage(code);
            var stream = new MemoryStream();
            image.Save(stream, ImageFormat.Png);
            stream.Seek(0, SeekOrigin.Begin);

            return File(stream, "image/png");
        }

        private string GenerateCaptchaCode()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, 5)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private Bitmap GenerateCaptchaImage(string code)
        {
            var bitmap = new Bitmap(120, 40);
            var graphics = Graphics.FromImage(bitmap);
           // var font = new Font("Arial", 20, FontStyle.Bold);
            var brush = new SolidBrush(Color.Black);
            var bgBrush = new SolidBrush(Color.White);

            graphics.FillRectangle(bgBrush, 0, 0, bitmap.Width, bitmap.Height);
          //  graphics.DrawString(code, font, brush, 10, 5);




            return bitmap;
        }
    }
}
