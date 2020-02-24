using Microsoft.EntityFrameworkCore;
using PtoManagement.Core.Models;
using PtoManagement.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace PtoManagement.Infrasturcture.Data
{
    public class PtoManagementDbContext : DbContext, IPtoManagementDbContext
    {
        public PtoManagementDbContext(DbContextOptions<PtoManagementDbContext> options) : base (options)
        {

        }
        public DbSet<Pto> Ptos { get; set; }
        public DbSet<PtoType> PtoTypes { get; set; }
        public DbSet<PtoStatus> PtoStatus { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeType> EmployeeTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PtoConfiguration).Assembly);
        }

    }
}
