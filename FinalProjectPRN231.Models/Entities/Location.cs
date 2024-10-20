using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectPRN231.CoreBusiness.Entities
{
    public class Location : CommonEntity
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public virtual Employeer Employeer { get; set; }
    }
}
