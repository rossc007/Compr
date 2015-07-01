using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Runtime.Session;
using Compr.MultiTenancy;
using Compr.Users;

namespace Compr
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class ComprAppServiceBase : ApplicationService
    {
        public TenantManager TenantManager { get; set; }

        public UserManager UserManager { get; set; }

        protected ComprAppServiceBase()
        {
            LocalizationSourceName = ComprConsts.LocalizationSourceName;
        }

        protected virtual Task<User> GetCurrentUserAsync()
        {
            var user = UserManager.FindByIdAsync(AbpSession.GetUserId());
            if (user == null)
            {
                throw new ApplicationException("There is no current user!");
            }

            return user;
        }

        protected virtual Task<Tenant> GetCurrentTenantAsync()
        {
            return TenantManager.GetByIdAsync(AbpSession.GetTenantId());
        }
    }
}