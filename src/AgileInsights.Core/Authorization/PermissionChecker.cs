using Abp.Authorization;
using AgileInsights.Authorization.Roles;
using AgileInsights.Authorization.Users;

namespace AgileInsights.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
