using Market.Domain.Entities;

namespace Market.Data.IRepositories
{
    public interface IProductRepository
    {
        Task<Product> InsertAsync(Product entity);
        Task<Product> UpdateAsync(long id, Product entity);
        Task<bool> DeleteAsync(Predicate<Product> predicate);
        Task<Product> SelectAsync(Predicate<Product> predicate = null);
        List<Product> SelectAllAsync(Predicate<Product> predicate = null);
    }
}
