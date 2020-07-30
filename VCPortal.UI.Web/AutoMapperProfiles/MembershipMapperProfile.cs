using AutoMapper;
using VCPortal.Core.Domain;
using VCPortal.UI.Web.DTO;

namespace VCPortal.UI.Web.AutoMapperProfiles
{
    public class MembershipMapperProfile : Profile
    {
        public MembershipMapperProfile()
        {
            CreateMap<Membership, AddMembershipDTO>()
                   .ReverseMap();

            CreateMap<Membership, MembershipDetailDTO>()
             .ReverseMap();

        }
    }
}
