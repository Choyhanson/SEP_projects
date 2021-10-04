using ApplicationCore.Models;
using ApplicationCore.RepositoryInterfaces;
using ApplicationCore.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using MovieShopMVC.Models;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShopMVC.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(IMovieService movieService, IMovieGenreService movieGenreService, IMovieRepository movieRepository) : base(movieService, movieGenreService)
        {
        }

        public async Task< IActionResult >Index(int Page = 1,string Sort="default")
        {
            // by default it will look inside views folder => folder name with same name as
            // Controller name and look for view with same name as action method name
            // want to display top revenue movies
            // get model data

            //var table = _movieService.GetAllMovies(Page, Sort);
            var table =await _movieService.GetAllMoviesAsync(Page, Sort);


            return View(table);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> Test()
        {
            
            var genres = await _movieService.GetSortByHighestMovies();
            
            return View(genres);
        }

       
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
