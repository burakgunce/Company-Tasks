using AutoMapper;
using OrderAppWebApi.Models.DTOs;
using OrderAppWebApi.Models.Entities;

namespace OrderAppWebApi.Context
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductDto>();
            CreateMap<ProductDto, Product>();
            CreateMap<Order, CreateOrderRequest>();
            CreateMap<CreateOrderRequest, Order>();
            CreateMap<ProductDetailDto, OrderDetail>();
            CreateMap<OrderDetail, ProductDetailDto>();
        }
    }
}
