using Market.Data.Contexts;
using Market.Data.IRepositories;
using Market.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Market.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext appDbContext = new AppDbContext();
        public async Task<bool> DeleteAsync(Predicate<Product> predicate)
        {
            if (predicate == null)
                predicate = x => true;

            var entityDelete = appDbContext.Users.ToList().Where(x => predicate(x));
            if (entityDelete is null)
                return false;

            appDbContext.Users.Remove(entityDelete);
            await appDbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Product> InsertAsync(Product entity)
        {
            var product = await appDbContext.Products.AddAsync(entity);
            await appDbContext.SaveChangesAsync();
            return product.Entity;
        }

        public List<Product> SelectAllAsync(Predicate<Product> predicate = null)
        {
            if (predicate is null) 
                predicate = x => true;

            return appDbContext.Products.ToList().Where(x => predicate(x)).ToList();
        }

        public async Task<Product> SelectAsync(Predicate<Product> predicate = null)
        {
            if (predicate is null)
                predicate = x => true;

            return appDbContext.Products.ToList().FirstOrDefault(x => predicate(x));
        }

        public async Task<Product> UpdateAsync(long id, Product entity)
        {
            var update = appDbContext.Products.Update(entity);
            await appDbContext.SaveChangesAsync();
            return update.Entity;
        }
    }
}
