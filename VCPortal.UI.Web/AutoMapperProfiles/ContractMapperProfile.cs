
using AutoMapper;
using VCPortal.Core.Domain;
using VCPortal.UI.Web.DTO;

namespace VCPortal.UI.Web.AutoMapperProfiles
{
    public class ContractMapperProfile : Profile
    {
        public ContractMapperProfile()
        {
            CreateMap<Contract, AddContractDTO>()
                   .ReverseMap();

            CreateMap<Contract, ContractDetailDTO>()
             .ReverseMap();

        }
    }
}
