using ABPTest.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace ABPTest.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(ABPTestEntityFrameworkCoreDbMigrationsModule),
        typeof(ABPTestApplicationContractsModule)
        )]
    public class ABPTestDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
