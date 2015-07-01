using Abp.MultiTenancy;
using Compr.Users;

namespace Compr.MultiTenancy
{
    public class Tenant : AbpTenant<Tenant, User>
    {

    }
}