using System;

namespace VCPortal.Core.Domain
{
    public  class Scheme
    {
        public int Id { get; set; }
        public string SchemeName { get; set; }
        public string ContractNo { get; set; }
        public string FilePath { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool IsActive { get; set; }
    }
}
