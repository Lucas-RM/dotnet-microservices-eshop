using AutoMapper;
using EshopMicroservices.ProductApi.Models;

namespace EshopMicroservices.ProductApi.DTOs.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Product, ProductDTO>()
            .ReverseMap();

        CreateMap<Category, CategoryDTO>()
            .ReverseMap();
    }
}
