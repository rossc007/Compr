using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;

namespace Compr
{
    [DependsOn(typeof(ComprCoreModule), typeof(AbpAutoMapperModule))]
    public class ComprApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
