using FinalProjectPRN231.CoreBusiness.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinalProjectPRN231.API.Infra.Data.EntityConfiguration
{
    public class AttendanceHourConfiguration : IEntityTypeConfiguration<AttendanceHours>
    {
        public void Configure(EntityTypeBuilder<AttendanceHours> builder)
        {
            builder.ToTable(nameof(AttendanceHours));
            //key
            builder.HasKey(x => x.Id);

            builder.HasIndex(x => x.Id);
            builder.HasIndex(x => x.AttendanceId);
            builder.HasIndex(x => x.IsDeleted);
            
            builder.HasOne(d => d.Attendance)
                .WithMany(p => p.AttendanceHours)
                .HasForeignKey(d => d.AttendanceId)
                .HasConstraintName($"{nameof(Attendance)}_{nameof(AttendanceHours)}_PK");
        }
    }
}
