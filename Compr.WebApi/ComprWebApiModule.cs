using System.Reflection;
using Abp.Application.Services;
using Abp.Modules;
using Abp.WebApi;
using Abp.WebApi.Controllers.Dynamic.Builders;

namespace Compr
{
    [DependsOn(typeof(AbpWebApiModule), typeof(ComprApplicationModule))]
    public class ComprWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(ComprApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
