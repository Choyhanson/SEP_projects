using ApplicationCore.Models;
using ApplicationCore.RepositoryInterfaces;
using ApplicationCore.ServiceInterfaces;
using System.Collections.Generic;
using System.Linq;
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
                    GenreId = item.Id,
                    GenreName = item.Name
                });
            }

            return movieGenreModels;

        }

        public async Task<IEnumerable<MovieCardResponseModel>> GetAllGenresAsync()
        {
            var genres = await _movieGenreRepository.GetAllGenresAsync();
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

        public  IEnumerable<MovieCardResponseModel> SortDisplay( IEnumerable<MovieCardResponseModel> movieModel,string Sort = "default")
        {
            var movies = movieModel;

            IEnumerable<MovieCardResponseModel> res;
            switch (Sort)
            {
                default:
                    res = movies;
                    break;
                case "a-z":
                    res = movies.OrderBy(m => m.MovieTitle);
                    break;
                case "z-a":
                    res = movies.OrderByDescending(m => m.MovieTitle);
                    break;
                case "rating":
                    res = movies.OrderByDescending(m => m.Rating).ThenByDescending(m => m.Revenue);
                    break;
            }
            return res;
        }


        public TableViewModel GetAllMoviesByGenre(int id, int Page = 1, string Sort = "default")
        {
            var movie =  _movieGenreRepository.GetAllMoviesByGenre(id);
            var movieModel =  SortDisplay(movie,Sort);

            int itemNum = 30;
            int totalItemNum = movieModel.Count();
            var movies = movieModel.Skip((Page - 1) * itemNum).Take(itemNum);
            var table = new TableViewModel
            {
                Genres = movies,
                TotalItemNum = totalItemNum,
                CurrentPage = Page,
                GenreId = id
            };
            return table;
        }

        public async Task< TableViewModel >GetAllMoviesByGenreAsync(int id, int Page = 1, string Sort = "default")
        {
            var movie = await _movieGenreRepository.GetAllMoviesByGenreAsync(id);
            var movieModel = SortDisplay(movie, Sort);

            int itemNum = 30;
            int totalItemNum = movieModel.Count();
            var movies = movieModel.Skip((Page - 1) * itemNum).Take(itemNum);
            var table = new TableViewModel
            {
                Genres = movies,
                TotalItemNum = totalItemNum,
                CurrentPage = Page,
                GenreId = id
            };
            return table;
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

        public async Task< IEnumerable<MovieCardResponseModel> >GetGenreByMovieIdAsync(int movieId)
        {
            var genres =await _movieGenreRepository.GetGenreByMovieIdAsync(movieId);
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
