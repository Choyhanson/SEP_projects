using ApplicationCore.ServiceInterfaces;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShopMVC.Controllers
{
    public class MoviesController : Controller
    {
        //readonly type only could be modified in constructor
        private readonly IMovieService _movieService;
        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        public IActionResult GetTopRevenueMovies()
        {
            //var movieService = new MovieNoSQLService();
            var movies = _movieService.Get30HighestGrossingMovies();
            return View(movies);
        }
     
        public IActionResult Details(int id)
        {
            return View();
        }
    }
}
