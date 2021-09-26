using ApplicationCore.Models;
using ApplicationCore.ServiceInterfaces;
using Infrastructure.Repositories;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieShopMVC.Models;
using System;
using System.Diagnostics;

namespace MovieShopMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMovieService _movieService;
        private readonly IMovieGenreService _movieGenreService;
        public HomeController(IMovieService movieService,IMovieGenreService movieGenreService)
        {
            _movieService = movieService;
            _movieGenreService = movieGenreService;
        }

        public IActionResult Index()
        {
            // by default it will look inside views folder => folder name with same name as
            // Controller name and look for view with same name as action method name
            // want to display top revenue movies
            // get model data

            var movieService = _movieService;
            var movies = movieService.Get30HighestMovies();

            return View(movies);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Test()
        {
            var movie = _movieService.GetCardByIdModels(47);
            var genre = _movieGenreService.GetGenreByMovieId(47);

            var table = new TableViewModel
            {
                Movies = movie,
                Genres = genre
            };
            return View(table);
        }

       
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
