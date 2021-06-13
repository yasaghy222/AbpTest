using Microsoft.EntityFrameworkCore;
using ABPTest.Users;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.Identity;
using Volo.Abp.Users.EntityFrameworkCore;
using ABPTest.Books;
using ABPTest.Authors;

namespace ABPTest.EntityFrameworkCore
{
    /* This is your actual DbContext used on runtime.
     * It includes only your entities.
     * It does not include entities of the used modules, because each module has already
     * its own DbContext class. If you want to share some database tables with the used modules,
     * just create a structure like done for AppUser.
     *
     * Don't use this DbContext for database migrations since it does not contain tables of the
     * used modules (as explained above). See ABPTestMigrationsDbContext for migrations.
     */
    [ConnectionStringName("Default")]
    public class ABPTestDbContext : AbpDbContext<ABPTestDbContext>
    {
        public DbSet<AppUser> Users { get; set; }

        #region Book Tables
        public DbSet<Book> Books { get; set; }
        #endregion


        #region Author Tables
        public DbSet<Author> Authors { get; set; }
        #endregion

        public ABPTestDbContext(DbContextOptions<ABPTestDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


            builder.Entity<AppUser>(b =>
            {
                b.ToTable(AbpIdentityDbProperties.DbTablePrefix + "Users"); //Sharing the same table "AbpUsers" with the IdentityUser
                
                b.ConfigureByConvention();
                b.ConfigureAbpUser();
            });


            builder.ConfigureABPTest();
        }
    }
}
