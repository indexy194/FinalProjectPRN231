using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectPRN231.CoreBusiness.Entities
{
    public class Department : CommonEntity
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public int EmployeeId { get; set; }
        public virtual Employeer Employeer { get; set; }
    }
}
