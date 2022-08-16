using System.Collections.Generic;
using System.Linq;
using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DemoMVC.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Info()
        {
            Movie movie = new Movie { Id = 1, Name = "KGF", Year = 2022, Rating = 5 };
            return View(movie);
        }
        public IActionResult List()
        {
            List<Movie> movies = GetMovies();
            return View(movies);
        }
        public List<Movie> GetMovies()
        {
            List<Movie> movies = new List<Movie>
            {
                new Movie { Id = 1, Name ="war", Year=2019, Rating=4},
                new Movie { Id = 2, Name ="aaa", Year=2022, Rating=4},
                new Movie { Id = 3, Name ="bbb", Year=2021, Rating=2},
                new Movie { Id = 4, Name ="ccc", Year=2019, Rating=1},
                new Movie { Id = 5, Name ="ddd", Year=2020, Rating=3},
                new Movie { Id = 6, Name ="fff", Year=2019, Rating=4},
                new Movie { Id = 7, Name ="ggg", Year=2019, Rating=4},
            };
            return movies;
        }

        public IActionResult Search()
        {
            return View();
        }
        public IActionResult Find(int id)
        {
            List<Movie> movies = GetMovies();
            Movie data = movies.Where(x => x.Id == id).FirstOrDefault();
            return View("Info", data);
        }

        [HttpGet]
        public IActionResult FindByRating()
        {
            List<int> ratingList = new List<int>() { 1, 2, 3, 4, 5 };
            ViewBag.rating = new SelectList(ratingList);
            return View();
        }

        [HttpPost]
        public IActionResult FindByRating(int rating)
        {
            List<Movie> movies = GetMovies();
            var data =movies.Where(x => x.Rating ==rating);
            ViewBag.MovieList = data;
            List<int> ratingList = new List<int>() { 1, 2, 3, 4, 5 };
            ViewBag.rating = new SelectList(ratingList);
            //ViewBag.rating = rating;
            return View();
        }
    }

}
