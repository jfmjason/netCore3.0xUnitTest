using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using VCPortal.Core.Domain;

namespace VCPortal.Services
{
    public interface IAccountService
    {
        Task<IEnumerable<Scheme>> GetSchemes();
        Task<IEnumerable<Contract>> GetContracts();
        Task<IEnumerable<Membership>> GetMemberships();

        Task AddScheme(Scheme scheme, string dir, IFormFile formFile);
        Task AddContract(Contract contract, string dir, IFormFile formFile);
        Task AddMembership(string dir, List<IFormFile> formFiles);
    }
}
