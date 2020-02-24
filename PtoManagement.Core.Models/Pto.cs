using System;
using System.Collections.Generic;
using System.Text;

namespace PtoManagement.Core.Models
{
    public class Pto
    {
        public int PtoId { get; set; }
        public int EmployeeId { get; set; }
        public int PtoTypeId { get; set; }
        public int PtoStatusId { get; set; }
        public DateTime DateFiled { get; set; }
        public DateTime LeaveStartDate { get; set; }
        public DateTime LeaveEndDate { get; set; }
        public string Reason { get; set; }
        public int ApprovedBy { get; set; }
        public PtoType PtoType { get; set; }
        public PtoStatus PtoStatus { get; set; }
        public Employee Employee { get; set; }


    }
}
