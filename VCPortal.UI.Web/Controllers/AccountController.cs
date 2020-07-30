using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;
using VCPortal.Core.Domain;
using VCPortal.Services;
using VCPortal.UI.Web.Common;
using VCPortal.UI.Web.DTO;

namespace VCPortal.UI.Web.Controllers
{
    public class AccountController : Controller
    {
        IMapper mapper;
        private readonly IAccountService accountService;
        private IConfiguration configuration;

        public AccountController(IMapper map, IAccountService service, IConfiguration conf) {
            accountService = service;
            mapper = map;
            configuration = conf;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<ActionResult> GetSchemes()
        {
            var entities = await accountService.GetSchemes();

            var map = mapper.Map<List<SchemeDetailDTO>>(entities);

            return Ok(map);
        }

        [HttpGet]
        public async Task<ActionResult> GetMemberships()
        {
            var entities = await accountService.GetMemberships();

            var map = mapper.Map<List<MembershipDetailDTO>>(entities);

            return Ok(map);
        }

        [HttpGet]
        public async Task<ActionResult> GetContracts()
        {
            var entities = await accountService.GetContracts();

            var map = mapper.Map<List<ContractDetailDTO>>(entities);

            return Ok(map);
        }

        [HttpPost]
        public async Task<ActionResult> AddScheme(AddSchemeDTO scheme)
        {
            var entity = mapper.Map<Scheme>(scheme);
            
            entity.CreatedBy = User.Identity.Name??"no user";
            entity.ContractNo = string.Empty;

            string dir = configuration.GetSection(ConfigurationConstants.UPLOAD_DIR_KEY)?.Value;
            
            await accountService.AddScheme(entity, dir, scheme.SchemeFormFile);

            return Ok(entity.Id);
        }


        [HttpPost]
        public async Task<ActionResult> AddContract(AddContractDTO contract)
        {
            var entity = mapper.Map<Contract>(contract);

            entity.CreatedBy = User.Identity.Name ?? "no user";
   
            string dir = configuration.GetSection(ConfigurationConstants.UPLOAD_DIR_KEY)?.Value;

            await accountService.AddContract(entity, dir, contract.ContractFormFile);

            return Ok(entity.Id);
        }

        [HttpPost]
        public async Task<ActionResult> AddMembership(AddMembershipDTO membership)
        {
            //var entity = mapper.Map<Contract>(contract);

            //entity.CreatedBy = User.Identity.Name ?? "no user";

            string dir = configuration.GetSection(ConfigurationConstants.UPLOAD_DIR_KEY)?.Value;

            await accountService.AddMembership( dir, membership.MembershipFormFiles);

            return Ok(0);
        }
    }
}
