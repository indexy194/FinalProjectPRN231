using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectPRN231.CoreBusiness.Entities
{
    public class EducationLevel : CommonEntity
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string SchoolName { get; set; }
        public string Degree {  get; set; }
        public string Specialization { get; set; }
        public DateTime CompletionDate { get; set; }
        public virtual Employeer Employeer { get; set; }
    }
}
