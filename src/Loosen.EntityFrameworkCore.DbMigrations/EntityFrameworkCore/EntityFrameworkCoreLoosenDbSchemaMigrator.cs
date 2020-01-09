using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Loosen.Data;
using Volo.Abp.DependencyInjection;

namespace Loosen.EntityFrameworkCore
{
    [Dependency(ReplaceServices = true)]
    public class EntityFrameworkCoreLoosenDbSchemaMigrator 
        : ILoosenDbSchemaMigrator, ITransientDependency
    {
        private readonly LoosenMigrationsDbContext _dbContext;

        public EntityFrameworkCoreLoosenDbSchemaMigrator(LoosenMigrationsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task MigrateAsync()
        {
            await _dbContext.Database.MigrateAsync();
        }
    }
}