using Abp.Authorization.Roles;
using Compr.MultiTenancy;
using Compr.Users;

namespace Compr.Authorization.Roles
{
    public class Role : AbpRole<Tenant, User>
    {

    }
}