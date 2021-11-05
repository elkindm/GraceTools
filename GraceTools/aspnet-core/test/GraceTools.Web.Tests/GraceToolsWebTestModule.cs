using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using GraceTools.EntityFrameworkCore;
using GraceTools.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace GraceTools.Web.Tests
{
    [DependsOn(
        typeof(GraceToolsWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class GraceToolsWebTestModule : AbpModule
    {
        public GraceToolsWebTestModule(GraceToolsEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(GraceToolsWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(GraceToolsWebMvcModule).Assembly);
        }
    }
}