using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using VCPortal.Core.Interface;
using VCPortal.Infra.Data;
using VCPortal.Infra.Data.Impl;
using VCPortal.Services;
using Xunit;

namespace VCPortalTestXUnitTest.Fixtures
{
    public class ServiceProviderFixture:  IDisposable
    {
        DatabaseFixtures dbFixture;
        public ServiceProvider ServiceProvider { get; private set; }
        
        public ServiceProviderFixture() {

            dbFixture = new DatabaseFixtures();

            var services = new ServiceCollection();


            services.AddDbContext<MemberOSContext>(options =>
               options.UseLazyLoadingProxies()
               .UseSqlServer(dbFixture.Db.ConnectionString)
               );
            services.AddScoped(typeof(IAccountService), typeof(AccountService));
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));
           
            ServiceProvider = services.BuildServiceProvider();

        }

        public void Dispose()
        {
            ServiceProvider.Dispose();
        }
    }
}
