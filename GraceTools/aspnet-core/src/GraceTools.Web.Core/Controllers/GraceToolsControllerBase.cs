using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace GraceTools.Controllers
{
    public abstract class GraceToolsControllerBase: AbpController
    {
        protected GraceToolsControllerBase()
        {
            LocalizationSourceName = GraceToolsConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
