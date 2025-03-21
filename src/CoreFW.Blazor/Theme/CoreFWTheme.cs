using System;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Components.Web.Theming;
using Volo.Abp.AspNetCore.Components.Web.Theming.Toolbars;
using Volo.Abp.DependencyInjection;
using Volo.Abp.AspNetCore.Components.Web.Theming.Theming;

namespace CoreFW.Blazor.Theme
{
    // Constants cho CoreFW Theme bundles
    public static class CoreFWThemeBundles
    {
        public static class Styles
        {
            public const string Global = "CoreFW.Styles";
        }

        public static class Scripts
        {
            public const string Global = "CoreFW.Scripts";
        }
    }

    [ThemeName("CoreFW")]
    public class CoreFWTheme : ITheme, ISingletonDependency
    {
        public string Name => "CoreFW";

        public Task<string> GetMainLayoutNameAsync()
        {
            return Task.FromResult("MainLayout");
        }

        public Type GetLayout(string? name = null, bool fallbackToDefault = true)
        {
            return typeof(CoreFW.Blazor.Theme.Components.Layout.MainLayout);
        }

        public Task<ToolbarItem[]> GetToolbarItemsAsync()
        {
            return Task.FromResult(Array.Empty<ToolbarItem>());
        }
    }
} 