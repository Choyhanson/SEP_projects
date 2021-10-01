using ApplicationCore.Entities;
using ApplicationCore.Models;
using ApplicationCore.RepositoryInterfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class MovieRepository : EFRepository<Movie>, IMovieRepository
    {
        public MovieRepository(MovieShopDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<IEnumerable<Movie>> GetSortByGrossingMovies()
        {
            // go to database and get data using LINQ with EF
            // async/await go as pair
            //EF, Dapper.. they have both async methods and sync method
            var movies = await _movieShopDbContext.Movie.OrderByDescending(m => m.Revenue).Take(30).ToListAsync();
            return movies;
        }
        public IEnumerable<MovieCardResponseModel> GetAllMovies()
        {
            var movies = _movieShopDbContext.Movie.OrderByDescending(m => m.Revenue).ThenBy(m => m.Title);
            var moviesCardResponseModel = new List<MovieCardResponseModel>();

            foreach (var item in movies)
            {
                moviesCardResponseModel.Add(new MovieCardResponseModel
                {
                    MovieId = item.Id,
                    MoviePosterUrl = item.PosterUrl,
                    MovieTitle = item.Title,
                    Revenue = item.Revenue,
                    Rating = GetMovieRating(item.Id)
                });
            }

            return moviesCardResponseModel;
        }

        public async Task<IEnumerable<MovieCardResponseModel>> GetAllMoviesAsync()
        {
            var movies = await _movieShopDbContext.Movie.OrderByDescending(m => m.Revenue).ThenBy(m => m.Title).ToListAsync();
            var moviesCardResponseModel = new List<MovieCardResponseModel>();

            foreach (var item in movies)
            {
                moviesCardResponseModel.Add(new MovieCardResponseModel
                {
                    MovieId = item.Id,
                    MoviePosterUrl = item.PosterUrl,
                    MovieTitle = item.Title,
                    Revenue = item.Revenue,
                    Rating = GetMovieRating(item.Id)
                });
            }

            return moviesCardResponseModel;
        }

        public override async Task<Movie> GetByIdAsync(int id)
        {
            var movies = await _movieShopDbContext.Movie.FindAsync(id);
            return movies;
        }

        public IEnumerable<MovieCastModel> GetCastByMovie(int id)
        {
            var casts = (from m in _movieShopDbContext.MovieCasts
                         where m.MovieId == id
                         join c in _movieShopDbContext.Casts
                     on m.CastId equals c.Id
                         select new MovieCastModel
                         {
                             CastId = c.Id,
                             Name = c.Name,
                             TmdbUrl = c.TmdbUrl,
                             ProfilePath = c.ProfilePath,
                             MovieId = m.MovieId,
                             Character = m.Character
                         });

            return casts;
        }

        public async Task<IEnumerable<MovieCastModel>> GetCastByMovieAsync(int id)
        {
            var casts = await (from m in _movieShopDbContext.MovieCasts
                               where m.MovieId == id
                               join c in _movieShopDbContext.Casts
                           on m.CastId equals c.Id
                               select new MovieCastModel
                               {
                                   CastId = c.Id,
                                   Name = c.Name,
                                   TmdbUrl = c.TmdbUrl,
                                   ProfilePath = c.ProfilePath,
                                   MovieId = m.MovieId,
                                   Character = m.Character
                               }).ToListAsync();

            return casts;
        }

        public decimal? GetMovieRating(int id)
        {
            var movie = _movieShopDbContext.Movie.Where(m => m.Id == id);
            var res = from m in movie
                      join r in _movieShopDbContext.Reviews
                      on m.Id equals r.MovieId into movieReview
                      from mr in movieReview.DefaultIfEmpty()
                      select new { Rating = mr == null ? 0 : mr.Rating };
            var rating = Decimal.Round(res.Average(r => r.Rating), 1);
            return rating;
        }

        public async Task<decimal?> GetMovieRatingAsync(int id)
        {
            var res = await (from m in _movieShopDbContext.Movie
                             where m.Id == id
                             join r in _movieShopDbContext.Reviews
                        on m.Id equals r.MovieId into movieReview
                             from mr in movieReview.DefaultIfEmpty()
                             select new { Rating = mr == null ? 0 : mr.Rating }).ToListAsync();
            var rating = Decimal.Round(res.Average(r => r.Rating), 1);
            return rating;
        }

        public IEnumerable<Trailer> GetTrailerByMovie(int id)
        {
            var trailers = _movieShopDbContext.Trailers.Where(t => t.MovieId == id);
            return trailers;
        }

        public async Task<IEnumerable<Trailer>> GetTrailerByMovieAsync(int id)
        {
            var trailers = await _movieShopDbContext.Trailers.Where(t => t.MovieId == id).ToListAsync();
            return trailers;
        }

        public IEnumerable<Movie> GetById(int id)
        {
            var movie = _movieShopDbContext.Movie.Where(x => x.Id == id);
            return movie;
        }

        public async Task<IEnumerable<Movie>> GetByMovieIdAsync(int id)
        {
            var movie = await _movieShopDbContext.Movie.Where(x => x.Id == id).ToListAsync();
            return movie;
        }
    }
}
