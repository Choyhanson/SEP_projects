using ApplicationCore.Models;
using ApplicationCore.RepositoryInterfaces;
using ApplicationCore.ServiceInterfaces;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;


namespace Infrastructure.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }
        public IEnumerable<MovieCardResponseModel> Get30HighestGrossingMovies()
        {

            // list of movie entities
            var movies = _movieRepository.Get30HighestGrossingMovies();

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
