using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ABPTest.Data
{
    /* This is used if database provider does't define
     * IABPTestDbSchemaMigrator implementation.
     */
    public class NullABPTestDbSchemaMigrator : IABPTestDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}