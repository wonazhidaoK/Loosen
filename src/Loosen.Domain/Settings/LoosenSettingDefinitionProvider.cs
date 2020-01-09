using Volo.Abp.Settings;

namespace Loosen.Settings
{
    public class LoosenSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(LoosenSettings.MySetting1));
        }
    }
}
