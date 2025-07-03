using BookMyShow.Models;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BookMyShow.Tests
{
    [TestFixture]
    public class BookMyShowTests
    {
        private BookMyShowContext db;

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<BookMyShowContext>()
                .UseSqlServer("Data Source=.;Initial Catalog=BookMyShowDBase;Integrated Security=True;Trust Server Certificate=True")
                .Options;

            db = new BookMyShowContext(options);
        }

        [TearDown]
        public void Cleanup()
        {
            db.Dispose();
        }

        [Test]
        [TestCase("Mumbai")]
        [TestCase("Bangalore")]
        public void Add_City(string cityName)
        {
            if (!db.Cities.Any(c => c.CityName == cityName))
            {
                db.Cities.Add(new City { CityName = cityName });
                var result = db.SaveChanges();
                Assert.That(result, Is.EqualTo(1));
            }

            Assert.That(db.Cities.Any(c => c.CityName == cityName), Is.True);
        }

        [Test]
        [TestCase("Comedy")]
        [TestCase("Science Fiction")]
        public void Add_Genre(string genreName)
        {
            if (!db.Genres.Any(g => g.Name == genreName))
            {
                db.Genres.Add(new Genre { Name = genreName });
                var result = db.SaveChanges();
                Assert.That(result, Is.EqualTo(1));
            }

            Assert.That(db.Genres.Any(g => g.Name == genreName), Is.True);
        }

        [Test]
        [TestCase("Telugu")]
        [TestCase("Kannada")]
        public void Add_Language(string languageName)
        {
            if (!db.Languages.Any(l => l.Name == languageName))
            {
                db.Languages.Add(new Language { Name = languageName });
                var result = db.SaveChanges();
                Assert.That(result, Is.EqualTo(1));
            }

            Assert.That(db.Languages.Any(l => l.Name == languageName), Is.True);
        }

        [Test]
        public void Add_Movie_With_Cast()
        {
            var genre = db.Genres.FirstOrDefault(g => g.Name == "Drama") ?? new Genre { Name = "Drama" };
            if (genre.GenreId == 0)
            {
                db.Genres.Add(genre);
                db.SaveChanges();
            }

            if (!db.Movies.Any(m => m.MovieName == "Kantara - Legacy"))
            {
                var movie = new Movie
                {
                    MovieName = "Kantara - Legacy",
                    Duration = "135min",
                    GenreId = genre.GenreId,
                    Description = "Spiritual folklore sequel",
                    ReleaseDate = new DateOnly(2025, 12, 20),
                    MoviePoster = new byte[] { },
                    MovieCasts = new List<MovieCast>
                    {
                        new MovieCast
                        {
                            Actor = "Rishab Shetty",
                            Actress = "Sapthami Gowda",
                            Director = "Rishab Shetty",
                            Producer = "Hombale Films",
                            Musician = "Ajaneesh Loknath"
                        }
                    }
                };

                db.Movies.Add(movie);
                var result = db.SaveChanges();

                Assert.That(result, Is.GreaterThanOrEqualTo(2));
            }

            Assert.That(db.Movies.Any(m => m.MovieName == "Kantara - Legacy"), Is.True);
        }
    }
}