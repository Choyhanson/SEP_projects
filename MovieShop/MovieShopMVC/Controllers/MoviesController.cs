﻿using ApplicationCore.Models;
using ApplicationCore.RepositoryInterfaces;
using ApplicationCore.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieShopMVC.Controllers
{
    public class MoviesController : Controller
    {
        //readonly type only could be modified in constructor
        private readonly IMovieService _movieService;
        private readonly IMovieGenreService _movieGenreService;
        private readonly IMovieGenreRepository _movieGenreRepository;
        private readonly IMovieRepository _movieRepository;

        public MoviesController(IMovieService movieService, IMovieGenreService movieGenreService, IMovieRepository movieRepository, IMovieGenreRepository movieGenreRepository)
        {
            _movieService = movieService;
            _movieGenreService = movieGenreService;
            _movieRepository = movieRepository;
            _movieGenreRepository = movieGenreRepository;
        }
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            base.OnActionExecuted(context);
            ViewBag.Genres = _movieGenreService.GetAllGenres();
        }

        public IActionResult GetTopRevenueMovies()
        {
            //var movieService = new MovieNoSQLService();
            var movies = _movieService.GetSortByHighestMovies();
            return View(movies);
        }
     
        public IActionResult Details(int id)
        {
            //ViewBag.Genres = _movieGenreService.GetAllGenres();

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
            
            var movieModel = _movieGenreService.SortDisplay(
                _movieGenreRepository.GetAllMoviesByGenre(id),Sort);

            int itemNum = 30;
            int totalItemNum = movieModel.Count();
            var movies = movieModel.Skip((Page - 1) * itemNum).Take(itemNum);
            var table = new TableViewModel
            {
                Genres = movies,
                TotalItemNum = totalItemNum,
                CurrentPage=Page,
                GenreId=id
            };

            return View(table);
        }
    }
}
