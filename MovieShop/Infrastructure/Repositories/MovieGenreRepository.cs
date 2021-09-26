﻿using ApplicationCore.Entities;
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
        public MovieGenreRepository(MovieShopDbContext dbContext)
        {
            _movieShopDbContext = dbContext;
        }

        public IEnumerable<Genre> GetAllGenres()
        {
            var genres = _movieShopDbContext.Genres.ToList();
            return genres;
        }

        public IEnumerable<Movie> GetAllMoviesByGenre(int genreId)
        {
            var movies = (from m in _movieShopDbContext.Movie
                          join mg in _movieShopDbContext.MovieGenres
                          on m.Id equals mg.MovieId
                          where mg.GenreId == genreId
                          select m).Take(30);
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