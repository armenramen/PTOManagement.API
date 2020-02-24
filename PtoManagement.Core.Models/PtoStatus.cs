using System.Collections.Generic;

namespace PtoManagement.Core.Models
{
    public class PtoStatus
    {
        public int PtoStatusId { get; set; }
        public string PtoStatusName { get; set; }
        public virtual ICollection<Pto> Ptos { get; set; }
        
    }
      public enum PtoStatusEnum
    {
        ForApproval = 1,
        Approved = 2,
        Rejected = 3,
        Cancelled = 4
    }

}