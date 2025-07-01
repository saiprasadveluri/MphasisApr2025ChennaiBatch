using BookMyShow.Models;
using BotDetect;
using BotDetect.C5;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

using System.Drawing;
using System.IO;
using System.Text;

using System.Security.Cryptography;

namespace BookMyShow.Controllers
{
    [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
    public class BookMyShowController : Controller
    {
        BookMyShowContext db = new BookMyShowContext();
        public IActionResult Index()
        {
            return View();
        }
        private List<SelectListItem> GetSecurityQuestions()
        {
            return new List<SelectListItem>
        {
            new SelectListItem { Value = "What is your favorite pet?", Text = "What is your favorite pet?" },
            new SelectListItem { Value = "What is your pet name?", Text = "What is your pet name?" },
            new SelectListItem { Value = "Which tourist place you visited recently?", Text = "Which tourist place you visited recently?" }
        };
        }
        private string GenerateRandomCode(int length)
        {
            const string chars = "ABCDEFGHJKLMNPQRSTUVWXYZ23456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        //Home Method
        public IActionResult Home()
        {
            var movies = db.Movies.ToList();
            return View(movies);
        }
        //Register Page
        [HttpGet]
        public IActionResult Register()
        {
            var captchaCode = GenerateRandomCode(5);
            HttpContext.Session.SetString("CaptchaCode", captchaCode);
            ViewBag.CaptchaCode = captchaCode;
            ViewBag.SecurityQuestions = GetSecurityQuestions();
            return View();
        }
        private string HashPassword(string password)
        {
            using var sha256 = SHA256.Create();
            var bytes = Encoding.UTF8.GetBytes(password);
            var hash = sha256.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }
        [HttpPost]
        public IActionResult Register(User u, IFormCollection f)
        {
            var sessionCaptcha = HttpContext.Session.GetString("CaptchaCode") ?? "";
            if (string.Equals(u.Captcha, sessionCaptcha, StringComparison.OrdinalIgnoreCase))
            {
                try
                {
                    if (ModelState.IsValid)
                    {
                        // Convert password and security answer strings to byte arrays
                        u.Pass = HashPassword(f["pass"].ToString());
                        User ob = new User()
                        {
                            Username = u.Username,
                            Pass = u.Pass,
                            FullName = u.FullName,
                            Age = u.Age,
                            Email = u.Email,
                            Gender = u.Gender,
                            MobileNo = u.MobileNo,
                            Address = u.Address,
                            CreatedAt = DateTime.Now,
                            Security_Question = u.Security_Question,
                            Security_Answer = u.Security_Answer
                        };
                        db.Users.Add(ob);
                        db.SaveChanges();
                        ViewBag.RecordAddedSuccess = "Record Added Successfully";
                        return RedirectToAction("Login", "BookMyShow");
                    }
                    else
                    {
                        ViewBag.RecordAddedfail = "Validations Not Matched";
                    }

                }
                catch (Exception ex)
                {
                    ViewBag.RecordAddedfail = "Looks Email has existed. Please try with another Email " + ex.Message;
                    return View(u);
                }
            }
            else
            {
                ModelState.AddModelError("Captcha", "Invalid captcha code. Please try again.");

            }
            var newCaptchaCode = GenerateRandomCode(5);
            HttpContext.Session.SetString("CaptchaCode", newCaptchaCode);
            ViewBag.CaptchaCode = newCaptchaCode;
            return View(u);
        }
        //Login
        [HttpGet]
        public IActionResult Login()
        {
            GenerateCaptcha(); //for generating first captcha
            return View();
        }
        [HttpPost]
        public IActionResult Login(Admin a, string captchaText, IFormCollection form)
        {
            BookMyShowContext db = new BookMyShowContext();
            var loginas = form["loginas"];
            try
            {
                if (HttpContext.Session.GetString("CaptchaCode") == null || HttpContext.Session.GetString("CaptchaCode") != captchaText)
                {
                    ViewBag.err = "Incorrect CAPTCHA. Please try again.";
                    ModelState.Clear();
                    GenerateCaptcha(); // it is for regenarting captcha again if entered captcha is wrong 
                    return View(a); // Passing the user object back to retain form data
                }
                var uname = form["username"].ToString();
                byte[] pass = Encoding.UTF8.GetBytes(form["pass"].ToString());
                //byte[] adminpass = Encoding.UTF8.GetBytes(form["pass"].ToString());

                if (loginas == "admin")
                {
                    var admin_detail = db.Admins.FirstOrDefault(x => x.Username == uname);
                    if (admin_detail != null)
                    {
                        if (admin_detail.Username.ToLower() == "satish")
                        {
                            HttpContext.Session.SetString("user", uname);
                            return RedirectToAction("SuperAdmin", "Admin");
                        }
                        else
                        {
                            HttpContext.Session.SetString("user", uname);
                            HttpContext.Session.SetString("enable", admin_detail.EnableEdit);
                            return RedirectToAction("Home", "Admin");
                        }
                    }
                    else
                    {
                        ViewBag.err = $"No records found in the Admin as {uname}";
                    }
                }
                else
                {
                    var res = db.Users.FirstOrDefault(user => user.Username == a.Username);
                    if (res != null)
                    {

                        ViewBag.err = "Login successful.";

                        HttpContext.Session.SetString("Name", res.FullName);
                        HttpContext.Session.SetString("Username", res.Username);
                        HttpContext.Session.SetString("Password", form["pass"].ToString());
                        HttpContext.Session.SetInt32("UserId", res.UserId);
                        ModelState.Clear();
                        return RedirectToAction("Movies", "BookMyShow");
                    }
                    else
                    {
                        ViewBag.err = "Invalid username or password.";
                        ModelState.Clear();
                        GenerateCaptcha(); // Regenerate CAPTCHA on invalid credentials
                        return View(a); // Passing the user object back to retain form data
                    }
                }
            }
            catch (Exception ex)
            {
                ViewBag.err = "An error occurred: " + ex.Message;
                GenerateCaptcha(); // Regenerate CAPTCHA on error
            }

            var newCaptchaCode = GenerateRandomCode(5);
            HttpContext.Session.SetString("CaptchaCode", newCaptchaCode);
            ViewBag.CaptchaCode = newCaptchaCode;
            return View(a);
        }
        //Foregt Password
        [HttpGet]
        public IActionResult ForgotPassword()
        {
            ViewBag.SecurityQuestions = GetSecurityQuestions();
            return View();
        }
        [HttpPost]
        public IActionResult ForgotPassword(User s, IFormCollection f)
        {
            ViewBag.SecurityQuestions = GetSecurityQuestions();
            ViewBag.update = 0;
            try
            {
                var res = (from t in db.Users where t.Email == s.Email select t).FirstOrDefault();
                if (res == null)
                {
                    ViewBag.err = "No user found with that email.";
                    return View();
                }
                if (res.Security_Question != s.Security_Question || res.Security_Answer != s.Security_Answer)
                {
                    ViewBag.err = "Security question or answer is incorrect.";
                    return View();
                }
                var newPassword = f["Pass"];
                var confirmPassword = f["confirmpass"];
                if (string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmPassword))
                {
                    ViewBag.err = "Password fields cannot be empty.";
                    return View();
                }
                if (newPassword != confirmPassword)
                {
                    ViewBag.err = "Password and Confirm Password do not match.";
                    return View();
                }
                res.Pass = HashPassword(newPassword);
                db.Users.Update(res);
                ViewBag.update = db.SaveChanges();
                return View();
            }
            catch (Exception e)
            {
                ViewBag.err = "An error occurred: " + e.Message;
                return View();
            }
        }
        //Update Profile
        [HttpGet]
        public IActionResult UpdateProfile()
        {
            if (HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("Login");
            }
            int UserId = Convert.ToInt32(HttpContext.Session.GetInt32("UserId"));
            ViewBag.UserId = UserId;
            ViewBag.hidden = false;
            var details = db.Users.Where(d => d.UserId == UserId).FirstOrDefault();
            if (details == null)
            {
                TempData["ErrorMessage"] = "User profile not found.Please Register First.";
                return RedirectToAction("Register", "BookMyShow");
            }
            return View(details);
        }
        [HttpGet]
        public IActionResult EditProfile(string _username)
        {
            if (HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("Login");
            }
            var details = db.Users.Where(d => d.Username == _username).FirstOrDefault();
            if (details == null)
            {
                TempData["ErrorMessage"] = "User profile not found for editing.";
                return RedirectToAction("UpdateProfile");
            }
            return View(details);
        }
        [HttpPost]
        public async Task<IActionResult> EditProfile(string _username, IFormCollection form, IFormFile Pic)
        {
            if (HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("Login");
            }
            var details = db.Users.Where(d => d.Username == _username).FirstOrDefault();
            try
            {
                if (details == null)
                {
                    TempData["ErrorMessage"] = "User profile not found.";
                    return View();
                }
                if (ModelState.IsValid)
                {
                    details.FullName = form["FullName"];
                    if (int.TryParse(form["Age"], out int age))
                    {
                        details.Age = age;
                    }
                    else
                    {
                        ModelState.AddModelError("Age", "Invalid Age format.");
                    }
                    details.Address = form["Address"];
                    details.MobileNo = form["MobileNo"];
                    details.Email = form["Email"];
                    if (Pic != null && Pic.Length > 0)
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            await Pic.CopyToAsync(memoryStream);
                            details.ProfilePic = memoryStream.ToArray();
                        }
                    }
                    db.Users.Update(details);
                    await db.SaveChangesAsync();
                    TempData["SuccessMessage"] = "Profile updated successfully!";
                    return RedirectToAction("UpdateProfile");
                }
                return View(details);
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = "An error occurred while updating the profile: " + ex.Message;
                return View(details);
            }
        }
        //This for listing all the movies
        [HttpGet]
        public IActionResult Movies()
        {
            if (HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("Login");
            }
            else
            {
                var city_movieid = db.Theaters
                                   .Where(t => t.CityId == 1)
                                   .Select(t => t.MovieId).ToList();
                var movie = db.Movies.ToList();
                ViewBag.genre = db.Genres.ToList();
                ViewBag.language = db.Languages.ToList();
                return View(movie);
            }
        }
        //This is for Filter the Movie
        [HttpPost]
        public IActionResult Movies(IFormCollection f)
        {
            if (HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("Login");
            }
            var movies = db.Movies.AsQueryable();
            // Filter by Genre
            if (f["option"] != "All")
            {
                int genreId = Convert.ToInt32(f["option"]);
                movies = movies.Where(m => m.GenreId == genreId);
            }
            // Filter by Language
            if (f["Lang"] != "All")
            {
                int langId = Convert.ToInt32(f["Lang"]);

                // Join with MovieLanguages for filtering languages
                var movieIdsWithLang = db.MovieLanguages
                                        .Where(ml => ml.LanguageId == langId)
                                        .Select(ml => ml.MovieId)
                                        .Distinct()
                                        .ToList();
                movies = movies.Where(m => movieIdsWithLang.Contains(m.MovieId));
            }
            // Filter movies by both GenreId and LanguageId
            else if (f["option"] != "All" && f["Lang"] != "All")
            {
                var searchTerm = Convert.ToInt32(f["Option"]);
                var langsearch = Convert.ToInt32(f["Lang"]);
                movies = (from m in db.Movies
                          join ml in db.MovieLanguages on m.MovieId equals ml.MovieId
                          where m.GenreId == searchTerm && ml.LanguageId == langsearch
                          select m).Distinct();
            }

            // Filter by Search Text (movie name contains)
            string searchText = f["SearchText"].ToString();
            if (!string.IsNullOrEmpty(searchText))
            {
                int cityid = 1;
                HttpContext.Session.SetInt32("CityId", cityid);
                movies = (from t in db.Movies where t.MovieName.Contains(searchText) select t);
            }

            // Pass the filters data for dropdowns again
            ViewBag.genre = db.Genres.ToList();
            ViewBag.language = db.Languages.ToList();
            return View(movies.ToList());
        }
        //Movie Detail
        [HttpGet]
        public IActionResult MovieDetail(string id, string name, string duration, string desc, string release)
        {
            try
            {
                //To get the Movie detail
                var res = (from t in db.Movies
                           where t.MovieId == Convert.ToInt32(id)
                           select t).FirstOrDefault();
                //To get the language code
                var lan = (from t in db.MovieLanguages
                           where t.MovieId == Convert.ToInt32(id)
                           select t.LanguageId).ToList();
                //To get the language name
                var language_name = (from t in db.Languages
                                     where lan.Contains(t.LanguageId)
                                     select t.Name).ToList();
                //To get the genre detail
                var genre = (from t in db.Genres
                             where t.GenreId == res.GenreId
                             select t.Name).FirstOrDefault();
                //To get the cast details
                var cast = (from t in db.MovieCasts
                            where t.MovieId == Convert.ToInt32(id)
                            select t).ToList();
                //To get the recommended movie
                var related = (from t in db.Movies
                               where t.GenreId == res.GenreId && t.MovieId != res.MovieId
                               select t).ToList();
                //To get the user detail
                int userid = Convert.ToInt32(HttpContext.Session.GetInt32("UserId"));
                var username = (from t in db.Users
                                where t.UserId == userid
                                select t.Username).FirstOrDefault();
                //To get the Review
                int mid = Convert.ToInt32(id);
                var review_table = (from t in db.Reviews where t.MovieId == mid select t).ToList();

                ViewBag.username = username;
                ViewBag.review = review_table;
                ViewBag.related = related;
                ViewBag.genre = genre;
                ViewBag.language = language_name;
                ViewBag.Cast = cast;
                ViewBag.image = res.MoviePoster;
                HttpContext.Session.SetInt32("MovieId", mid);
                ViewBag.name = name;
                ViewBag.duration = duration;
                ViewBag.desc = desc;
                ViewBag.release = release;
                ViewBag.id = mid;
                return View();
            }
            catch (Exception e)
            {
                ViewBag.error = e.Message;
                return View();
            }
        }
        [HttpPost]
        public IActionResult MovieDetail(IFormCollection f)
        {

            int movieid = Convert.ToInt32(f["movieid"]);
            int rating = Convert.ToInt32(f["Rating"]);
            string comment = f["Comment"];
            int like = Convert.ToInt32(f["Radio"]);
            int userid = Convert.ToInt32(HttpContext.Session.GetInt32("UserId"));

            //To check that the user has already rated the movie
            try
            {
                var rate_table = (from t in db.Reviews where t.Uid == userid && t.MovieId == movieid select t).ToList();
                ViewBag.count = rate_table.Count;
                if (rate_table.Count() > 0)
                {
                    return RedirectToAction("ReviewMessage", new { id = ViewBag.count });
                }
                else
                {
                    Review review = new Review() { MovieId = movieid, Rating = rating, CommentText = comment, Like = like, Uid = userid };
                    db.Reviews.Add(review);
                    db.SaveChanges();
                    return RedirectToAction("ReviewMessage", new { id = ViewBag.count });
                }
            }
            catch (Exception e)
            {
                ViewBag.error = "Something Went Wrong";
            }
            return View();
        }
        //To check if the user already reviewed or not
        public IActionResult ReviewMessage(int id)
        {
            ViewBag.count = id;
            return View();
        }
        //List of  theater
        [HttpGet]
        public IActionResult Theatre(int? cityId, DateTime? selectedDate)
        {
            using var db = new BookMyShowContext();

            int movie_id = Convert.ToInt32(HttpContext.Session.GetInt32("MovieId"));
            var cities = db.Cities.ToList();
            ViewBag.Cities = cities;
            ViewBag.SelectedDate = selectedDate ?? DateTime.Today;

            List<Theater> theaters = new();

            if (cityId.HasValue)
            {
                theaters = db.Theaters
                    .Where(t => t.CityId == cityId && t.MovieId == movie_id)
                    .ToList();

                ViewBag.CityId = cityId;
            }

            var showTimes = db.ShowTimes.Where(t => t.MovieId == movie_id).ToList();
            var movies = db.Movies.ToList();

            var theaters2 = db.Theaters.ToList();
            ViewBag.ShowTimes = showTimes;
            ViewBag.Movies = movies;

            return View(theaters);
        }
        [HttpGet]
        public async Task<IActionResult> Book(int showId, int theaterId, string date)
        {
            if (HttpContext.Session.GetInt32("UserId") == null)
                return RedirectToAction("Login");

            using var db = new BookMyShowContext();

            var theater = await db.Theaters.FindAsync(theaterId);
            if (theater == null)
            {
                ModelState.AddModelError("", "Theater not found.");
                return View();
            }

            //Get all booked seats for this show
            ViewBag.SeatPrice = theater.Price;
            var bookedSeats = await db.Tickets
                .Where(t => t.ShowId == showId && t.TheaterId == theaterId && t.TicketDate == DateTime.Parse(date))
                .Select(t => t.SeatNumbers)
                .ToListAsync();

            var allBookedSeats = bookedSeats
                 .Where(s => !string.IsNullOrEmpty(s))
                .SelectMany(s => s.Split(',', StringSplitOptions.RemoveEmptyEntries))
                .Select(s => s.Trim())
                .ToArray();

            //var bookedSeats = await db.Tickets
            //    .Where(t => t.ShowId == showId && t.TheaterId == theaterId && t.TicketDate == DateTime.Parse(date))
            //    .SelectMany(t => t.SeatNumbers.Split(',', StringSplitOptions.RemoveEmptyEntries))
            //    .ToListAsync();

            var availableSeats = new List<string>();
            for (int i = 1; i <= theater.NoOfSeats; i++)
            {
                var seatNumber = $"Seat{i}";
                availableSeats.Add(seatNumber);
            }

            ViewBag.ShowId = showId;
            ViewBag.TheaterId = theaterId;
            ViewBag.Date = date;
            ViewBag.AvailableSeats = availableSeats.ToArray();
            ViewBag.BookedSeats = allBookedSeats;

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Book(int showId, int theaterId, string date, string[] selectedSeats)
        {

           
            if (HttpContext.Session.GetInt32("UserId") == null)
                return RedirectToAction("Login");

            if (selectedSeats == null || selectedSeats.Length == 0)
            {
                ModelState.AddModelError("", "Please select at least one seat.");
                return await Book(showId, theaterId, date);
            }

            // Clean seat numbers (trim spaces, ensure unique)
            var seatsToBook = selectedSeats
                .Select(s => s.Trim())
                .Distinct()
                .ToArray();

            using var db = new BookMyShowContext();
            using var transaction = await db.Database.BeginTransactionAsync();

            try
            {
                // Only check for seats booked for the same show, theater, and date
                var existingSeats = await db.Tickets
                    .Where(t => t.ShowId == showId && t.TheaterId == theaterId && t.TicketDate == DateTime.Parse(date))
                    .Select(t => t.SeatNumbers)
                    .ToListAsync();

                var allBookedSeats = existingSeats
                     .Where(s => !string.IsNullOrEmpty(s))
                    .SelectMany(s => s.Split(',', StringSplitOptions.RemoveEmptyEntries))
                    .Select(s => s.Trim())
                    .ToList();

                // Check for conflicts
                var alreadyBooked = seatsToBook.Intersect(allBookedSeats, StringComparer.OrdinalIgnoreCase).ToList();
                if (alreadyBooked.Any())
                {
                    ModelState.AddModelError("", $"Seats {string.Join(", ", alreadyBooked)} are already booked.");
                    await transaction.RollbackAsync();
                    return await Book(showId, theaterId, date);
                }

                // Create a single ticket for all seats
                var ticket = new Ticket
                {
                    UserId = HttpContext.Session.GetInt32("UserId"),
                    ShowId = showId,
                    TheaterId = theaterId,
                    MovieId = (int)db.ShowTimes.Find(showId).MovieId,
                    SeatNumbers = string.Join(",", seatsToBook),
                    TicketDate = DateTime.Parse(date),
    
                };
                var ticketPrice = await db.Theaters
      .Where(t => t.Tid == theaterId)
      .Select(t => t.Price)
      .FirstOrDefaultAsync();

                db.Tickets.Add(ticket);
                await db.SaveChangesAsync();
                await transaction.CommitAsync();

                TempData["Message"] = $"Seats {string.Join(", ", seatsToBook)} booked successfully!";
                TempData["SeatCount"] = seatsToBook.Length;
                TempData["TotalAmount"] = ((ticketPrice ?? 0) * seatsToBook.Length).ToString("F2"); // ✅ FIXED

                return RedirectToAction("Book", new { showId, theaterId, date });


            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                ModelState.AddModelError("", $"Error: {ex.Message}");
                return await Book(showId, theaterId, date);
            }
        }
        private string GenerateTransactionId()
        {
            return "TRN" + Guid.NewGuid().ToString("N").Substring(0, 10).ToUpper();
        }
        [HttpGet]
        public IActionResult Payment(int showId, int theaterId, string date)
        {



            Console.WriteLine("payment", showId, theaterId, date);
            if (HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("Login");
            }
            //var ticketPrice = db.Theaters.Where(t => t.Tid == theaterId).FirstOrDefault();

            //// Get all tickets for this booking (same show, same user, same date)
            //var tickets = db.Tickets
            //    .Where(t => t.ShowId == showId &&
            //               t.TheaterId == theaterId &&
            //               t.UserId == HttpContext.Session.GetInt32("UserId") &&
            //               t.TicketDate == Convert.ToDateTime(date))
            //    .FirstOrDefault();
            if (string.IsNullOrEmpty(date) || !DateTime.TryParse(date, out var parsedDate))
            {
                TempData["Error"] = "Invalid or missing date.";
                return RedirectToAction("Movies");
            }
                var ticketPrice = db.Theaters.FirstOrDefault(t => t.Tid == theaterId);

                // ✅ FIXED: Use parsedDate instead of Convert.ToDateTime(date)
                var tickets = db.Tickets
                    .FirstOrDefault(t => t.ShowId == showId &&
                                         t.TheaterId == theaterId &&
                                         t.UserId == HttpContext.Session.GetInt32("UserId") &&
                                         t.TicketDate == parsedDate);

                // ✅ FIXED: Check if tickets is null or SeatNumbers is null/empty
                if (tickets == null || string.IsNullOrEmpty(tickets.SeatNumbers))
                {
                    TempData["Error"] = "No ticket found for this booking or seat information is missing.";
                    return RedirectToAction("Movies");

                }

            var seatNumbers = tickets.SeatNumbers.Split(",");

            var model = new AllPayments
            {
                Payment = new Payment
                {
                    MovieId = (int)tickets.MovieId,
                    TheaterId = theaterId,
                    Ticketid = tickets.Ticketid, // Using first ticket ID as reference
                    ShowId = showId,
                    //TotalAmount = (decimal)(ticketPrice.Price * seatNumbers.Length),
                    PaymentDate = Convert.ToDateTime(date),
                    SeatNumber = string.Join(",", tickets.SeatNumbers),
                    TotalAmount = (decimal)((ticketPrice?.Price ?? 0) * seatNumbers.Length), // ✅ FIXED: null-safe ticketPrice
                                                                                             //            PaymentDate = parsedDate, // ✅ FIXED: use parsedDate
                },
                SelectedPaymentType = "UPI"  // set as default payment
            };

            ViewBag.MovieId = model.Payment.MovieId;
            ViewBag.TheaterId = theaterId;
            ViewBag.Ticketid = model.Payment.Ticketid;
            ViewBag.ShowId = showId;
            ViewBag.SeatNumbers = seatNumbers;
            ViewBag.Timings = db.ShowTimes.Where(s => s.ShowId == showId).Select(s => s.Timings).FirstOrDefault();
            ViewBag.TotalAmount = model.Payment.TotalAmount;

            return View(model);
        }
        //[HttpGet]
        //public IActionResult Payment(int showId, int theaterId, string date)
        //{
        //    if (HttpContext.Session.GetInt32("UserId") == null)
        //    {
        //        return RedirectToAction("Login");
        //    }

        //    // ✅ FIXED: Validate the date before using it
        //    if (string.IsNullOrEmpty(date) || !DateTime.TryParse(date, out var parsedDate))
        //    {
        //        TempData["Error"] = "Invalid or missing date.";
        //        return RedirectToAction("Movies");
        //    }

        //    var ticketPrice = db.Theaters.FirstOrDefault(t => t.Tid == theaterId);

        //    // ✅ FIXED: Use parsedDate instead of Convert.ToDateTime(date)
        //    var tickets = db.Tickets
        //        .FirstOrDefault(t => t.ShowId == showId &&
        //                             t.TheaterId == theaterId &&
        //                             t.UserId == HttpContext.Session.GetInt32("UserId") &&
        //                             t.TicketDate == parsedDate);

        //    // ✅ FIXED: Check if tickets is null or SeatNumbers is null/empty
        //    if (tickets == null || string.IsNullOrEmpty(tickets.SeatNumbers))
        //    {
        //        TempData["Error"] = "No ticket found for this booking or seat information is missing.";
        //        return RedirectToAction("Movies");

        //    }

        //    var seatNumbers = tickets.SeatNumbers.Split(",");

        //    var model = new AllPayments
        //    {
        //        Payment = new Payment
        //        {
        //            MovieId = (int)tickets.MovieId,
        //            TheaterId = theaterId,
        //            Ticketid = tickets.Ticketid,
        //            ShowId = showId,
        //            TotalAmount = (decimal)((ticketPrice?.Price ?? 0) * seatNumbers.Length), // ✅ FIXED: null-safe ticketPrice
        //            PaymentDate = parsedDate, // ✅ FIXED: use parsedDate
        //            SeatNumber = string.Join(",", seatNumbers),
        //        },
        //        SelectedPaymentType = "UPI"
        //    };

        //    //ViewBag.MovieId = model.Payment.MovieId;
        //    //ViewBag.TheaterId = theaterId;
        //    //ViewBag.Ticketid = model.Payment.Ticketid;
        //    //ViewBag.ShowId = showId;
        //    //ViewBag.SeatNumbers = seatNumbers;
        //    //ViewBag.Timings = db.ShowTimes.Where(s => s.ShowId == showId).Select(s => s.Timings).FirstOrDefault();
        //    //ViewBag.TotalAmount = model.Payment.TotalAmount;


        //    ViewBag.TotalAmount = model.Payment.TotalAmount;
        //    ViewBag.Ticketid = model.Payment.Ticketid;
        //    ViewBag.ShowId = model.Payment.ShowId;
        //    ViewBag.MovieId = model.Payment.MovieId;
        //    ViewBag.TheaterId = model.Payment.TheaterId;
        //    ViewBag.SeatNumbers = model.Payment.SeatNumber;

        //    ViewBag.Timings = db.ShowTimes
        //        .Where(s => s.ShowId == model.Payment.ShowId)
        //        .Select(s => s.Timings)
        //        .FirstOrDefault(); 
        //    return View(model);
        //}

        [HttpPost]
        public async Task<IActionResult> Payment(AllPayments model)
        {
            if (HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("Login");
            }
            try
            {
                using var db = new BookMyShowContext();

                // Validate show exists
                var show = await db.ShowTimes.FindAsync(model.Payment.ShowId);
                if (show == null)
                {
                    ModelState.AddModelError("", "Selected show does not exist.");
                    return View(model);
                }

                using var transaction = await db.Database.BeginTransactionAsync();

                try
                {
                    var payment = new Payment
                    {
                        MovieId = model.Payment.MovieId,
                        TheaterId = model.Payment.TheaterId,
                        Ticketid = model.Payment.Ticketid,
                        ShowId = model.Payment.ShowId,
                        Status = "Ongoing",
                        PaymentType = model.SelectedPaymentType,
                        TotalAmount = model.Payment.TotalAmount,
                        PaymentDate = DateTime.Now,
                        SeatNumber = string.Join(",", model.Payment.SeatNumber)
                    };

                    await db.Payments.AddAsync(payment);
                    await db.SaveChangesAsync(); // Get generated pid

                    // Process payment based on type
                    string transactionId = GenerateTransactionId();
                    bool paymentProcessed = false;

                    switch (model.SelectedPaymentType)
                    {
                        case "UPI":
                            paymentProcessed = await ProcessUpiPayment(db, model.Upi, payment.Pid, transactionId);
                            break;

                        case "Card":
                            paymentProcessed = await ProcessCardPayment(db, model.Card, payment.Pid, transactionId);
                            break;

                        default:
                            ModelState.AddModelError("", "Invalid payment method selected.");
                            break;
                    }

                    if (paymentProcessed)
                    {
                        // Update payment status to Success
                        payment.Status = "Success";
                        db.Payments.Update(payment);
                        await db.SaveChangesAsync();

                        // Create booking record
                        var booking = new Booking
                        {
                            Pid = payment.Pid,
                            MovieId = payment.MovieId,
                            BookingDate = DateOnly.FromDateTime(DateTime.Now),
                            ShowId = payment.ShowId,
                            Status = "Confirmed",
                            Tid = payment.TheaterId,
                            UserId = HttpContext.Session.GetInt32("UserId"),
                            SeatNumbers = string.Join(",", payment.SeatNumber),
                            TicketId = payment.Ticketid,
                            ShowTime = show.Timings
                        };

                        await db.Bookings.AddAsync(booking);
                        await db.SaveChangesAsync();

                        await transaction.CommitAsync();

                        TempData["TransactionId"] = transactionId;
                        return RedirectToAction("PaymentConfirmation", new
                        {
                            status = "success",
                            paymentId = payment.Pid
                        });
                    }
                    else
                    {
                        await transaction.RollbackAsync();
                        return View(model);
                    }
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    ModelState.AddModelError("", $"Payment processing failed: {ex.Message}");
                    return View(model);
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", $"An unexpected error occurred: {ex.Message}");
                return View(model);
            }
        }
        private async Task<bool> ProcessUpiPayment(BookMyShowContext db, Upi upiModel, int pid, string transactionId)
        {
            if (string.IsNullOrWhiteSpace(upiModel?.UpiId))
            {
                ModelState.AddModelError("Upi.UpiId", "Please enter a valid UPI ID");
                return false;
            }

            var upiDetails = new Upi
            {
                Pid = pid,
                UpiId = upiModel.UpiId.Trim(),
                TransactionId = transactionId,
                PaymentTimestamp = DateTime.Now
            };

            await db.Upis.AddAsync(upiDetails);
            return true;
        }
        private async Task<bool> ProcessCardPayment(BookMyShowContext db, Card cardModel, int pid, string transactionId)
        {
            if (cardModel == null ||
                string.IsNullOrWhiteSpace(cardModel.CardNumberMasked) ||
                string.IsNullOrWhiteSpace(cardModel.CardHolderName) ||
                string.IsNullOrWhiteSpace(cardModel.ExpiryMonth) ||
                string.IsNullOrWhiteSpace(cardModel.ExpiryYear) ||
                string.IsNullOrWhiteSpace(cardModel.CardCvv))
            {
                ModelState.AddModelError("", "Please fill all card details");
                return false;
            }

            var cardDetails = new Card
            {
                Pid = pid,
                CardNumberMasked = cardModel.CardNumberMasked.Trim(),
                CardHolderName = cardModel.CardHolderName.Trim(),
                ExpiryMonth = cardModel.ExpiryMonth.Trim(),
                ExpiryYear = cardModel.ExpiryYear.Trim(),
                CardCvv = cardModel.CardCvv.Trim(),
                CardType = cardModel.CardType ?? "Credit",
                TransactionId = transactionId,
                PaymentTimestamp = DateTime.Now
            };

            await db.Cards.AddAsync(cardDetails);
            return true;
        }
        [HttpGet]
        public IActionResult PaymentConfirmation(string status, int _paymentid)
        {
            if (HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("Login");
            }
            ViewBag.Status = status;
            ViewBag.TransactionId = TempData["TransactionId"];
            return View();
        }
        private void GenerateCaptcha()
        {
            // Generating a random string for the CAPTCHA
            string captchaCode = GenerateRandomString(6); // You can adjust the length
            HttpContext.Session.SetString("CaptchaCode", captchaCode);

            // Create the CAPTCHA image
            byte[] captchaImage = CreateCaptchaImage(captchaCode);
            ViewBag.CaptchaImage = "data:image/png;base64," + Convert.ToBase64String(captchaImage);
        }
        private string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private byte[] CreateCaptchaImage(string text)
        {
            var image = new Bitmap(150, 50);
            var graphics = Graphics.FromImage(image);

            graphics.FillRectangle(Brushes.White, 0, 0, image.Width, image.Height);
            Font font = new Font(FontFamily.GenericSerif, 24, FontStyle.Bold);
            graphics.DrawString(text, font, Brushes.Black, 10, 10);

            // Adding some noise or lines for better security
            var random = new Random();
            for (int i = 0; i < 10; i++)
            {
                graphics.DrawLine(new Pen(Color.Gray, 1),
                random.Next(image.Width), random.Next(image.Height),
                random.Next(image.Width), random.Next(image.Height));
            }

            var ms = new MemoryStream();
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();


        }
        public IActionResult MyTickets()
        {
            try
            {
                var _username = HttpContext.Session.GetString("Username");
                var _userId = HttpContext.Session.GetInt32("UserId");
                if (_username == null)
                {
                    return RedirectToAction("Login", "BookMyShow");
                }

                var booking_details = db.Bookings.Where(b => b.UserId == _userId).OrderByDescending(b => b.BookId).FirstOrDefault();
                if (booking_details == null)
                {
                    ViewBag.error = "You have not booked any details. Please book a ticket first";
                    return View();
                }
                var ticket_History = db.Tickets.Where(t => t.UserId == booking_details.UserId).FirstOrDefault();
                var movie_Name = db.Movies.Where(m => m.MovieId == booking_details.MovieId).FirstOrDefault();
                var theater_Name = db.Theaters.Where(t => t.Tid == booking_details.Tid).FirstOrDefault();
                var city_name = db.Cities.Where(t => t.CityId == theater_Name.CityId).FirstOrDefault();
                var movie_Lang1 = db.MovieLanguages.Where(t => t.MovieId == booking_details.MovieId).FirstOrDefault();
                var movie_Lang = db.Languages.Where(t => t.LanguageId == movie_Lang1.LanguageId).FirstOrDefault();

                if (ticket_History == null)
                {
                    return RedirectToAction("Movies");
                }
                ViewBag.ticketDate = ticket_History.TicketDate;
                ViewBag.ticketId = ticket_History.Ticketid;
                ViewBag.theater = theater_Name.Name;
                ViewBag.city = city_name.CityName;
                ViewBag.price = theater_Name.Price;
                ViewBag.movieName = movie_Name.MovieName;
                ViewBag.movielang = movie_Lang.Name;
                ViewBag.seatnumber = string.Join(",", booking_details.SeatNumbers);
                ViewBag.showtime = booking_details.ShowTime;
                ViewBag.bookid = booking_details.BookId;

                return View();
            }
            catch (Exception ex)
            {
                ViewBag.error = ex.Message;
                return View();
            }
        }
        public IActionResult Cancellation(int Bookid, int TicketId)
        {
            try
            {
                var booking_status = db.Bookings.Where(t => t.BookId == Bookid && t.Status == "Cancelled").FirstOrDefault();

                if (booking_status != null)
                {
                    return RedirectToAction("MyTickets", "BookMyShow");
                }

                var booking_details = db.Bookings.Where(b => b.BookId == Bookid).FirstOrDefault();
                booking_details.Status = "Cancelled";
                db.Bookings.Update(booking_details);
                db.SaveChanges();

                var payment_status = db.Payments.Where(p => p.Pid == booking_details.Pid).FirstOrDefault();
                payment_status.Status = "Refunded";
                db.SaveChanges();

                var ticket_id = db.Tickets.Where(t => t.Ticketid == booking_details.TicketId).FirstOrDefault();
                db.Tickets.Remove(ticket_id);
                db.SaveChanges();
                return View();
            }
            catch (Exception e)
            {
                ViewBag.error = e.Message;
                return View();
            }


        }
        [HttpGet]
        public async Task<IActionResult> Reschedule(int Bookid)
        {
            // 1. Validate user and booking
            if (HttpContext.Session.GetInt32("UserId") == null)
                return RedirectToAction("Login");

            var booking = await db.Bookings
                .Include(b => b.Ticket)
                .Include(b => b.Movie)
                .Include(b => b.TidNavigation) // Theater
                .FirstOrDefaultAsync(b => b.BookId == Bookid);

            if (booking == null || booking.UserId != HttpContext.Session.GetInt32("UserId"))
                return View("Error", new { Message = "Invalid booking" });

            //// 2. Prepare reschedule view
            //var availableShows = (await db.ShowTimes
            //      .Where(s => s.MovieId == booking.MovieId)
            //      .ToListAsync())
            //      .Where(s => Convert.ToDateTime(s.Timings) > DateTime.Now)
            //      .ToList();
            var availableShows = (from t in db.ShowTimes where t.MovieId == booking.MovieId && t.TheaterId == booking.Tid select t).ToList();
            ViewBag.OriginalShow = booking.ShowTime;
            ViewBag.OriginalSeats = booking.SeatNumbers;
            ViewBag.AvailableShows = availableShows;

            return View(booking);
        }
        [HttpPost]
        public async Task<IActionResult> Reschedule(int Bookid, int newShowId)
        {
            using var transaction = await db.Database.BeginTransactionAsync();

            try
            {
                // Fetch original booking with ticket
                var booking = await db.Bookings
                    .Include(b => b.Ticket)
                    .FirstAsync(b => b.BookId == Bookid);

                var originalTicket = booking.Ticket;

                // Check seat availability in new show
                var existingSeats = await db.Tickets
                    .Where(t => t.ShowId == newShowId && t.TheaterId == originalTicket.TheaterId)
                    .Select(t => t.SeatNumbers)
                    .ToListAsync();

                var allBookedSeats = existingSeats
                    .SelectMany(s => s.Split(','))
                    .Select(s => s.Trim())
                    .ToList();

                var requestedSeats = booking.SeatNumbers.Split(',').Select(s => s.Trim()).ToList();
                var conflictSeats = requestedSeats.Intersect(allBookedSeats).ToList();

                if (conflictSeats.Any())
                {
                    ModelState.AddModelError("", $"Seats {string.Join(",", conflictSeats)} unavailable in new show");
                    return await Reschedule(Bookid);
                }

                // Get new show details
                var newShow = await db.ShowTimes.FindAsync(newShowId);

                // Create new ticket
                var newTicket = new Ticket
                {
                    UserId = originalTicket.UserId,
                    MovieId = originalTicket.MovieId,
                    TheaterId = originalTicket.TheaterId,
                    ShowId = newShowId,
                    SeatNumbers = originalTicket.SeatNumbers,
                    TicketDate = DateTime.Now
                };
                db.Tickets.Add(newTicket);

                // Update booking with new show 
                booking.ShowId = newShowId;
                booking.ShowTime = newShow.Timings;
                booking.Ticket = newTicket; // Update reference

                // Remove old ticket to free up seats
                db.Tickets.Remove(originalTicket);

                await db.SaveChangesAsync();
                await transaction.CommitAsync();

                TempData["Success"] = $"Rescheduled to {newShow.Timings}";
                return RedirectToAction("Bookings");
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                ModelState.AddModelError("", $"Error: {ex.Message}");
                return await Reschedule(Bookid);
            }
        }
        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
