using System;
using System.Collections.Generic;
using System.Text;

namespace PtoManagement.Core.Services
{
    public class CreatePtoRequest
    {
        public int PtoId { get; set; }
        public int PtoTypeId { get; set; }
        public DateTime LeaveStartDate { get; set; }
        public DateTime LeaveEndDate { get; set; }
        public int EmployeeId { get; set; }


    }
}
