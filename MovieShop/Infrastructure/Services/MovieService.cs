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
        
        public IEnumerable<MovieCardResponseModel> Get30HighestMovies()
        {
            var movies = _movieRepository.Get30HighestGrossingMovies();
            var moviesCardResponseModel = new List<MovieCardResponseModel>();

            foreach (var item in movies)
            {
                moviesCardResponseModel.Add(new MovieCardResponseModel
                { MovieId = item.Id, MoviePosterUrl = item.PosterUrl });
            }

            return moviesCardResponseModel;
        }

        public IEnumerable<MovieCardResponseModel> GetAllMovies()
        {
            var movies = _movieRepository.GetAllMovies();
            var moviesCardResponseModel = new List<MovieCardResponseModel>();

            foreach (var item in movies)
            {
                moviesCardResponseModel.Add(new MovieCardResponseModel
                { MovieId = item.Id, MoviePosterUrl = item.PosterUrl });
            }

            return moviesCardResponseModel;
        }

        public IEnumerable<MovieCardByIdModel> GetCardByIdModels(int id)
        {
            var movie = _movieRepository.GetById(id);

            var movies = new List<MovieCardByIdModel>();

            foreach (var item in movie)
            {
                movies.Add(new MovieCardByIdModel
                {
                    Id = item.Id,
                    Title = item.Title,
                    PosterUrl = item.PosterUrl,
                    Overview = item.Overview,
                    Date = Convert.ToDateTime(item.ReleaseDate).ToShortDateString(),
                    Year = Convert.ToDateTime(item.ReleaseDate).Year,
                    RunTime = item.RunTime,
                    Revenue = Convert.ToDecimal(item.Revenue).ToString("C2"),
                    Budget = Convert.ToDecimal(item.Budget).ToString("C2"),
                    Price = item.Price,
                    BackdropUrl = item.BackdropUrl,
                    Tagline = item.Tagline,
                    CreatedDate = item.CreatedDate,
                    ImdbUrl = item.ImdbUrl,
                    TmdbUrl = item.TmdbUrl
                });
            }

            return movies;
        }
    }
}
