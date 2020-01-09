using System.Threading.Tasks;

namespace Loosen.Data
{
    public interface ILoosenDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
