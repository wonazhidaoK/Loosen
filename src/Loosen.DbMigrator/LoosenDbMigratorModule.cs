using Loosen.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Loosen.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(LoosenEntityFrameworkCoreDbMigrationsModule),
        typeof(LoosenApplicationContractsModule)
        )]
    public class LoosenDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
