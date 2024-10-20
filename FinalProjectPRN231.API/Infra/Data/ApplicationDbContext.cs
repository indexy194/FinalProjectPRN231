using FinalProjectPRN231.CoreBusiness.Entities;
using Microsoft.EntityFrameworkCore;

namespace FinalProjectPRN231.API.Infra.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
            
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)  : base(options)
        {
            
        }
        public virtual DbSet<Attendance> Attendances { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<EducationLevel> Educations { get; set; }
        public virtual DbSet<Employeer> Employers { get; set; }
        public virtual DbSet<JobDetail> JobDetails { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Salary> Salaries { get; set; }
        public virtual DbSet<WorkExperience> WorkExperience { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            OnBeforeSaving();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);

        }
        protected virtual void OnBeforeSaving()
        {
            foreach(var entry in ChangeTracker.Entries())
            {
                if(entry.State == EntityState.Added)
                {
                    ((CommonEntity)entry.Entity).CreatedAt = DateTime.UtcNow;
                }
                ((CommonEntity)entry.Entity).UpdatedAt = DateTime.UtcNow;
            }
        }
    }
}
