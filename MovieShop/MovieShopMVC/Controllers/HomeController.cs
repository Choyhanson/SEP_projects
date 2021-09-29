using ApplicationCore.Models;
using ApplicationCore.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using MovieShopMVC.Models;
using System.Diagnostics;
using System.Linq;

namespace MovieShopMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMovieService _movieService;
        private readonly IMovieGenreService _movieGenreService;
        public HomeController(IMovieService movieService,IMovieGenreService movieGenreService)
        {
            _movieService = movieService;
            _movieGenreService = movieGenreService;
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            base.OnActionExecuted(context);
            ViewBag.Genres = _movieGenreService.GetAllGenres();
            ViewBag.Method = _movieGenreService;
        }

        public IActionResult Index(int Page = 1,string Sort="default")
        {
            // by default it will look inside views folder => folder name with same name as
            // Controller name and look for view with same name as action method name
            // want to display top revenue movies
            // get model data

            var table = _movieService.GetAllMovies(Page,Sort);
            
            return View(table);
        }


       

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Test()
        {
            
            var genres = _movieGenreService.GetAllGenres();

            
            return View(genres);
        }

       
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
