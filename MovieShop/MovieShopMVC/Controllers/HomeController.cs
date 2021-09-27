using ApplicationCore.Models;
using ApplicationCore.ServiceInterfaces;
using Infrastructure.Repositories;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using MovieShopMVC.Models;
using System;
using System.Diagnostics;
using System.Linq;

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

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            base.OnActionExecuted(context);
            ViewBag.Genres = _movieGenreService.GetAllGenres();
            ViewBag.Method = _movieGenreService;
        }

        public IActionResult Index(int Page = 1)
        {
            // by default it will look inside views folder => folder name with same name as
            // Controller name and look for view with same name as action method name
            // want to display top revenue movies
            // get model data

            var movie = _movieService.GetAllMovies();
            int itemNum = 30;
            int totalItemNum = movie.Count();
            var movies = movie.Skip((Page - 1) * itemNum).Take(itemNum);
            var table = new TableViewModel
            {
                Genres = movies,
                TotalItemNum = totalItemNum,
                CurrentPage = Page
            };


            return View(table);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Test()
        {
            
            var genres = _movieGenreService.GetAllGenres();

            
            return View(genres);
        }

       
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
