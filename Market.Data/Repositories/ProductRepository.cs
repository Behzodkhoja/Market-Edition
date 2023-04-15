using Market.Data.Contexts;
using Market.Data.IRepositories;
using Market.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Market.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext appDbContext = new AppDbContext();
        public async Task<bool> DeleteAsync(Product entity)
        {
            appDbContext.Products.Remove(entity);
            await appDbContext.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await appDbContext.Products.ToListAsync();
        }

        public async Task<Product> GetAsync(long id)
        {
            return await appDbContext.Products.FindAsync(id);
        }

        public async Task InsertAsync(Product entity)
        {
            await appDbContext.Products.AddAsync(entity);
            await appDbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Product entity)
        {
            appDbContext.Products.Update(entity);
            await appDbContext.SaveChangesAsync();
        }
    }
}
