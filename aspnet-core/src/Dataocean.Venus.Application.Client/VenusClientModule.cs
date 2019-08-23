using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Dataocean.Venus
{
    public class VenusClientModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(VenusClientModule).GetAssembly());
        }
    }
}

