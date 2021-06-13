using ABPTest.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ABPTest
{
    [DependsOn(
        typeof(ABPTestEntityFrameworkCoreTestModule)
        )]
    public class ABPTestDomainTestModule : AbpModule
    {

    }
}