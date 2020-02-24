using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PtoManagement.Core.Models;

namespace PtoManagement.Infrasturcture.Data
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
         public EmployeeConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employees", "Pto");
            builder.HasKey(e => e.EmployeeId);
            builder.Property(e => e.EmployeeName).IsRequired();
        }
    }
}