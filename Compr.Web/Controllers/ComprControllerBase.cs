using Abp.Web.Mvc.Controllers;

namespace Compr.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class ComprControllerBase : AbpController
    {
        protected ComprControllerBase()
        {
            LocalizationSourceName = ComprConsts.LocalizationSourceName;
        }
    }
}