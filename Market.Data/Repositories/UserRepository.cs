using Market.Data.Contexts;
using Market.Data.IRepositories;
using Market.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Market.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext appDbContext = new AppDbContext();

        public async Task<bool> DeleteAsync(User user)
        {
            appDbContext.Users.Remove(user);
            await appDbContext.SaveChangesAsync();
            return true;
        }

        public async Task<User> GetAsync(long id)
        {
            return await appDbContext.Users.FindAsync(id);
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await appDbContext.Users.ToListAsync();
        }

        public async Task<User> InsertAsync(User user)
        {
            await appDbContext.Users.AddAsync(user);
            await appDbContext.SaveChangesAsync();
        }

        public async Task<User> UpdateAsync(User user)
        {
            appDbContext.Users.Update(user);
            await appDbContext.SaveChangesAsync();
        }
    }
}
