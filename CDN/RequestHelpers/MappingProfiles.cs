using AutoMapper;
using CDN.DTOs;
using CDN.Entities;

namespace CDN.RequestHelpers;

public class MappingProfiles: Profile
{
    public MappingProfiles()
    {
        CreateMap<User, UserDto>().ReverseMap();
       
        CreateMap<User, UserUpdateDto>().ReverseMap();
    }
   
}