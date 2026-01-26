using MyAbpProject.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace MyAbpProject.Permissions;

public class MyAbpProjectPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(MyAbpProjectPermissions.GroupName);

        //Define your own permissions here. Example:
        //myGroup.AddPermission(MyAbpProjectPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<MyAbpProjectResource>(name);
    }
}
