using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrideWeddingAPI.Models
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ClientRegistration, Client>()
                .ForMember(u => u.UserName, opt => opt.MapFrom(x => x.Email));
            
            
            CreateMap<VendorRegistration, Vendor>()
                .ForMember(u => u.UserName, opt => opt.MapFrom(x => x.Email));
        }
    }
}
