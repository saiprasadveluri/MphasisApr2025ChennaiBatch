using BookMyShow.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace BookMyShow.Controllers
{
    [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
    public class AdminController : Controller
    {
        BookMyShowContext db = new BookMyShowContext();

        [HttpGet]
        public IActionResult AdminRegister()
        {
            var captchaCode = GenerateRandomCode(5);
            HttpContext.Session.SetString("CaptchaCode", captchaCode);
            ViewBag.CaptchaCode = captchaCode;

            return View();
        }
        [HttpPost]
        public IActionResult AdminRegister(IFormCollection f)
        {
            var sessionCaptcha = HttpContext.Session.GetString("CaptchaCode") ?? "";
            if (!string.Equals(f["Captcha"], sessionCaptcha, StringComparison.OrdinalIgnoreCase))
            {
                ModelState.AddModelError("Captcha", "Invalid captcha code. Please try again.");
            }

            if (ModelState.IsValid)
            {
                var admindetails = new Admin()
                {
                    Username = f["Username"],
                    Password = Encoding.UTF8.GetBytes(f["Password"])
                };
                admindetails.EnableEdit = "true";
                db.Admins.Add(admindetails);
                db.SaveChanges();
                ViewBag.success = $"{admindetails.Username} is Registered Successfully";

                return RedirectToAction("Login", "BookMyShow");
            }

            // Regenerate captcha on failure
            var newCaptchaCode = GenerateRandomCode(5);
            HttpContext.Session.SetString("CaptchaCode", newCaptchaCode);
            ViewBag.CaptchaCode = newCaptchaCode;

            return View();
        }
      
       
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            HttpContext.SignOutAsync(); ///add
            return RedirectToAction("Login", "Admin");
        }
       
        [HttpGet]
    
        public IActionResult Home()
        {
            if (HttpContext.Session.GetString("user") == null)
            {
                return RedirectToAction("Login", "BookMyShow");
            }
            ViewBag.movies = db.Movies.ToList().Count();
            // ViewBag.users = db.Users.ToList().Count;
            ViewBag.theaters = db.Theaters.ToList().Count();
            ViewBag.cities = db.Cities.ToList().Count();
            return View();
        }
        private string GenerateRandomCode(int length)
        {
            const string chars = "ABCDEFGHJKLMNPQRSTUVWXYZ23456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        //Add Movie
        [HttpGet]
      
        public IActionResult AddMovie()
        {
            ViewBag.Genre = db.Genres.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult AddMovie(IFormCollection f)
        {

            ViewBag.Genre = db.Genres.ToList();
            var movie = new Movie();
            try
            {
                movie.Duration = f["duration"];
                movie.MovieName = f["MovieName"];
                movie.GenreId = Convert.ToInt32(f["genname"]);
                movie.Description = f["des"];
                movie.ReleaseDate = DateOnly.Parse(f["rdate"]);
                var image = f.Files["poster"];
                if (image != null && image.Length > 0)
                {
                    using (var ms = new MemoryStream())
                    {
                        image.CopyTo(ms);
                        byte[] imagedata = ms.ToArray();
                        movie.MoviePoster = imagedata;
                    }
                }
                if (ModelState.IsValid)
                {
                    if (!db.Movies.Any(x => x.MovieName == movie.MovieName))
                    {
                        db.Movies.Add(movie);
                        int i = db.SaveChanges();
                        if (i == 1)
                        {
                            var res = db.Movies.Where(x => x.MovieName == movie.MovieName).FirstOrDefault();
                            HttpContext.Session.SetInt32("movieid", res.MovieId);
                            HttpContext.Session.SetString("moviename", res.MovieName);
                            var moviecast = new MovieCast()
                            {
                                MovieId = res.MovieId,
                                Actor = f["actor"],
                                Actress = f["actress"],
                                Director = f["director"],
                                Producer = f["producer"],
                                Musician = f["musician"]
                            };
                            db.MovieCasts.Add(moviecast);
                            int i2 = db.SaveChanges();
                            if (i2 == 1)
                            {
                                ViewBag.movie = $"{movie.MovieName} is Added Successfully";

                            }
                        }

                    }
                    else
                    {
                        ViewBag.movieexist = $"{movie.MovieName} is Already Exist";
                    }
                }
                else
                {
                    ViewBag.validErr = "Please Fill The All The Fields";
                }
            }
            catch (Exception e)
            {
                ViewBag.movieexist = "somthing went wrong";
                Console.WriteLine(e.Message);
            }
            return View();
        }
        //Add Movie to theater
        [HttpGet]
        public IActionResult AddMovieToTheater(int? cityId)
        {
            var movieid = Convert.ToInt32(HttpContext.Session.GetInt32("movieid"));
            ViewBag.moviename = HttpContext.Session.GetString("moviename");
            ViewBag.Languages = db.Languages.ToList();
            ViewBag.Cities = db.Cities.ToList();
            if (cityId.HasValue)
            {
                ViewBag.Theaternames = db.TheaterNames.Where(x => x.CityId == cityId.Value).ToList();
                var res = db.Cities.Where(x => x.CityId == cityId.Value).FirstOrDefault();
                ViewBag.SelectedCity = cityId.Value;
                ViewBag.SelectedCity2 = res;
                HttpContext.Session.SetInt32("cityid", cityId.Value);
            }
            else
            {
                ViewBag.Theaternames = new List<TheaterName>();
            }

            return View();
        }
        [HttpPost]
        public IActionResult AddMovieToTheater(IFormCollection f)
        {
            var selectedcityid = Convert.ToInt32(HttpContext.Session.GetInt32("cityid"));
            var city = db.Cities.Where(x => x.CityId == selectedcityid).Select(x => x.CityName).FirstOrDefault();
            var cityid = db.Cities.Where(x => x.CityName.ToLower() == city.ToLower()).FirstOrDefault();
            if (ModelState.IsValid)
            {
                try
                {
                    var list = f["theaternames"];
                    var moviename = f["mname"].ToString();
                    var lang = f["languages"];
                    var s1 = f["show"];
                    var MovieId = db.Movies.Where(x => x.MovieName.ToLower() == moviename.ToLower()).Select(x => x.MovieId).FirstOrDefault();
                    var theaterid = new Theater();
                    // add theater records 
                    foreach (var i in list)
                    {
                        if (i != null)
                        {
                            var t = new Theater()
                            {
                                Name = i,
                                Price = Convert.ToDecimal(f["mprice"]),
                                NoOfSeats = Convert.ToInt32(f["seats"]),
                                CityId = cityid.CityId,
                                MovieId = MovieId
                            };
                            var isTheaterExist = db.Theaters.Any(x => x.Name.ToLower() == t.Name.ToLower() && x.CityId == cityid.CityId && x.MovieId == MovieId);
                            if (isTheaterExist)
                            {
                                db.Theaters.Update(t);
                                db.SaveChanges();
                                theaterid = db.Theaters.Where(x => x.Name.ToLower() == t.Name.ToLower() && x.CityId == cityid.CityId && x.MovieId == MovieId).FirstOrDefault();
                            }
                            else
                            {
                                db.Theaters.Add(t);

                                db.SaveChanges();
                                theaterid = db.Theaters.Where(x => x.Name.ToLower() == t.Name.ToLower() && x.CityId == cityid.CityId && x.MovieId == MovieId).FirstOrDefault();
                            }
                            // adding records to the languages
                            foreach (var l in lang)
                            {
                                var ml = new MovieLanguage()
                                {
                                    MovieId = MovieId,
                                    LanguageId = Convert.ToInt32(l)
                                };
                                db.MovieLanguages.Add(ml);
                            }
                            db.SaveChanges();
                            // adding records to showtime
                            foreach (var s in s1)
                            {
                                var showtime = new ShowTime()
                                {

                                    MovieId = MovieId,
                                    TheaterId = theaterid.Tid,
                                    Timings = s
                                };
                                db.ShowTimes.Add(showtime);

                            }
                            db.SaveChanges();
                            ViewBag.success = "Movie Added Successfully to the Theater";
                        }
                    }
                }
                catch (Exception e)
                {
                    ViewBag.errr = "somthing went wrong";
                    Console.WriteLine(e);
                }
            }

            ViewBag.Languages = db.Languages.ToList();
            ViewBag.Cities = db.Cities.ToList();
            ViewBag.Theaternames = db.TheaterNames.Where(x => x.CityId == cityid.CityId).ToList();
            return View();
        }
        [HttpGet]
        public IActionResult DeleteMovie(int? movieId, int? cityId)
        {
            ViewBag.movies = db.Movies.ToList();
            ViewBag.Cities = db.Cities.ToList();
            if (movieId.HasValue)
            {
                ViewBag.SelectedMovieid = movieId.Value;
                HttpContext.Session.SetInt32("mid", movieId.Value);

            }
            if (cityId.HasValue)
            {
                ViewBag.SelectedCityid = cityId.Value;
                ViewBag.Theaternames = db.TheaterNames.Where(x => x.CityId == cityId.Value).ToList();
                HttpContext.Session.SetInt32("cid", cityId.Value);
            }
            else
            {
                ViewBag.Theaternames = new List<TheaterName>();
            }
            return View();

        }
        [HttpPost]
        public IActionResult DeleteMovie(IFormCollection f)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    var mid = Convert.ToInt32(HttpContext.Session.GetInt32("mid"));
                    var cid = Convert.ToInt32(HttpContext.Session.GetInt32("cid"));
                    var tid = f["tname"].ToString();
                    if (mid == 0 || cid == 0 || tid == null)
                    {
                        ViewBag.ViewBag.deletefail = $"Movie Is Not Found";
                        return View();
                    }
                    else
                    {
                        var tt = db.Theaters.Where(x => x.Name == tid && x.CityId == cid && x.MovieId == mid).FirstOrDefault();
                        if (tt != null)
                        {
                            var showtimes = db.ShowTimes.Where(x => x.MovieId == mid && x.TheaterId == tt.Tid).ToList();
                            if (showtimes != null)
                            {
                                foreach (var show in showtimes)
                                {
                                    db.ShowTimes.Remove(show);

                                }
                                var theaters = db.Theaters.Where(x => x.MovieId == mid && x.CityId == cid && x.Name.ToLower() == tid.ToLower()).ToList();
                                foreach (var theater in theaters)
                                {
                                    db.Theaters.Remove(theater);

                                }
                                db.SaveChanges();
                                ViewBag.deletesucess = $"Movie Is Successfully Deleted ";
                            }
                            else
                            {
                                ViewBag.ViewBag.deletefail = $"Movie Is Not Found";
                                return View();
                            }
                        }
                        else
                        {
                            ViewBag.ViewBag.deletefail = $"Movie Is Not Found";
                            return View();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                ViewBag.deletefail = $"Values Can't Be Empty";
                Console.WriteLine(e.InnerException);
            }
            ViewBag.movies = db.Movies.ToList();
            ViewBag.Cities = db.Cities.ToList();
            ViewBag.Theaternames = new List<TheaterName>();
            return View();
        }
        [HttpGet]
        public IActionResult UpdateMovie(int? cityId)
        {
            ViewBag.Cities = db.Cities.ToList();
            if (cityId.HasValue)
            {
                ViewBag.Theaternames = db.TheaterNames.Where(x => x.CityId == cityId.Value).ToList();
                var res = db.Cities.Where(x => x.CityId == cityId.Value).FirstOrDefault();
                ViewBag.SelectedCity = cityId.Value;
                ViewBag.SelectedCity2 = res;
                HttpContext.Session.SetInt32("cityid", cityId.Value);
            }
            else
            {
                ViewBag.Theaternames = new List<TheaterName>();
            }
            return View();
        }
        [HttpPost]
        public IActionResult UpdateMovie(IFormCollection f)
        {
            var selectedcityid = Convert.ToInt32(HttpContext.Session.GetInt32("cityid"));
            var moviename = f["mname"].ToString();
            var cityname = f["cityname"].ToString();
            var theatername = f["tname"].ToString();
            var price = Convert.ToDecimal(f["mprice"]);
            ViewBag.Cities = db.Cities.ToList();
            ViewBag.Theaternames = new List<TheaterName>();
            var shows = f["show"];
            try
            {
                var res = db.Movies.Where(x => x.MovieName.ToLower() == moviename.ToLower()).FirstOrDefault();
                if (res == null)
                {
                    ViewBag.updatefail = $"{moviename} Is Not Found";
                    return View();
                }
                var city = db.Cities.Where(x => x.CityId == selectedcityid).FirstOrDefault();
                var theater_record = db.Theaters.Where(x => x.Name.ToLower() == theatername.ToLower()).FirstOrDefault();
                var theaters = db.Theaters.Where(x => x.MovieId == res.MovieId && x.CityId == city.CityId && x.Name.ToLower() == theatername.ToLower()).FirstOrDefault();
                if (theaters == null)
                {
                    ViewBag.updatefail = $"{moviename} Is Not Found";
                    return View();
                }
                else
                {
                    theaters.Price = price;
                    var showtimes = db.ShowTimes.Where(x => x.MovieId == res.MovieId && x.TheaterId == theaters.Tid).ToList();
                    foreach (var show in showtimes)
                    {
                        db.ShowTimes.Remove(show);

                    }
                    db.SaveChanges();
                    foreach (var s in shows)
                    {
                        var showtime = new ShowTime()
                        {

                            MovieId = res.MovieId,
                            TheaterId = theaters.Tid,
                            Timings = s
                        };
                        db.ShowTimes.Add(showtime);
                    }
                    db.SaveChanges();
                    var image = f.Files["poster"];
                    if (image != null && image.Length > 0)
                    {
                        using (var ms = new MemoryStream())
                        {
                            image.CopyTo(ms);
                            byte[] imagedata = ms.ToArray();
                            res.MoviePoster = imagedata;
                        }
                    }
                    db.SaveChanges();
                    ViewBag.updatesucess = $"{moviename} Is Successfully Updated From {theatername}";
                }
            }
            catch (Exception e)
            {
                ViewBag.updatefail = $"Something Went Wrong";
                Console.WriteLine(e.InnerException);
            }
            return View();
        }
        public IActionResult Comments(int page = 1)
        {
            int pageSize = 5;
            var comments = db.Reviews
                .Include(c => c.Movie)
                .Include(c => c.UidNavigation)
                .OrderByDescending(c => c.CommentText);

            int totalComments = comments.Count();
            var pagedComments = comments
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            ViewBag.TotalPages = (int)Math.Ceiling(totalComments / (double)pageSize);
            ViewBag.CurrentPage = page;

            return View(pagedComments);
        }
        [HttpPost]
        public IActionResult DeleteComments(int id, int page)
        {
            var comment = db.Reviews.Find(id);
            if (comment != null)
            {
                db.Reviews.Remove(comment);
                db.SaveChanges();
            }
            return RedirectToAction("Comments", new { page });
        }
        [HttpGet]
        public IActionResult SuperAdmin()
        {
            ViewBag.Admins = db.Admins.Where(x => x.AdminId != 4).ToList();
            return View();
        }
        [HttpPost]
        public IActionResult SuperAdmin(IFormCollection f)
        {
            var adminid = Convert.ToInt32(f["AdminId"]);
            var enableedit = f["enableedit"];
            try
            {
                var admin = db.Admins.Where(x => x.AdminId == adminid).FirstOrDefault();
                if (admin != null)
                {
                    admin.EnableEdit = enableedit;
                    db.Admins.Update(admin);
                    db.SaveChanges();
                    ViewBag.EnableEditSucess = $"{enableedit} Status Updated Successfully";
                }
                else
                {
                    ViewBag.EnableEditFail = $"Admin with ID {adminid} not found.";
                }
            }
            catch (Exception e)
            {
                ViewBag.EnableEditFail = $"Admin Not Existed";
                Console.WriteLine(e.InnerException);
            }
            ViewBag.Admins = db.Admins.ToList();

            return View();
        }
    }
}
