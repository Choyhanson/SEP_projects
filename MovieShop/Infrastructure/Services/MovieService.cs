using ApplicationCore.Models;
using ApplicationCore.RepositoryInterfaces;
using ApplicationCore.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IMovieGenreService _movieGenreService;

        public MovieService(IMovieRepository movieRepository, IMovieGenreService movieGenreService)
        {
            _movieRepository = movieRepository;
            _movieGenreService = movieGenreService;
        }
        
        public IEnumerable<MovieCardResponseModel> GetSortByHighestMovies()
        {
            var movies = _movieRepository.GetSortByGrossingMovies();
            var moviesCardResponseModel = new List<MovieCardResponseModel>();

            foreach (var item in movies)
            {
                moviesCardResponseModel.Add(new MovieCardResponseModel
                { MovieId = item.Id, MoviePosterUrl = item.PosterUrl });
            }

            return moviesCardResponseModel;
        }

        public TableViewModel GetAllMovies(int Page=1,string Sort="default")
        {
            var movies = _movieGenreService.SortDisplay(_movieRepository.GetAllMovies(),Sort);

            int itemNum = 30;
            int totalItemNum = movies.Count();
            var movie = movies.Skip((Page - 1) * itemNum).Take(itemNum);

            var table = new TableViewModel
            {
                Genres = movie,
                TotalItemNum = totalItemNum,
                CurrentPage = Page,
            };

            return table;
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
