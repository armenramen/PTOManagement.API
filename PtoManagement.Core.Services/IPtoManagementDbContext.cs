using Microsoft.EntityFrameworkCore;
using PtoManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PtoManagement.Core.Services
{
    public interface IPtoManagementDbContext
    {
        int SaveChanges();
        DbSet<Pto> Ptos { get; set; }
        DbSet<PtoType> PtoTypes { get; set; }
        DbSet<PtoStatus> PtoStatus { get; set; }
        DbSet<Employee> Employees { get; set; }
        DbSet<EmployeeType> EmployeeTypes { get; set; }
    }
}
