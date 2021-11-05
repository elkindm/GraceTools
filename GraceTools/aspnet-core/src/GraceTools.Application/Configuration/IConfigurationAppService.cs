using System.Threading.Tasks;
using GraceTools.Configuration.Dto;

namespace GraceTools.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
