using Volo.Abp.Modularity;

namespace ABPTest
{
    [DependsOn(
        typeof(ABPTestApplicationModule),
        typeof(ABPTestDomainTestModule)
        )]
    public class ABPTestApplicationTestModule : AbpModule
    {

    }
}