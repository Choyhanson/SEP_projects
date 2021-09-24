using ApplicationCore.Entities;
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
        public IEnumerable<Movie> Get30HighestGrossingMovies()
        {
            // go to database and get data using LINQ with EF
            var movies = _movieShopDbContext.Movie.OrderByDescending(m => m.Revenue).Take(30).ToList();
            return movies;
        }
    }
}
