using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Loosen.EntityFrameworkCore
{
    [DependsOn(
        typeof(LoosenEntityFrameworkCoreModule)
        )]
    public class LoosenEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<LoosenMigrationsDbContext>();
        }
    }
}
