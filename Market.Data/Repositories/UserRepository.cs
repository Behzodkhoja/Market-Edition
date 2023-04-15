using Market.Data.Contexts;
using Market.Data.IRepositories;
using Market.Domain.Entities;

namespace Market.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext appDbContext = new AppDbContext();
        public async Task<bool> DeleteAsync(Predicate<User> predicate)
        {
            if (predicate == null)
                predicate = x => true;

            var entityDelete = appDbContext.Users.ToList().Where(x => predicate(x));
            if (entityDelete is null)
                return false;

            appDbContext.Users.RemoveRange(entityDelete);
            await appDbContext.SaveChangesAsync();
            return true;
        }

        public async Task<User> InsertAsync(User entity)
        {
            var eee = await appDbContext.Users.AddAsync(entity);
            await appDbContext.SaveChangesAsync();
            return eee.Entity;
        }

        public List<User> SelectAllAsync(Predicate<User> predicate = null)
        {
            if (predicate == null)
                predicate = x => true;

            return appDbContext.Users.ToList().Where(x => predicate(x)).ToList();
        }

        public User SelectAsync(Predicate<User> predicate = null)
        {
            if (predicate == null)
                predicate = x => true;

            return appDbContext.Users.ToList().FirstOrDefault(x => predicate(x));
        }

        public async Task<User> UpdateAsync(long id, User entity)
        {
            var update = appDbContext.Users.Update(entity);
            await appDbContext.SaveChangesAsync();
            return update.Entity;

        }
    }
}
