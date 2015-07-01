using Abp.Web.Mvc.Views;

namespace Compr.Web.Views
{
    public abstract class ComprWebViewPageBase : ComprWebViewPageBase<dynamic>
    {

    }

    public abstract class ComprWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected ComprWebViewPageBase()
        {
            LocalizationSourceName = ComprConsts.LocalizationSourceName;
        }
    }
}