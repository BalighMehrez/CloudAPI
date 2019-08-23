using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Dataocean.Venus
{
    [DependsOn(typeof(VenusXamarinSharedModule))]
    public class VenusXamarinAndroidModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(VenusXamarinAndroidModule).GetAssembly());
        }
    }
}
