using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using GraceTools.Configuration;

namespace GraceTools.Web.Host.Startup
{
    [DependsOn(
       typeof(GraceToolsWebCoreModule))]
    public class GraceToolsWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public GraceToolsWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(GraceToolsWebHostModule).GetAssembly());
        }
    }
}
