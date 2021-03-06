using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Entities.Identity;

namespace API.Helpers
{
    public class MappingProfiles :Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product,ProductToReturn>();
            // .ForMember(p => p.UnitName, o => o.MapFrom(s => s.Unit.UnitName));
            // CreateMap<Core.Entities.Identity.Address, AddressDto>().ReverseMap();
            // CreateMap<CustomerBasketDto,CustomerBasket>();
            // CreateMap<BasketItemDto,BasketItem>();

            // CreateMap<AddressDto, Core.Entities.OrderAggredate.Address>(); 

            // CreateMap<Order, OrderToReturnDto>()
            // .ForMember(d => d.DeliveryMethod , o => o.MapFrom(s => s.DeliveryMethod.ShortName))
            // .ForMember(d => d.ShippingPrice , o => o.MapFrom(s => s.DeliveryMethod.Price));

            // CreateMap<OrderItem, OrderItemDto>()
            // .ForMember(d => d.ProductId , o => o.MapFrom(s => s.ItemOrdered.ProductItemId))
            // .ForMember(d => d.ProductName , o => o.MapFrom(s => s.ItemOrdered.ProductName))
            // .ForMember(d => d.PictureUrl , o => o.MapFrom(s => s.ItemOrdered.PictureUrl));
            
        }
    }
}