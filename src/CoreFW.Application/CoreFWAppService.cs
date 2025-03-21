using System;
using System.Collections.Generic;
using System.Text;
using CoreFW.Localization;
using Volo.Abp.Application.Services;

namespace CoreFW;

/* Inherit your application services from this class.
 */
public abstract class CoreFWAppService : ApplicationService
{
    protected CoreFWAppService()
    {
        LocalizationResource = typeof(CoreFWResource);
    }
}
