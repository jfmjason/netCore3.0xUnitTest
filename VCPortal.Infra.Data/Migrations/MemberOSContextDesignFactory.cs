
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;
using VCPortal.Core.Domain.Constants;

namespace VCPortal.Infra.Data.Migrations
{
    internal class MemberOSContextDesignFactory : IDesignTimeDbContextFactory<MemberOSContext>
    {
        //for migration
        public MemberOSContext CreateDbContext(string[] args)
        {

            IConfigurationRoot configuration = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json", true, true)
               .Build();

            var constring = configuration.GetConnectionString("DefaultConnection");

            var builder = new DbContextOptionsBuilder<MemberOSContext>();


            builder.UseSqlServer(constring
                , x => x.MigrationsHistoryTable(MigrationConstants.MIGRATIONHISTORYTABLENAME));

            return new MemberOSContext(builder.Options);
        }
    }
}
