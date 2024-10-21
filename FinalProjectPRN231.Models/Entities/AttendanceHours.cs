namespace FinalProjectPRN231.CoreBusiness.Entities
{
    public class AttendanceHours : CommonEntity
    {
        public int Id { get; set; }
        public int AttendanceId {  get; set; }
        public DateTime CheckInTime { get; set; }
        public DateTime CheckOutTime { get; set; }
        public virtual Attendance Attendance { get; set; }
    }
}
