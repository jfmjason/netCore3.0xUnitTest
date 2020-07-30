
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using VCPortal.Core.Domain;
using VCPortal.Core.Interface;

namespace VCPortal.Services
{
    public class AccountService : IAccountService
    {
        IUnitOfWork _uow;

        IRepository<Scheme> _schemeRepository;
        IRepository<Membership> _membershipRepository;
        IRepository<Contract> _contractRepository;

        public AccountService(IUnitOfWork uow) {
            _uow = uow;
            _schemeRepository = _uow.Repository<Scheme>();
            _membershipRepository = _uow.Repository<Membership>();
            _contractRepository = _uow.Repository<Contract>();
        }

        public Task AddContract(Contract contract, string dir, IFormFile formFile)
        {
            contract.FilePath = saveFileAsync(dir, formFile).GetAwaiter().GetResult();
            contract.CreatedDate = DateTime.Now;
            contract.IsActive = true;

            _contractRepository.Add(contract);
            _uow.Commit();

            return Task.FromResult(0);
        }

        public Task AddMembership(string dir, List<IFormFile> formFiles)
        {
            //_membershipRepository.Add(membership);
            _uow.Commit();
            return Task.FromResult(0);
        }

        public Task AddScheme(Scheme scheme, string dir, IFormFile formFile)
        {

            scheme.FilePath = saveFileAsync(dir, formFile).GetAwaiter().GetResult();
            scheme.CreatedDate = DateTime.Now;
            scheme.IsActive = true;

            _schemeRepository.Add(scheme);
            _uow.Commit();

            return Task.FromResult(0);
        }

        public Task<IEnumerable<Contract>> GetContracts()
        {
            IEnumerable<Contract> contracts = _contractRepository.GetAll();

            return Task.FromResult(contracts);
        }

        public Task<IEnumerable<Membership>> GetMemberships()
        {
            IEnumerable<Membership> memberships = _membershipRepository.GetAll();

            return Task.FromResult(memberships);
        }

        public Task<IEnumerable<Scheme>> GetSchemes()
        {
            IEnumerable<Scheme> schemes = _schemeRepository.GetAll();

            return Task.FromResult(schemes);
        }



        private async Task<string> saveFileAsync(string dir, IFormFile formFile)
        {
            string filepath = string.Empty;

            if (!Directory.Exists(dir))
            {
                DirectoryInfo di = Directory.CreateDirectory(dir);
            }

            var filePath = Path.Combine(dir, $"{Guid.NewGuid()}.{Path.GetExtension(formFile.FileName)}");

            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
               await formFile.CopyToAsync(fileStream);

            }

            return filePath;
        }
    }
}
