using VCPortal.Core.Interface;
using VCPortalTestXUnitTest.Fixtures;
using Xunit;
using Microsoft.Extensions.DependencyInjection;
using VCPortal.Infra.Data.Impl;
using VCPortal.Services;

namespace VCPortalTestXUnitTest.Test
{
    public class ServiceProviderTest: IClassFixture<ServiceProviderFixture>
    {
        ServiceProviderFixture serviceProviderFixture;

        public ServiceProviderTest(ServiceProviderFixture fixture) {

            serviceProviderFixture = fixture;
            
        }

        [Fact]
        public void UnitOfWorkSanitTest()
        {
            IUnitOfWork uow = serviceProviderFixture.ServiceProvider.GetService<IUnitOfWork>();

            Assert.IsAssignableFrom<UnitOfWork>(uow);
        }

        [Fact]
        public void AccountServiceSanitTest()
        {
            IAccountService accountService = serviceProviderFixture.ServiceProvider.GetService<IAccountService>();
            Assert.IsAssignableFrom<AccountService>(accountService);
        }

    }
}
