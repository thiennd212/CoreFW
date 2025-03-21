using CoreFW.Localization;
using Volo.Abp.AspNetCore.Components;

namespace CoreFW.Blazor;

public abstract class CoreFWComponentBase : AbpComponentBase
{
    protected CoreFWComponentBase()
    {
        LocalizationResource = typeof(CoreFWResource);
    }
}
