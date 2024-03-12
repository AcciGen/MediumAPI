using AutoMapper;
using MediatrCQRSpattern.Domain.DTOs;
using MediatrCQRSpattern.Domain.Entities;

namespace MediatrCQRSpattern.Application.Mappers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDTO>().ReverseMap();
        }
    }
}
