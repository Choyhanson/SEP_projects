using ApplicationCore.Entities;
using ApplicationCore.Models;
using ApplicationCore.RepositoryInterfaces;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.Repositories
{
    public class MovieGenreRepository : EFRepository<MovieCardResponseModel>,IMovieGenreRepository
    {
        private readonly IMovieRepository _movieRepository;
        public MovieGenreRepository(MovieShopDbContext dbContext, IMovieRepository movieRepository):base(dbContext)
        {
            _movieRepository = movieRepository;
        }

        public IEnumerable<Genre> GetAllGenres()
        {
            var genres = _movieShopDbContext.Genres;
            return  genres;
        }

        public async Task<IEnumerable<Genre>> GetAllGenresAsync()
        {
            var genres = _movieShopDbContext.Genres;
            return await genres.ToListAsync();
        }

        public  IEnumerable<MovieCardResponseModel> GetAllMoviesByGenre(int genreId)
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

            return  movies;
        }

        public async Task< IEnumerable<MovieCardResponseModel> > GetAllMoviesByGenreAsync(int genreId)
        {
            var movies = await (from m in _movieShopDbContext.Movie
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
                                }).ToListAsync();

            return movies;
        }

        public IEnumerable<Genre> GetGenreByMovieId(int movieId)
        {
            var genres = from g in _movieShopDbContext.Genres
                         join mg in _movieShopDbContext.MovieGenres
                         on g.Id equals mg.GenreId
                         where mg.MovieId == movieId
                         select g;
            return  genres;
        }
        public async Task<IEnumerable<Genre>> GetGenreByMovieIdAsync(int movieId)
        {
            var genres = from g in _movieShopDbContext.Genres
                         join mg in _movieShopDbContext.MovieGenres
                         on g.Id equals mg.GenreId
                         where mg.MovieId == movieId
                         select g;
            return await genres.ToListAsync();
        }
    }
}
