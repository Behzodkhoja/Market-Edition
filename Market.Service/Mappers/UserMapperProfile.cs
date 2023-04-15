using AutoMapper;
using Market.Domain.Entities;
using Market.Service.DTOs;

namespace Market.Service.Mappers
{
    public class UserMapperProfile : Profile
    {
        public UserMapperProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<UserCreationDto, User>().ReverseMap();
            CreateMap<UserUpdateDto, User>().ReverseMap();
        }
    }
}
