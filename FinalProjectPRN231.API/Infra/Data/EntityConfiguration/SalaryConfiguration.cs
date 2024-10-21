using FinalProjectPRN231.CoreBusiness.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinalProjectPRN231.API.Infra.Data.EntityConfiguration
{
    public class SalaryConfiguration : IEntityTypeConfiguration<Salary>
    {
        public void Configure(EntityTypeBuilder<Salary> builder)
        {
            builder.ToTable(nameof(Salary));
            //pk
            builder.HasKey(e => e.Id);
            //index
            builder.HasIndex(e => e.Id);
            builder.HasIndex(e => e.EmployeerId);
            builder.HasIndex(e => e.IsDeleted);
            //props
            builder.Property(e => e.BaseSalary)
                .HasColumnName("BaseSalary")
                .HasPrecision(18, 2);
            builder.Property(e => e.Allowance)
                .HasColumnName("Allowance")
                .HasPrecision(18, 2); 
            builder.Property(e => e.Deduction)
                .HasColumnName("Deduction")
                .HasPrecision(18, 2);
            //fk
            builder.HasOne(d => d.Employeer)
                .WithMany(p => p.Salaries)
                .HasForeignKey(d => d.EmployeerId)
                .HasConstraintName($"{nameof(Employeer)}_{nameof(Salary)}_FK");

        }
    }
}
