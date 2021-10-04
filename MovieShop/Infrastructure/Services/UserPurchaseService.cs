using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using ApplicationCore.Models;
using ApplicationCore.RepositoryInterfaces;
using ApplicationCore.ServiceInterfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services
{
    public class UserPurchaseService : IPurchaseService
    {
        private readonly IPurchaseRepository _purchaseRepository;
        private readonly MovieShopDbContext _dbContext;
        public UserPurchaseService(IPurchaseRepository purchaseRepository, MovieShopDbContext dbContext)
        {
            _purchaseRepository = purchaseRepository;
            _dbContext = dbContext;
        }

        public async Task <IEnumerable<UserPurchaseResponseModel>> GetAllPurchasedMoviesByUserId(int userId)
        {
            var purchases = await _purchaseRepository.GetAllPurchasedMoviesByUserId(userId);
            var res = new List<UserPurchaseResponseModel>();
            foreach (var item in purchases)
            {
                res.Add(new UserPurchaseResponseModel
                {
                    UserId = item.UserId,
                    MovieId = item.MovieId,
                    PurchaseDateTime = item.PurchaseDateTime,
                    PurchaseNumber = item.PurchaseNumber,
                    TotalPrice = item.TotalPrice,
                    MoviePosterUrl = item.Movie.PosterUrl,
                });
            }
            return res;
        }

        public async Task<bool> IsMoviePurchased(int userId, int movieId)
        {
            var purchases = await _purchaseRepository.ListAsync(x => x.UserId == userId);
            var res = purchases.Any(p => p.MovieId == movieId);
            return res;
        }

        public async Task<UserPurchaseResponseModel> PurchaseMovie(int userId, int movieId, decimal price)
        {
            var newPurchase = new Purchase
            {
                UserId = userId,
                MovieId = movieId,
                PurchaseDateTime = DateTime.Now,
                PurchaseNumber = Guid.NewGuid(),
                TotalPrice = price
            };
            var createPurchase = await _purchaseRepository.AddAsync(newPurchase);

            var userPurchaseResponseModel = new UserPurchaseResponseModel
            {
                UserId = createPurchase.UserId,
                MovieId = createPurchase.MovieId,
                PurchaseDateTime = createPurchase.PurchaseDateTime,
                PurchaseNumber = createPurchase.PurchaseNumber,
                TotalPrice = createPurchase.TotalPrice
            };
            return userPurchaseResponseModel;
        }

        public async Task<UserPurchaseResponseModel> PurchaseMovie(UserPurchaseRequestModel requestModel)
        {
            var newPurchase = new Purchase 
            {
                UserId = requestModel.UserId,
                MovieId = requestModel.MovieId,
                PurchaseDateTime = DateTime.Now,
                PurchaseNumber = Guid.NewGuid(),
                TotalPrice = requestModel.TotalPrice
            };
            var createPurchase = await _purchaseRepository.AddAsync(newPurchase);

            var userPurchaseResponseModel = new UserPurchaseResponseModel
            {
                UserId = createPurchase.UserId,
                MovieId = createPurchase.MovieId,
                PurchaseDateTime = createPurchase.PurchaseDateTime,
                PurchaseNumber = createPurchase.PurchaseNumber,
                TotalPrice = createPurchase.TotalPrice
            };
            return userPurchaseResponseModel;
        }

    }
}
