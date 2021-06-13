using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace ABPTest.EntityFrameworkCore
{
    [DependsOn(
        typeof(ABPTestEntityFrameworkCoreModule)
        )]
    public class ABPTestEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<ABPTestMigrationsDbContext>();
        }
    }
}
