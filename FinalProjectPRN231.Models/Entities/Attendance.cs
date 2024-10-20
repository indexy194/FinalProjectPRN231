using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectPRN231.CoreBusiness.Entities
{
    public class Attendance : CommonEntity
    {
        public int Id { get; set; }
        public int EmployeerId {  get; set; }
        public DateTime CheckInTime { get; set; }
        public DateTime CheckOutTime { get; set; }
        public virtual Employeer Employeer { get; set; }
    }
}
