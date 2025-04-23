using AutoMapper;
using KHanERP.DTOs.CustomerDTO;
using KHanERP.Models;
namespace KHanERP.Profiles
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<Customer, CustomerGetDTO>()
                .ForMember(dest => dest.CreatedAT, opt => opt.MapFrom(src => src.CreatedAT.ToString("yyyy-MM-dd HH:mm:ss")));

            CreateMap<CustomerGetDTO, Customer>();
        }
    }   
}
