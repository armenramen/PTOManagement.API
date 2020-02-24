using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PtoManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PtoManagement.Infrasturcture.Data
{
    public class PtoStatusConfiguration : IEntityTypeConfiguration<PtoStatus>
    {
        public PtoStatusConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<PtoStatus> builder)
        {
            builder.ToTable("PtoStatus", "Lookup");
            builder.HasKey(p => p.PtoStatusId);
            builder.Property(p => p.PtoStatusName).IsRequired();

            builder.HasData(
                new PtoStatus() { PtoStatusId = 1, PtoStatusName = "For Approval" },
                new PtoStatus() { PtoStatusId = 2, PtoStatusName = "Approved" },
                new PtoStatus() { PtoStatusId = 3, PtoStatusName = "Rejected" },
                new PtoStatus() { PtoStatusId = 4, PtoStatusName = "Cancelled" }
            );
        }
    }
}
