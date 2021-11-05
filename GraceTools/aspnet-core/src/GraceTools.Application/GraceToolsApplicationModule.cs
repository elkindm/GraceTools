using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using GraceTools.Authorization;

namespace GraceTools
{
    [DependsOn(
        typeof(GraceToolsCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class GraceToolsApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<GraceToolsAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(GraceToolsApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
