using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PtoManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PtoManagement.Infrasturcture.Data
{
    public class EmployeeTypeConfiguration : IEntityTypeConfiguration<EmployeeType>
    {
        public EmployeeTypeConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<EmployeeType> builder)
        {
            builder.ToTable("EmployeeTypes", "Lookup");
            builder.HasKey(e => e.EmployeeTypeId);
            builder.Property(e => e.EmployeeTypeName).IsRequired();

            builder.HasData(
                new EmployeeType() { EmployeeTypeId = 1, EmployeeTypeName = "User" },
                new EmployeeType() { EmployeeTypeId = 2, EmployeeTypeName = "Manager" },
                new EmployeeType() { EmployeeTypeId = 3, EmployeeTypeName = "Admin" }
            );
        }
    }
}
