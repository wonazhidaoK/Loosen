using Loosen.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Loosen
{
    [DependsOn(
        typeof(LoosenEntityFrameworkCoreTestModule)
        )]
    public class LoosenDomainTestModule : AbpModule
    {

    }
}