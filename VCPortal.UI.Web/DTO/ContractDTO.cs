using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace VCPortal.UI.Web.DTO
{
    public class ContractDetailDTO
    {
        public int Id { get; set; }
        public int ContractNo { get; set; }
        public string CardType { get; set; }
        public string Scheme { get; set; }
        public string Network { get; set; }
        public string PolicyNo { get; set; }
        public string FilePath { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool IsActive { get; set; }
    }

    public class AddContractDTO
    {
        [Required]
        [Display(Name = "Contract No :")]
        public int ContractNo { get; set; }
        [Required]
        [Display(Name = "Card Type :")]
        public string CardType { get; set; }
        [Required]
        [Display(Name = "Scheme :")]
        public string Scheme { get; set; }
        [Required]
        [Display(Name = "Network :")]
        public string Network { get; set; }
        [Required]
        [Display(Name = "Policy No :")]
        public string PolicyNo { get; set; }

        [Required]
        [Display(Name = "Upload file :")]
        public IFormFile ContractFormFile { get; set; }
    }
}
