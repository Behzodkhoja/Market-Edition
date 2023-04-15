using Market.Data.IRepositories;
using Market.Data.Repositories;
using Market.Domain.Entities;
using Market.Service.DTOs;
using Market.Service.Interfaces;

namespace Market.Service.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository = new UserRepository();
        public async ValueTask<UserDto> AddAsync(UserCreationDto dto)
        {
            var user = new User
            {
                FullName = dto.FullName,
                Email = dto.Email,
                Password = dto.Password,
                CreatedAt = DateTime.UtcNow
            };
            await userRepository.InsertAsync(user);

            return new UserDto
            {
                Id = user.Id,
                FullName = user.FullName,
                Email = user.Email,
                Password = user.Password
            };
        }

        public async ValueTask<bool> DeleteAsync(long id)
        {
            var user = await userRepository.GetAsync(id);

            if (user == null)
                return false;

            await userRepository.DeleteAsync(user);
            return true;
        }

        public async ValueTask<IEnumerable<UserDto>> GetAllAsync()
        {
            var users = await userRepository.GetAllAsync();

            return users.Select(use => new UserDto
            {
                Email = use.Email,
                Password = use.Password,
                FullName=use.FullName,
                Id = use.Id
            });
        }

        public async ValueTask<UserDto> GetByIdAsync(long id)
        {
            var user = await userRepository.GetAsync(id);

            return new UserDto
            {
                Id = user.Id,
                FullName = user.FullName,
                Email = user.Email,
                Password = user.Password
            };
        }

        public async ValueTask<UserDto> UpdateAsync(long id, UserUpdateDto dto)
        {
            var user = await userRepository.GetAsync(id);
            if (user == null)
                throw new Exception("User not found...");

            user.FullName = dto.FullName;
            user.Email = dto.Email;
            user.Password = dto.Password;
            user.UpdatedAt = DateTime.UtcNow; 
            await userRepository.UpdateAsync(user);

            return new UserDto 
            { 
                Id = user.Id, 
                FullName = user.FullName,
                Email =  user.Email, 
                Password = user.Password 
            };
        }
    }
}
