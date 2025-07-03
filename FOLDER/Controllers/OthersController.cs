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
                ViewBag.SelectedCity = cityId.Value;
                HttpContext.Session.SetInt32("SelectedCityId", cityId.Value);
            }

            ViewBag.Cities = db.Cities.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult AddTheater(IFormCollection f)
        {
            //var SelectedCityId = Convert.ToInt32(HttpContext.Session.GetInt32("SelectedCityId"));
            //ViewBag.Cities = db.Cities.ToList();
            var tName = f["tname"].ToString();
            var cityIdStr = f["cityId"].ToString();


            if (!int.TryParse(cityIdStr, out int selectedCityId))
            {
                ViewBag.theatererr = "Please select a valid city.";
                ViewBag.Cities = db.Cities.ToList();
                return View();
            }

            ViewBag.Cities = db.Cities.ToList();
            ViewBag.SelectedCity = selectedCityId;

            try
            {
                if (ModelState.IsValid)
                {
                    bool exists = db.TheaterNames.Any(x =>
                        x.Theatername1.ToLower() == tName.ToLower() &&
                        x.CityId == selectedCityId);

                    if (!exists)
                    {
                        var theater = new TheaterName
                        {
                            Theatername1 = tName,
                            CityId = selectedCityId
                        };

                        db.TheaterNames.Add(theater);
                        int result = db.SaveChanges();

                        if (result == 1)
                        {
                            ViewBag.theateradded = $"{tName} added successfully.";
                        }
                    }
                    else
                    {
                        ViewBag.theatererr = $"{tName} already exists in the selected city.";
                    }
                }
            }
            catch (Exception e)
            {
                ViewBag.theatererr = $"Something went wrong: {e.Message}";
                Console.WriteLine(e);
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
