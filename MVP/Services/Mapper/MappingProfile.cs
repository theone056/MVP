using AutoMapper;
using Data.Model;
using MVP.Models;

namespace MVP.Services.Mapper
{
    public class MappingProfile: Profile
    {
        public MappingProfile() {
            CreateMap<Product, ProductViewModel>();
        }
    }
}
