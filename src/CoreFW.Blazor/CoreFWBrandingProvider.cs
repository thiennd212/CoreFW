using Microsoft.Extensions.Localization;
using CoreFW.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace CoreFW.Blazor;

[Dependency(ReplaceServices = true)]
public class CoreFWBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<CoreFWResource> _localizer;

    public CoreFWBrandingProvider(IStringLocalizer<CoreFWResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
