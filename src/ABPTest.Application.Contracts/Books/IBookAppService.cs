using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace ABPTest.Books
{
    public interface IBookAppService :
        ICrudAppService<BookDto,
                        Guid,
                        PagedAndSortedResultRequestDto,
                        AddEditBookDto>
    {
    }
}
