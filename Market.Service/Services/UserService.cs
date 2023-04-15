using Market.Service.DTOs;
using Market.Service.Interfaces;

namespace Market.Service.Services
{
    public class UserService : IUserService
    {
        public ValueTask<UserDto> AddAsync(UserCreationDto dto)
        {
            throw new NotImplementedException();
        }

        public ValueTask<bool> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<List<UserDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<UserDto> GetAsync(long id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<UserDto> UpdateAsync(long id, UserCreationDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
