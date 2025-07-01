using BookMyShow.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookMyShow.Controllers
{
    public class OthersController : Controller
    {
        BookMyShowContext db = new BookMyShowContext();
        //Add Genre
        [HttpGet]
        public IActionResult Genre()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Genre(IFormCollection f)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var genrename = new Genre()
                    {
                        Name = f["genre"]
                    };
                    if (!db.Genres.Any(x => x.Name.ToLower() == genrename.Name.ToLower()))
                    {
                        db.Genres.Add(genrename);
                        int i = db.SaveChanges();
                        if (i == 1)
                        {
                            ViewBag.genre = $"{genrename.Name} Added Successfully";
                        }
                    }
                    else
                    {
                        ViewBag.genreexist = $"{genrename.Name} is Already Exist";
                    }
                }
            }
            catch (Exception e)
            {
                ViewBag.genreexist = "Somthing Went Wrong";
                Console.WriteLine(e.Message);
            }
            return View();
        }
        //Add theater
        [HttpGet]
        public IActionResult AddTheater(int? cityId)
        {
            if (cityId.HasValue)
            {
                ViewBag.SelectedCityId = cityId.Value;
                HttpContext.Session.SetInt32("SelectedCityId", cityId.Value);
            }

            ViewBag.Cities = db.Cities.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult AddTheater(IFormCollection f)
        {
            var selectedcityid = Convert.ToInt32(HttpContext.Session.GetInt32("SelectedCityId"));
            ViewBag.Cities = db.Cities.ToList();
            var tName = f["tname"].ToString();
            try
            {
                if (ModelState.IsValid)
                {
                    if (!db.TheaterNames.Any(x => x.Theatername1.ToLower() == tName.ToLower() && x.CityId == selectedcityid))
                    {
                        var theatername = new TheaterName()
                        {
                            Theatername1 = tName,
                            CityId = Convert.ToInt32(HttpContext.Session.GetInt32("SelectedCityId"))
                        };
                        db.TheaterNames.Add(theatername);
                        int istrue = db.SaveChanges();
                        if (istrue == 1)
                        {
                            ViewBag.theateradded = $"{tName} Added Successfully";
                        }
                    }
                    else
                    {
                        ViewBag.theatererr = $"{tName} is Already Exist";
                    }
                }
            }
            catch (Exception e)
            {
                ViewBag.theatererr = $"Something went wrong";
                Console.WriteLine(e.Message);
            }
            return View();
        }
        //Add City
        [HttpGet]
        public IActionResult City()
        {
            return View();
        }
        [HttpPost]
        public IActionResult City(IFormCollection f)
        {
            var cityname = f["cityname"].ToString();
            try
            {
                var res = db.Cities.Where(x => x.CityName.ToLower() == cityname.ToLower()).FirstOrDefault();
                if (res == null)
                {
                    var ob = new City();
                    ob.CityName = cityname;
                    db.Cities.Add(ob);
                    int i = db.SaveChanges();
                    ViewBag.AddCitysucess = $"Cities={i} Added Successfully ";
                }
                else
                {
                    ViewBag.AddCitysucess = $"City is Already added";
                }
            }
            catch (Exception e)
            {
                ViewBag.AddCityfail = $"Something went wrong";
            }
            return View();
        }
        //Add Language
        [HttpGet]
        public IActionResult AddLanguage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddLanguage(IFormCollection f)
        {
            var lang = f["lang"].ToString();
            try
            {
                var res = db.Languages.Where(x => x.Name.ToLower() == lang.ToLower()).FirstOrDefault();
                if (res == null)
                {
                    var ob = new Language()
                    {
                        Name = lang
                    };
                    db.Languages.Add(ob);
                    int i = db.SaveChanges();
                    ViewBag.Languagesucess = $"{lang} Added Successfully ";
                }
                else
                {
                    ViewBag.Languagefail = $"{lang} is Already added";
                }
            }
            catch (Exception e)
            {
                ViewBag.Languagefail = $"Something went wrong";
            }
            return View();
        }
    }
}
