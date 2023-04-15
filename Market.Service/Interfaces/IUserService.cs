using Market.Service.DTOs;

namespace Market.Service.Interfaces
{
    public interface IUserService
    {
        ValueTask<UserDto> AddAsync(UserCreationDto dto);
        ValueTask<UserDto> UpdateAsync(long id, UserCreationDto dto);
        ValueTask<bool> DeleteAsync(long id);
        ValueTask<UserDto> GetAsync(long id);
        ValueTask<List<UserDto>> GetAllAsync();

    }
}
