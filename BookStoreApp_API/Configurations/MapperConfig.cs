using AutoMapper;
using BookStoreApp_API.Data;
using BookStoreApp_API.Models.Author;
using BookStoreApp_API.Models.Book;

namespace BookStoreApp_API.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            // Author Mappings
            CreateMap<AuthorCreateDTO, Author>().ReverseMap();
            CreateMap<AuthorUpdateDTO, Author>().ReverseMap();

            // Book Mappings
            CreateMap<BookCreateDTO, Book>().ReverseMap();
            CreateMap<BookUpdateDTO, Book>().ReverseMap();

            CreateMap<Book, BookReadOnlyDTO>()
                .ForMember(q => q.AuthorName, d => d.MapFrom(map => $"{map.Author.FirstName} {map.Author.LastName}"))
                .ReverseMap();

            CreateMap<Book, BookDetailsDTO>()
                .ForMember(q => q.AuthorName, d => d.MapFrom(map => $"{map.Author.FirstName} {map.Author.LastName}"))
                .ReverseMap();
        }
    }
}
