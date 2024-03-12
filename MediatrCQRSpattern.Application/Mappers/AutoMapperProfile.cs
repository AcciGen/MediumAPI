using AutoMapper;
using MediatrCQRSpattern.Application.UseCases.MediumUser.Commands;
using MediatrCQRSpattern.Domain.DTOs;
using MediatrCQRSpattern.Domain.Entities;

namespace MediatrCQRSpattern.Application.Mappers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, CreateUserCommand>().ReverseMap();
        }
    }
}
