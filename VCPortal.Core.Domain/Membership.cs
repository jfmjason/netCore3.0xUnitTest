using System;

namespace VCPortal.Core.Domain
{
    public class Membership
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
}
