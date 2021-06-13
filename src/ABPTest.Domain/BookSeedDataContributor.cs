using ABPTest.Books;
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
    public class BookSeedDataContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Book, Guid> _bookRepo;
        public BookSeedDataContributor(IRepository<Book, Guid> bookRepo) => _bookRepo = bookRepo;


        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _bookRepo.GetCountAsync() <= 0)
            {
                await _bookRepo.InsertAsync(
                    new Book
                    {
                        Title = "1984",
                        Type = BookType.Dystopia,
                        PublishDate = new DateTime(1949, 6, 8),
                        Price = 28400,
                        AuthorID = new Guid("8a87fa21-81f9-b194-1363-39fd13fb17e5")
                    },
                    autoSave: true
                );

                await _bookRepo.InsertAsync(
                    new Book
                    {
                        Title = "خشم و هیاهو",
                        EnTitle = "The Sound And Fury",
                        Type = BookType.Undefined,
                        PublishDate = new DateTime(1928, 6, 9),
                        Price = 80000,
                        AuthorID = new Guid("1ac0ca08-bb57-ce28-5a74-39fd13fb19b7")
                    },
                    autoSave: true
                );
            }
        }
    }
}
