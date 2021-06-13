using System.Threading.Tasks;

namespace ABPTest.Data
{
    public interface IABPTestDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
