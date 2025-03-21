using CoreFW.Localization;
using Microsoft.AspNetCore.Components;
using System.Linq;
using Volo.Abp.AspNetCore.Components;

namespace CoreFW.Blazor;

public abstract class CoreFWComponentBase : AbpComponentBase
{
    [Inject]
    protected NavigationManager NavigationManager { get; set; } = default!;
    
    protected CoreFWComponentBase()
    {
        LocalizationResource = typeof(CoreFWResource);
    }
    
    protected string GetCssClass(params string[] classNames)
    {
        return string.Join(" ", classNames.Where(c => !string.IsNullOrWhiteSpace(c)));
    }
}
