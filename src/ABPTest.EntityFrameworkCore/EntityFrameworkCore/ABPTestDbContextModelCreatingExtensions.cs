using ABPTest.Authors;
using ABPTest.Books;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace ABPTest.EntityFrameworkCore
{
    public static class ABPTestDbContextModelCreatingExtensions
    {
        public static void ConfigureABPTest(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            builder.Entity<Book>(b =>
            {
                b.ToTable(ABPTestConsts.DbTablePrefix + "Book", ABPTestConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Title).IsRequired().HasMaxLength(128);
            });

            builder.Entity<Author>(b =>
            {
                b.ToTable(ABPTestConsts.DbTablePrefix + "Author", ABPTestConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Name).IsRequired().HasMaxLength(128);
            });
        }
    }
}