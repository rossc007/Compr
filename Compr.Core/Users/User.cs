using Abp.Authorization.Users;
using Compr.MultiTenancy;

namespace Compr.Users
{
    public class User : AbpUser<Tenant, User>
    {

    }
}