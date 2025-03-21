using CoreFW.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace CoreFW.Permissions;

public class CoreFWPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(CoreFWPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(CoreFWPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<CoreFWResource>(name);
    }
}
