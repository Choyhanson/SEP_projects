using ApplicationCore.Models;
using ApplicationCore.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;

namespace MovieShopMVC.Controllers
{
    public class UserController : BaseController
    {
        private readonly IUserService _userService;
        private readonly ICurrentUserService _currentUserService;
        private readonly IPurchaseService _purchaseService;
        private readonly IFavoriteService _movieFavoriteService;

        public UserController(IFavoriteService movieFavoriteService,IPurchaseService purchaseService,IMovieService movieService, IMovieGenreService movieGenreService, IUserService userService, ICurrentUserService currentUserService) 
            : base(movieService, movieGenreService)
        {
            _userService = userService;
            _currentUserService = currentUserService;
            _purchaseService = purchaseService;
            _movieFavoriteService = movieFavoriteService;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Purchases()
        {
            var userId = _currentUserService.UserId;
            //var purchases =await _purchaseService.GetAllPurchasedMoviesByUserId(32881);
            var purchases =await _purchaseService.GetAllPurchasedMoviesByUserId(userId);
            // call the User Service to get movies purchased by user, and send the data to the view, and use the existing MovieCard partial View
            return View(purchases);
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> PurchaseAction(int movieId,decimal price)
        {
            var userId = _currentUserService.UserId;
            var res = await _purchaseService.PurchaseMovie(userId, movieId, price);
            return RedirectToAction("Purchases");
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> PurchaseAction(UserPurchaseRequestModel requestModel)
        {
            var userId = _currentUserService.UserId;
            requestModel.UserId = userId;
            var res = await _purchaseService.PurchaseMovie(requestModel);
            return RedirectToAction("Purchases");
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Favorites()
        {
            var userId = _currentUserService.UserId;
            var favorites = await _movieFavoriteService.GetAllFavoriteMoviesByUserId(userId);
            // call the User Service to get movies Favorited by user, and send the data to the view, and use the existing MovieCard partial View

            return View(favorites);
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> AddFavorite(int movieId)
        {
            var userId = _currentUserService.UserId;
            var favorites = await _movieFavoriteService.AddFavoriteMovie(userId,movieId);
            // call the User Service to get movies Favorited by user, and send the data to the view, and use the existing MovieCard partial View
            return RedirectToAction("Favorites");
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> RemoveFavorite(int movieId)
        {
            var userId = _currentUserService.UserId;
            await _movieFavoriteService.RemoveFavoriteMovie(userId,movieId);

            // call the User Service to get movies Favorited by user, and send the data to the view, and use the existing MovieCard partial View
            return RedirectToAction("Favorites");
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Details()
        {
            // call the User Service to get User Details and display in a View
            // get user id from httpcontext and send it to user services
            // 
            var userId = _currentUserService.UserId;

            return View();
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Edit()
        {
            var userId = _currentUserService.UserId;
            return View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Edit(UserEditRequestModel model)
        {
            return View();
        }

    }
}
