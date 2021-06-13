using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace ABPTest.Books
{
    public class BookAppService :
        CrudAppService<Book, 
                       BookDto,
                       Guid,
                       PagedAndSortedResultRequestDto,
                       AddEditBookDto>,
        IBookAppService  
    {

        public BookAppService(IRepository<Book, Guid> repo)
            : base(repo)
        {

        }
    }
}
