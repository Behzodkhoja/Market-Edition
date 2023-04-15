using Market.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Service.Interfaces
{
    public interface IUserService
    {
        ValueTask<UserDto> AddAsync(UserCreationDto dto);
        ValueTask<UserDto> UpdateAsync(long id, UserCreationDto dto);
        ValueTask<bool> DeleteAsync(long id);

    }
}
