using Market.Service.DTOs;

namespace Market.Service.Interfaces
{
    public interface IUserService
    {
        ValueTask<UserDto> GetByIdAsync(long id);
        ValueTask<IEnumerable<UserDto>> GetAllAsync();
        ValueTask<UserDto> AddAsync(UserCreationDto dto);
        ValueTask<UserDto> UpdateAsync(long id, UserUpdateDto dto);
        ValueTask<bool> DeleteAsync(long id);

    }
}
