using ApplicationCore.Models;
using ApplicationCore.RepositoryInterfaces;
using ApplicationCore.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class MovieGenreService : IMovieGenreService
    {

        private readonly IMovieGenreRepository _movieGenreRepository;
        public MovieGenreService(IMovieGenreRepository movieGenreRepository)
        {
            _movieGenreRepository = movieGenreRepository;
        }

        public IEnumerable<MovieCardResponseModel> GetAllGenres()
        {
            var genres = _movieGenreRepository.GetAllGenres();
            var movieGenreModels = new List<MovieCardResponseModel>();
            foreach (var item in genres)
            {
                movieGenreModels.Add(new MovieCardResponseModel
                {
                    GenreId=item.Id,
                    GenreName=item.Name
                });
            }
            return movieGenreModels;
        }

        public IEnumerable<MovieCardResponseModel> GetAllMoviesByGenre(int genreId)
        {
            var movies = _movieGenreRepository.GetAllMoviesByGenre(genreId);
            var movieGenreModels = new List<MovieCardResponseModel>();
            foreach (var item in movies)
            {
                movieGenreModels.Add(new MovieCardResponseModel
                { 
                    MovieId=item.Id,
                    MoviePosterUrl=item.PosterUrl,
                });
            }
            return movieGenreModels;
        }

        public IEnumerable<MovieCardResponseModel> GetGenreByMovieId(int movieId)
        {
            var genres = _movieGenreRepository.GetGenreByMovieId(movieId);
            var movieGenreModels = new List<MovieCardResponseModel>();
            foreach (var item in genres)
            {
                movieGenreModels.Add(new MovieCardResponseModel
                {
                    GenreId = item.Id,
                    GenreName = item.Name
                });
            }
            return movieGenreModels;
        }
    }
}
