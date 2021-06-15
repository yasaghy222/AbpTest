using System;
using System.Collections.Generic;
using System.Text;
using ABPTest.Localization;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace ABPTest
{
    /* Inherit your application services from this class.
     */
    public abstract class ABPTestAppService : ApplicationService
    {

        protected ABPTestAppService()
        {
            LocalizationResource = typeof(ABPTestResource);
        }
    }
}
