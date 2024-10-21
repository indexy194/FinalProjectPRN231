using FinalProjectPRN231.CoreBusiness.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinalProjectPRN231.API.Infra.Data.EntityConfiguration
{
    public class AttendanceConfiguration : IEntityTypeConfiguration<Attendance>
    {
        public void Configure(EntityTypeBuilder<Attendance> builder)
        {
            builder.ToTable(nameof(Attendance));

            builder.HasKey(e => e.Id);
            
            builder.HasIndex(e => e.Id);
            builder.HasIndex(e => e.EmployeerId);
            builder.HasIndex(e => e.IsDeleted);
            
            builder.HasOne(d => d.Employeer)
                .WithMany(p => p.Attendances)
                .HasForeignKey(d => d.EmployeerId)
                .HasConstraintName($"{nameof(Attendance)}_{nameof(Employeer)}_FK");
        }
    }
}
