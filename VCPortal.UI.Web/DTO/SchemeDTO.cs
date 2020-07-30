using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace VCPortal.UI.Web.DTO
{
    public class SchemeDetailDTO
    {
        public int Id { get; set; }
        public string SchemeName { get; set; }
        public string FilePath { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool IsActive { get; set; }
    }

    public class AddSchemeDTO
    {
        [Display(Name ="Scheme name :")]
        [Required]
        public string SchemeName { get; set; }
        [Display(Name = "Upload file :")]
        [Required]
        public IFormFile SchemeFormFile { get; set; }
    }
}
