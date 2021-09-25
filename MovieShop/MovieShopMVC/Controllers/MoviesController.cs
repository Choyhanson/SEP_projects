using ApplicationCore.RepositoryInterfaces;
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
        //private readonly IMovieRepository _movieRepository;

        public MoviesController(IMovieService movieService, IMovieRepository movieRepository)
        {
            _movieService = movieService;
            //_movieRepository = movieRepository;
        }

        public IActionResult GetTopRevenueMovies()
        {
            //var movieService = new MovieNoSQLService();
            var movies = _movieService.Get30HighestMovies();
            return View(movies);
        }
     
        public IActionResult Details(int id)
        {
            var movie = _movieService.GetCardByIdModels(id);
            return View(movie);
        }
    }
}
