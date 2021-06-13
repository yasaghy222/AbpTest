using ABPTest.Authors;
using ABPTest.Books;
using AutoMapper;

namespace ABPTest
{
    public class ABPTestApplicationAutoMapperProfile : Profile
    {
        public ABPTestApplicationAutoMapperProfile()
        {
            #region book mappers
            CreateMap<Book, BookDto>();
            CreateMap<AddEditBookDto, BookDto>();
            #endregion book mappers


            #region author mappers
            CreateMap<Author, AuthorDto>()
                .ForMember(des => des.FullName, src => src.MapFrom(i => $"{i.Name} {i.Family}"));
            CreateMap<AddEditAuthorDto, Author>();
            #endregion author mappers
        }
    }
}
