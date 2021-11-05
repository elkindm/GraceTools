using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using GraceTools.Authorization.Roles;
using GraceTools.Authorization.Users;
using GraceTools.MultiTenancy;

namespace GraceTools.EntityFrameworkCore
{
    public class GraceToolsDbContext : AbpZeroDbContext<Tenant, Role, User, GraceToolsDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public GraceToolsDbContext(DbContextOptions<GraceToolsDbContext> options)
            : base(options)
        {
        }
    }
}
