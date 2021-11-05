using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using GraceTools.Configuration.Dto;

namespace GraceTools.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : GraceToolsAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
