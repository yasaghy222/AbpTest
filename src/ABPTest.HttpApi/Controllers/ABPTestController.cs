using ABPTest.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ABPTest.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class ABPTestController : AbpController
    {
        protected ABPTestController()
        {
            LocalizationResource = typeof(ABPTestResource);
        }
    }
}