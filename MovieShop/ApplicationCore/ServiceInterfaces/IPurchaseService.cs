using System.Collections.Generic;
using System.Threading.Tasks;
using ApplicationCore.Models;

namespace ApplicationCore.ServiceInterfaces
{
    public interface IPurchaseService
    {
        //Task<UserPurchaseResponseModel> GetAllPurchasedMoviesByUserId(int userId);
        Task<IEnumerable<UserPurchaseResponseModel>> GetAllPurchasedMoviesByUserId(int userId);
        Task<UserPurchaseResponseModel> PurchaseMovie(UserPurchaseRequestModel requestModel);
        Task<UserPurchaseResponseModel>PurchaseMovie(int userId, int movieId, decimal price);
        Task<bool> IsMoviePurchased(int userId, int movieId);
    }
}
    