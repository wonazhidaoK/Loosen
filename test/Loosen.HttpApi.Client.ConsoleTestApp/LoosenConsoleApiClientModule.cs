using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Loosen.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(LoosenHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class LoosenConsoleApiClientModule : AbpModule
    {
        
    }
}
