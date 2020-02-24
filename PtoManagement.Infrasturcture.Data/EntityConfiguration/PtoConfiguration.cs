using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PtoManagement.Core.Models;

namespace PtoManagement.Infrasturcture.Data
{
    public class PtoConfiguration : IEntityTypeConfiguration<Pto>
    {
        public PtoConfiguration()
        {
        }
        public void Configure(EntityTypeBuilder<Pto> builder)
        {

            builder.ToTable("Ptos", "Pto");
            builder.HasKey(p => p.PtoId);
            builder.Property(p => p.PtoId)
                .IsRequired();

            builder.HasOne(p => p.Employee).WithMany(e => e.Ptos).HasForeignKey(p => p.EmployeeId);
            builder.HasOne(p => p.PtoType).WithMany(t => t.Ptos).HasForeignKey(p => p.PtoTypeId);
            builder.HasOne(p => p.PtoStatus).WithMany(s => s.Ptos).HasForeignKey(p => p.PtoStatusId);
        }
    }
}