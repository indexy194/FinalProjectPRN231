using FinalProjectPRN231.CoreBusiness.Enums;

namespace FinalProjectPRN231.CoreBusiness.Entities
{
    public class Employeer : CommonEntity
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public GenderType Gender { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Description { get; set; }
        public string CivilId { get; set; }
        public string AvatarUrl { get; set; }
        public DateTime HiredDate { get; set; }
        public DateTime TerminationDate { get; set; }
        public virtual ICollection<Attendance> Attendances { get; set; }
        public virtual ICollection<Department> Departments { get; set; }
        public virtual ICollection<EducationLevel> Educations { get; set; }
        public virtual ICollection<Location> Locations { get; set; }
        public virtual ICollection<Salary> Salaries { get; set; }
        public virtual ICollection<WorkExperience> WorkExperiences { get; set; }
    }
}
