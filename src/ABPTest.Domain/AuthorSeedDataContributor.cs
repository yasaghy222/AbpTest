using ABPTest.Authors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace ABPTest
{
    public class AuthorSeedDataContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Author, Guid> _authorRepo;

        public AuthorSeedDataContributor(IRepository<Author, Guid> authorRepo)
        {
            _authorRepo = authorRepo;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _authorRepo.GetCountAsync() <= 0)
            {
                await _authorRepo.InsertAsync(
                    new Author
                    {
                        Name = "George",
                        Family = "Orwell",
                        BirthDate = new DateTime(1903, 6, 25)
                    },
                    autoSave: true
                );

                await _authorRepo.InsertAsync(
                    new Author
                    {
                        Name = "William",
                        Family = "Faulkner",
                        BirthDate = new DateTime(1962, 7, 6)
                    },
                    autoSave: true
                );
            }
        }
    }
}
