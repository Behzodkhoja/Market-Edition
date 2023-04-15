using Market.Domain.Entities;

namespace Market.Data.IRepositories
{
    public interface IUserRepository
    {
        Task<User> InsertAsync(User entity);
        Task<User> UpdateAsync(long id, User entity);
        Task<bool> DeleteAsync(Predicate<User> predicate);
        User SelectAsync(Predicate<User> predicate = null);
        List<User> SelectAllAsync(Predicate<User> predicate = null);
    }
}
