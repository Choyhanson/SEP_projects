using ApplicationCore.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace MovieShopMVC.Controllers
{
    public class MoviesController : BaseController
    {
        //readonly type only could be modified in constructor

        public MoviesController(IMovieService movieService, IMovieGenreService movieGenreService):
            base(movieService, movieGenreService)
        {
        }

        public IActionResult GetTopRevenueMovies()
        {
            var movies = _movieService.GetSortByHighestMovies();
            return View(movies);
        }
     
        public async Task< IActionResult >Details(int id)
        {
            if (TempData["MovieId"]!=null)
            {
                var table = await _movieService.GetMovieDetailAsync(Convert.ToInt32( TempData["MovieId"]));
                TempData["MovieId"] = null;
                return View(table);
            }
            else
            { 
                var table = await _movieService.GetMovieDetailAsync(id);
                return View(table);
            }
        }
        public async Task <IActionResult >GenreViews(int id,int Page=1, string Sort="default")
        {
            //var table =  _movieGenreService.GetAllMoviesByGenre(id, Page, Sort);
            var table = await _movieGenreService.GetAllMoviesByGenreAsync(id, Page, Sort);

            return View(table);
        }
    }
}
