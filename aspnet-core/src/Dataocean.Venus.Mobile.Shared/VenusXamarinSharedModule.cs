using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Dataocean.Venus
{
    [DependsOn(typeof(VenusClientModule), typeof(AbpAutoMapperModule))]
    public class VenusXamarinSharedModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Localization.IsEnabled = false;
            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(VenusXamarinSharedModule).GetAssembly());
        }
    }
}
