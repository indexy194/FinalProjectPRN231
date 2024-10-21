using FinalProjectPRN231.CoreBusiness.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinalProjectPRN231.API.Infra.Data.EntityConfiguration
{
    public class LocationConfiguration : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.ToTable(nameof(Location));
            //key
            builder.HasKey(e => e.Id);
            //index
            builder.HasIndex(e => e.Id);
            builder.HasIndex(e => e.IsDeleted);
            builder.HasIndex(e => e.EmployeerId);
            //fk
            builder.HasOne(d => d.Employeer)
                .WithMany(p => p.Locations)
                .HasForeignKey(d => d.EmployeerId)
                .HasConstraintName($"{nameof(Employeer)}_{nameof(Location)}_FK");
        } 
    }
}
