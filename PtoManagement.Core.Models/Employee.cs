using System;
using System.Collections.Generic;
using System.Text;

namespace PtoManagement.Core.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public int TeamId { get; set; }
        public int EmployeeTypeId { get; set; }
        public int TotalAccrued { get; set; }
        public int TotalUsed { get; set; }
        public string EmployeeName { get; set; } // To be dropped later

        public virtual ICollection<Pto> Ptos { get; set; }
    }
}
