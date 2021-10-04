using ApplicationCore.Entities;
using ApplicationCore.Models;
using ApplicationCore.ServiceInterfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class UserPurchaseRepository : EFRepository<Purchase>, IPurchaseRepository
    {
        public UserPurchaseRepository(MovieShopDbContext dbContext):base(dbContext)
        {

        }
        public async Task<IEnumerable<Purchase>> GetAllPurchasedMoviesByUserId(int userId)
        {
            //var res =await ListAsync(x => x.UserId==userId);
            var res = await _movieShopDbContext.Purchases.Include(p => p.Movie).Where(p => p.UserId==userId).OrderByDescending(p => p.PurchaseDateTime).ToListAsync();
            return res;
        }

        

       
    }
}
