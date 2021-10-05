using ApplicationCore.Entities;
using ApplicationCore.RepositoryInterfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
   public class UserRepository: EFRepository<User>,IUserRepository
    {
        public UserRepository(MovieShopDbContext dbContext):base(dbContext)
        {

        }

        public IAsyncEnumerator<User> GetAsyncEnumerator(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public async  Task<User> GetUserByEmail(string email)
        {
            var user = await _movieShopDbContext.Users.FirstOrDefaultAsync(u => u.Email == email);
            return user;
        }

        public IEnumerable<User> GetUserByEmailNoTracking(string email)
        {
            var user = _movieShopDbContext.Users.Where(u => u.Email == email).AsNoTracking();
            return user;
        }
        public override async Task<User> UpdateAsync(User entity)
        {
            _movieShopDbContext.Entry(entity).State = EntityState.Modified;
            await _movieShopDbContext.SaveChangesAsync();

            return entity;
        }
    }
}
