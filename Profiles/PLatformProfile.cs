using AutoMapper;
using PlatformService.Dtos;
using PlatformService.Models;

namespace PlatformService.Profiles
{
    public class PLatformProfile : Profile
    {
        public PLatformProfile()
        {
            CreateMap<Platform, PlatformReadDto>(); 
            CreateMap<PlatformCreateDto, Platform>();
        }
    }
}