using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ABPTest.Data;
using Volo.Abp.DependencyInjection;

namespace ABPTest.EntityFrameworkCore
{
    public class EntityFrameworkCoreABPTestDbSchemaMigrator
        : IABPTestDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreABPTestDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the ABPTestMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<ABPTestMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}