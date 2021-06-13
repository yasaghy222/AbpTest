using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace ABPTest
{
    [Dependency(ReplaceServices = true)]
    public class ABPTestBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "ABPTest";
    }
}
