using FinalProjectPRN231.CoreBusiness.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinalProjectPRN231.API.Infra.Data.EntityConfiguration
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable(nameof(Department));
            
            builder.HasKey(e => e.Id);
            builder.HasIndex(e => e.Id);
            builder.HasIndex(e => e.EmployeerId);
            builder.HasIndex(e => e.IsDeleted);

            builder.HasOne(d => d.Employeer)
                .WithMany(p => p.Departments)
                .HasForeignKey(d => d.EmployeerId)
                .HasConstraintName($"{nameof(Employeer)}_{nameof(Department)}_PK");
        }
    }
}
