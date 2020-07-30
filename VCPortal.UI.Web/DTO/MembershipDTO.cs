using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VCPortal.UI.Web.DTO
{
    public class MembershipDetailDTO
    {
        public int Id { get; set; }
        public int MembershipNo { get; set; }
        public int ContractNo { get; set; }
        public string Scheme { get; set; }
        public string FilePath { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool IsActive { get; set; }
    }
    public class AddMembershipDTO
    {
        [Required]
        [Display(Name = "Upload files :")]
        public List<IFormFile> MembershipFormFiles { get; set; }
    }
}
