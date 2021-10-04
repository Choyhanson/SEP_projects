using ApplicationCore.Entities;
using ApplicationCore.Models;
using ApplicationCore.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.ServiceInterfaces
{
    public interface IPurchaseRepository: IAsyncRepository<Purchase>
    {
        Task<IEnumerable< Purchase>> GetAllPurchasedMoviesByUserId(int userId);
        //Task<Purchase> PurchaseMovie(MoviePurchaseRequestModel model);
        
    }
}
