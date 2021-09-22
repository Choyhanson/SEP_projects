using ApplicationCore.Models;
using ApplicationCore.ServiceInterfaces;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;


namespace Infrastructure.Services
{
    public class MovieService : IMovieService
    {
        public IEnumerable<MovieCardResponseModel> Get30HighestGrossingMovies()
        {
            var repo = new MovieRepository();

            // list of movie entities
            var movies = repo.Get30HighestGrossingMovies();

            var moviesCardResponseModel = new List<MovieCardResponseModel>();

            // mapping entities to models data so that services always return models not entities
            foreach (var item in movies)
            {
                moviesCardResponseModel.Add(new MovieCardResponseModel 
                { Id = item.Id, PosterUrl = item.PosterUrl });
            }

            // need to return list movieResponse models
            return moviesCardResponseModel;
        }
    }
}
