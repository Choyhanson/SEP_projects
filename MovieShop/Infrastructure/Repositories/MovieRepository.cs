using ApplicationCore.Entities;
using ApplicationCore.Models;
using ApplicationCore.RepositoryInterfaces;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MovieShopDbContext _movieShopDbContext;
        public MovieRepository(MovieShopDbContext dbContext)
        {
            _movieShopDbContext = dbContext;
        }
        public IEnumerable<Movie> GetSortByGrossingMovies()
        {
            // go to database and get data using LINQ with EF
            var movies = _movieShopDbContext.Movie.OrderByDescending(m => m.Revenue).ToList();
            return movies;
        }
        public IEnumerable<MovieCardResponseModel> GetAllMovies()
        {
            var movies = _movieShopDbContext.Movie.OrderByDescending(m => m.Revenue).ThenBy(m => m.Title).ToList();
            var moviesCardResponseModel = new List<MovieCardResponseModel>();

            foreach (var item in movies)
            {
                moviesCardResponseModel.Add(new MovieCardResponseModel
                { MovieId = item.Id, MoviePosterUrl = item.PosterUrl,
                MovieTitle=item.Title,Revenue=item.Revenue});
            }

            return moviesCardResponseModel;
        }

        public IEnumerable<Movie> GetById(int id)
        {
            var movies = _movieShopDbContext.Movie.Where(i => i.Id==id);
            return movies;
        }

        public IEnumerable<MovieCastModel> GetCastByMovie(int id)
        {
            var movie = _movieShopDbContext.MovieCasts.Where(m => m.MovieId == id);
            var casts = (from m in movie
                         join c in _movieShopDbContext.Casts
                          on m.CastId equals c.Id
                         select new
                         {
                             m,c 
                         });
            var res = new List<MovieCastModel>();
            foreach (var item in casts)
            {
                res.Add(new MovieCastModel
                {
                    CastId = item.c.Id,
                    Name = item.c.Name,
                    TmdbUrl = item.c.TmdbUrl,
                    ProfilePath = item.c.ProfilePath,
                    MovieId = item.m.MovieId,
                    Character = item.m.Character
                });
            }
            return res;
        }

        public decimal? GetMovieRating(int id)
        {
            var movie = _movieShopDbContext.Movie.Where(m => m.Id == id);
            var res = from m in movie
                          join r in _movieShopDbContext.Reviews
                          on m.Id equals r.MovieId into movieReview
                          from mr in movieReview.DefaultIfEmpty()
                          select new { Rating = mr == null ? 0 : mr.Rating };
            var rating = Decimal.Round(res.Average(r => r.Rating),1);
            return rating;              
        }

        public IEnumerable<Trailer> GetTrailerByMovie(int id)
        {
            var trailers = _movieShopDbContext.Trailers.Where(t => t.MovieId == id).ToList();
            return trailers;
        }
    }
}
