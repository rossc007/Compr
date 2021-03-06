﻿using System.Reflection;
using Abp.Modules;
using Abp.Zero;

namespace Compr
{
    [DependsOn(typeof(AbpZeroCoreModule))]
    public class ComprCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Remove the following line to disable multi-tenancy.
            Configuration.MultiTenancy.IsEnabled = true;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
