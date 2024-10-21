using FinalProjectPRN231.CoreBusiness.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinalProjectPRN231.API.Infra.Data.EntityConfiguration
{
    public class EducationLevelConfiguration : IEntityTypeConfiguration<EducationLevel>
    {
        public void Configure(EntityTypeBuilder<EducationLevel> builder)
        {
            builder.ToTable(nameof(EducationLevel));
            //key
            builder.HasKey(e => e.Id);
            builder.HasIndex(e => e.Id);
            builder.HasIndex(e => e.IsDeleted);
            builder.HasIndex(e => e.EmployeerId);
            //foreign key
            builder.HasOne(d => d.Employeer)
                .WithMany(p => p.Educations)
                .HasForeignKey(d => d.EmployeerId)
                .HasConstraintName($"{nameof(Employeer)}_{nameof(EducationLevel)}_PK");
        }
    }
}
