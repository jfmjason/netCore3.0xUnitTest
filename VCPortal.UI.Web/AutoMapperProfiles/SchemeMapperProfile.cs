
using AutoMapper;
using VCPortal.Core.Domain;
using VCPortal.UI.Web.DTO;

namespace VCPortal.UI.Web.AutoMapperProfiles
{
    public class SchemeMapperProfile : Profile
    {
        public SchemeMapperProfile() {
            CreateMap<Scheme, AddSchemeDTO>()
                   .ReverseMap();

            CreateMap<Scheme, SchemeDetailDTO>()
                    .ReverseMap();

        }
    }
}
