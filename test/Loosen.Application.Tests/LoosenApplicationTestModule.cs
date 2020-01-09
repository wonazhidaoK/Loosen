using Volo.Abp.Modularity;

namespace Loosen
{
    [DependsOn(
        typeof(LoosenApplicationModule),
        typeof(LoosenDomainTestModule)
        )]
    public class LoosenApplicationTestModule : AbpModule
    {

    }
}