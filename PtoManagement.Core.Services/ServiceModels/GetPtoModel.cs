using System;
using System.Collections.Generic;
using System.Text;

namespace PtoManagement.Core.Services
{
    public class GetPtoModel
    {
        public int PtoId { get; set; }
        public string PtoType { get; set; }
        public string PtoStatus { get; set; }
        public DateTime DateFiled { get; set; }
        public DateTime LeaveStartDate { get; set; }
        public DateTime LeaveEndDate { get; set; }
        public GetEmployeeModel FiledBy { get; set; }

    }
}
