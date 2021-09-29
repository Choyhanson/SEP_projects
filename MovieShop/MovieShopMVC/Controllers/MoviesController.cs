﻿using ApplicationCore.Models;
using ApplicationCore.RepositoryInterfaces;
using ApplicationCore.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace MovieShopMVC.Controllers
{
    public class MoviesController : BaseController
    {
        //readonly type only could be modified in constructor
        private readonly IMovieGenreRepository _movieGenreRepository;
        private readonly IMovieRepository _movieRepository;

        public MoviesController(IMovieService movieService, IMovieGenreService movieGenreService, IMovieRepository movieRepository, IMovieGenreRepository movieGenreRepository):
            base(movieService, movieGenreService)
        {
            _movieRepository = movieRepository;
            _movieGenreRepository = movieGenreRepository;
        }

        public IActionResult GetTopRevenueMovies()
        {
            var movies = _movieService.GetSortByHighestMovies();
            return View(movies);
        }
     
        public IActionResult Details(int id)
        {
            var movie = _movieService.GetCardByIdModels(id);
            var genre = _movieGenreService.GetGenreByMovieId(id);
            var rating = _movieRepository.GetMovieRating(id);
            var casts = _movieRepository.GetCastByMovie(id);
            var trailers = _movieRepository.GetTrailerByMovie(id);

            var table = new TableViewModel
            {
                Movies = movie,
                Genres = genre,
                Rating = rating,
                Casts = casts,
                Trailers = trailers 
            };
            return View(table);
        }
        public IActionResult GenreViews(int id,int Page=1, string Sort="default")
        {
            var table = _movieGenreService.GetAllMoviesByGenre(id, Page, Sort);

            return View(table);
        }
    }
}
