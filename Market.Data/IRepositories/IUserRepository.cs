using Market.Domain.Entities;

namespace Market.Data.IRepositories
{
    public interface IUserRepository
    {
        Task<User> InsertAsync(User user);
        Task<User> UpdateAsync(User user);
        Task<bool> DeleteAsync(User user);
        Task<User> GetAsync(long id);
        Task<IEnumerable<User>> GetAllAsync();
    }
}
