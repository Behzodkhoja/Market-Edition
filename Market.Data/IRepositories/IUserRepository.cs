using Market.Domain.Entities;

namespace Market.Data.IRepositories
{
    public interface IUserRepository
    {
        Task InsertAsync(User user);
        Task UpdateAsync(User user);
        Task<bool> DeleteAsync(User user);
        Task<User> GetAsync(long id);
        Task<IEnumerable<User>> GetAllAsync();
    }
}
