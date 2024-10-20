using FinalProjectPRN231.CoreBusiness.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectPRN231.CoreBusiness.Entities
{
    public class Employeer : CommonEntity
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public GenderType Gender { get; set; }
        public int PhoneNumber { get; set; }
        public string Description { get; set; }
        public string CivilId { get; set; }
        public DateTime HiredDate { get; set; }
        public DateTime TerminationDate { get; set; }
        public virtual IList<Attendance> Attendances { get; set; }
        public virtual IList<Department> Departments { get; set; }
        public virtual IList<EducationLevel> Educations { get; set; }
        public virtual IList<Location> Locations { get; set; }
        public virtual IList<Salary> Salaries { get; set; }
        public virtual IList<WorkExperience> WorkExperiences { get; set; }
    }
}
