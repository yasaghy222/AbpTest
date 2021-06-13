using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace ABPTest.Authors
{
    public interface IAuthorAppService :
                     ICrudAppService<AuthorDto,
                                     Guid,
                                     PagedAndSortedResultRequestDto,
                                     AddEditAuthorDto>
    {
      
    }
}
