using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using Compr.Authorization.Roles;
using Compr.Users;

namespace Compr.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, Role, User>
    {
        public TenantManager(IRepository<Tenant> tenantRepository)
            : base(tenantRepository)
        {

        }
    }
}