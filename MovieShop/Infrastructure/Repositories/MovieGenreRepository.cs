using ApplicationCore.Entities;
using ApplicationCore.Models;
using ApplicationCore.RepositoryInterfaces;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Repositories
{
    public class MovieGenreRepository : IMovieGenreRepository
    {
        private readonly MovieShopDbContext _movieShopDbContext;
        private readonly IMovieRepository _movieRepository;
        public MovieGenreRepository(MovieShopDbContext dbContext, IMovieRepository movieRepository)
        {
            _movieShopDbContext = dbContext; 
            _movieRepository = movieRepository;
        }


        public IEnumerable<Genre> GetAllGenres()
        {
            var genres = _movieShopDbContext.Genres;
            return genres;
        }

        public IEnumerable<MovieCardResponseModel> GetAllMoviesByGenre(int genreId)
        {
            var movies = (from m in _movieShopDbContext.Movie
                            join mg in _movieShopDbContext.MovieGenres
                            on m.Id equals mg.MovieId
                            where mg.GenreId == genreId
                            select new MovieCardResponseModel
                            {
                                MovieId = m.Id,
                                GenreId = mg.GenreId,
                                MovieTitle = m.Title,
                                MoviePosterUrl = m.PosterUrl,
                                Revenue = m.Revenue,
                                Rating = _movieRepository.GetMovieRating(m.Id)
                            });


            //var table = new List<MovieCardResponseModel>();
            //foreach (var m in movies)
            //{
            //    table.Add(new MovieCardResponseModel
            //    {
            //        MovieId = m.MovieId,
            //        GenreId = m.GenreId,
            //        MovieTitle = m.MovieTitle,
            //        MoviePosterUrl = m.MoviePosterUrl,
            //        Revenue = m.Revenue,
            //        Rating = _movieRepository.GetMovieRating(m.MovieId)
            //    });
            //}
            return movies;
        }

        public IEnumerable<Genre> GetGenreByMovieId(int movieId)
        {
            var genres = from g in _movieShopDbContext.Genres
                         join mg in _movieShopDbContext.MovieGenres
                         on g.Id equals mg.GenreId
                         where mg.MovieId == movieId
                         select g;
            return genres;
        }
    }
}
