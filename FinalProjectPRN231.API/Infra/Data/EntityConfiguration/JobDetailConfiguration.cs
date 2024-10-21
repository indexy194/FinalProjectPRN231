using FinalProjectPRN231.CoreBusiness.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinalProjectPRN231.API.Infra.Data.EntityConfiguration
{
    public class JobDetailConfiguration : IEntityTypeConfiguration<JobDetail>
    {
        public void Configure(EntityTypeBuilder<JobDetail> builder)
        {
            builder.ToTable(nameof(JobDetail));
            //key
            builder.HasKey(x => x.Id);
            //index
            builder.HasIndex(x => x.Id);
            builder.HasIndex(x => x.IsDeleted);
            builder.HasIndex(x => x.DepartmentId);
            //props
            builder.Property(e => e.MinSalary)
                .HasColumnName("MinSalary")
                .HasPrecision(18, 2); 
            builder.Property(e => e.MaxSalary)
                .HasColumnName("MaxsSalary")
                .HasPrecision(18, 2);
            //fk
            builder.HasOne(d => d.Department)
                .WithMany(p => p.JobDetail)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName($"{nameof(Department)}_{nameof(JobDetail)}_FK");
        }
    }
}
