
using VCPortal.Services;
using VCPortalTestXUnitTest.Fixtures;
using Xunit;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using VCPortal.Core.Domain;
using System.Threading.Tasks;
using System;

namespace VCPortalTestXUnitTest.Test
{
    public class AccountServiceTest : IClassFixture<ServiceProviderFixture>
    {
        IAccountService accountService;
        public AccountServiceTest(ServiceProviderFixture fixture) {
            accountService = fixture.ServiceProvider.GetService<IAccountService>();
        }

        [Fact]
        public async Task CangetSchemeTest() {
            IEnumerable<Scheme> schemes = await accountService.GetSchemes();
        }

        [Fact]
        public async Task CangetContractTest()
        {
            IEnumerable<Contract> contracts = await accountService.GetContracts();
        }

        [Fact]
        public async Task CangetMembershipTest()
        {
            IEnumerable<Membership> contracts = await accountService.GetMemberships();
        }

        [Fact]
        public async Task CanAddSchemeTest()
        {
            Scheme scheme = new Scheme() {
                SchemeName = "Test Scheme",
                ContractNo = "0001",
                CreatedBy = "Unit Test User",
                CreatedDate = DateTime.Now,
                FilePath = "C:\\testpath",
                IsActive = false
            };
            await accountService.AddScheme(scheme, "C:\\", null);

            Assert.True(scheme.Id > 0);
        }

        [Fact]
        public async Task CanAddContractTest()
        {
            Contract contract = new Contract() {
                CardType = "test card type",
                ContractNo =1,
                Scheme = "test scheme",
                CreatedBy = "Unit Test User",
                CreatedDate = DateTime.Now,
                FilePath = "C:\\testpath",
                IsActive = false,
            };
            await accountService.AddContract(contract,"C:\\", null);

            Assert.True(contract.Id > 0);
        }

        [Fact]
        public async Task CanAddMembershipTest()
        {
            Membership membership = new Membership()
            {
                ContractNo = 1,
                Scheme = "test scheme",
                CreatedBy = "Unit Test User",
                CreatedDate = DateTime.Now,
                FilePath = "C:\\testpath",
                IsActive = false,
                MembershipNo = 1
            };

             //await accountService.AddMembership(new List<Ifrom);
            Assert.True(membership.Id > 0);
        }

    }
}
