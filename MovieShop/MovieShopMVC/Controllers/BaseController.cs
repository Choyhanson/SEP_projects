using ApplicationCore.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace MovieShopMVC.Controllers
{
    public abstract class BaseController : Controller
    {
        public readonly IMovieService _movieService;
        public readonly IMovieGenreService _movieGenreService;
        public BaseController(IMovieService movieService, IMovieGenreService movieGenreService)
        {
            _movieService = movieService;
            _movieGenreService = movieGenreService;
        }

        public  override void OnActionExecuted(ActionExecutedContext context)
        {
            ViewBag.Method = _movieGenreService;
            ViewBag.Genres = _movieGenreService.GetAllGenres();
            base.OnActionExecuted(context);
            

        }
    }
}
