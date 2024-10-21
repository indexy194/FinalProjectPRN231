namespace FinalProjectPRN231.CoreBusiness.Entities
{
    public class Attendance : CommonEntity
    {
        public int Id {  get; set; }
        public int EmployeerId { get; set; }
        public DateTime CheckedDate { get; set; }
        public virtual Employeer Employeer{ get; set; }
        public ICollection<AttendanceHours> AttendanceHours { get; set; }

    }
}
