using ABPTest.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ABPTest.Permissions
{
    public class ABPTestPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(ABPTestPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(ABPTestPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<ABPTestResource>(name);
        }
    }
}
