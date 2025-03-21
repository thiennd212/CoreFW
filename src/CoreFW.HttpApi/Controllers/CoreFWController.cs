using CoreFW.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace CoreFW.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class CoreFWController : AbpControllerBase
{
    protected CoreFWController()
    {
        LocalizationResource = typeof(CoreFWResource);
    }
}
