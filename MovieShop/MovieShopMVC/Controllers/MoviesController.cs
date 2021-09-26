using ApplicationCore.Models;
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
        private readonly IMovieGenreService _movieGenreService;

        public MoviesController(IMovieService movieService, IMovieGenreService movieGenreService)
        {
            _movieService = movieService;
            _movieGenreService = movieGenreService;
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
            var genre = _movieGenreService.GetGenreByMovieId(id);

            var table = new TableViewModel
            {
                Movies=movie,
                Genres=genre
            };
            return View(table);
        }
        public IActionResult GenreViews(int id)
        {
            var movies = _movieGenreService.GetAllMoviesByGenre(1);
            return View(movies);
        }
    }
}
