using FinalProjectPRN231.CoreBusiness.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinalProjectPRN231.API.Infra.Data.EntityConfiguration
{
    public class EmployeerConfiguration : IEntityTypeConfiguration<Employeer>
    {
        public void Configure(EntityTypeBuilder<Employeer> builder)
        {
            builder.ToTable(nameof(Employeer));
            //key
            builder.HasKey(e => e.Id);
            //index
            builder.HasIndex(e => e.Id);
            builder.HasIndex(e => e.IsDeleted);
        }
    }
}
