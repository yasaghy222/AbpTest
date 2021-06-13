using Volo.Abp.Settings;

namespace ABPTest.Settings
{
    public class ABPTestSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(ABPTestSettings.MySetting1));
        }
    }
}
