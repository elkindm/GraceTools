using Abp.Authorization;
using GraceTools.Authorization.Roles;
using GraceTools.Authorization.Users;

namespace GraceTools.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
