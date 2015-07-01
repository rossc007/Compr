using Abp.Authorization;
using Compr.Authorization.Roles;
using Compr.MultiTenancy;
using Compr.Users;

namespace Compr.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
