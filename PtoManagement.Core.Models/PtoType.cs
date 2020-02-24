using System.Collections.Generic;

namespace PtoManagement.Core.Models
{
    public class PtoType
    {
        public int PtoTypeId { get; set; }
        public string PtoTypeName { get; set; }

        public virtual ICollection<Pto> Ptos { get; set; }
    }
}