using System;
using System.Collections.Generic;
using System.Text;

namespace PtoManagement.Core.Services
{
    public class GetEmployeeModel
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int TeamId { get; set; }
        public int EmployeeTypeId { get; set; }
        public int TotalAccrued { get; set; }
        public int TotalUsed { get; set; }
    }
}
