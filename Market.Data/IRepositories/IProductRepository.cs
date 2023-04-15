using Market.Domain.Entities;

namespace Market.Data.IRepositories
{
    public interface IProductRepository
    {
        Task InsertAsync(Product entity);
        Task UpdateAsync(Product entity);
        Task<bool> DeleteAsync(Product entity);
        Task<Product> GetAsync(long id);
        Task<IEnumerable<Product>> GetAllAsync();
    }
}
