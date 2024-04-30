using AutoMapper;
using BookStoreApp_API.Data;
using BookStoreApp_API.Models.Author;

namespace BookStoreApp_API.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<AuthorCreateDTO, Author>().ReverseMap();
            CreateMap<AuthorUpdateDTO, Author>().ReverseMap();
            CreateMap<AuthorReadOnlyDTO, Author>().ReverseMap();
        }
    }
}
