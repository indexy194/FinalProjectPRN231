using FinalProjectPRN231.CoreBusiness.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinalProjectPRN231.API.Infra.Data.EntityConfiguration
{
    public class WorkExperienceConfiguration : IEntityTypeConfiguration<WorkExperience>
    {
        public void Configure(EntityTypeBuilder<WorkExperience> builder)
        {
            builder.ToTable(nameof(WorkExperience));
            //pk
            builder.HasKey(x => x.Id);
            //index
            builder.HasIndex(x => x.Id);
            builder.HasIndex(x => x.EmployeerId);
            builder.HasIndex(x => x.IsDeleted);
            //fk
            builder.HasOne(d => d.Employeer)
                .WithMany(p => p.WorkExperiences)
                .HasForeignKey(d => d.EmployeerId)
                .HasConstraintName($"{nameof(Employeer)}_{nameof(WorkExperience)}_FK");
        }
    }
}
