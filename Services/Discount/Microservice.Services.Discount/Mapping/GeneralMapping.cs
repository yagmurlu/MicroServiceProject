using AutoMapper;
using Microservice.Services.Discount.Dtos;
using Microservice.Services.Discount.Models;

namespace Microservice.Services.Discount.Mapping
{
    public class GeneralMapping:Profile
    {
        public GeneralMapping()
        {
            CreateMap<DiscountCoupons,ResultDiscountDto>().ReverseMap();
            CreateMap<DiscountCoupons, CreateDiscountDto>().ReverseMap();
            CreateMap<DiscountCoupons, UpdateDiscountDto>().ReverseMap();
        }
    }
}
