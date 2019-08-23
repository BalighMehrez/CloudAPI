using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Dataocean.Venus
{
    [DependsOn(typeof(VenusXamarinSharedModule))]
    public class VenusXamarinIosModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(VenusXamarinIosModule).GetAssembly());
        }
    }
}
