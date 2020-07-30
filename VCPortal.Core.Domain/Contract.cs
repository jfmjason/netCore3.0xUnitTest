using System;

namespace VCPortal.Core.Domain
{
    public class Contract
    {
        public int Id { get; set; }
        public int ContractNo { get; set; }
        public string CardType { get; set; }
        public string Scheme { get; set; }
        public string Network { get; set; }
        public string PolicyNo { get; set; }
        public string FilePath { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool IsActive { get; set; }
    }
}
