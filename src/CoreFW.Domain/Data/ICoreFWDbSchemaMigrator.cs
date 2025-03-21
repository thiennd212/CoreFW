using System.Threading.Tasks;

namespace CoreFW.Data;

public interface ICoreFWDbSchemaMigrator
{
    Task MigrateAsync();
}
