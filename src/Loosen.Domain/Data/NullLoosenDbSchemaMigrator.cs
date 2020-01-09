using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Loosen.Data
{
    /* This is used if database provider does't define
     * ILoosenDbSchemaMigrator implementation.
     */
    public class NullLoosenDbSchemaMigrator : ILoosenDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}