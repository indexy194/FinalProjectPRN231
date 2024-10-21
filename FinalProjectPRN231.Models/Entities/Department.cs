namespace FinalProjectPRN231.CoreBusiness.Entities
{
    public class Department : CommonEntity
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public int EmployeerId { get; set; }
        public virtual Employeer Employeer { get; set; }
        public ICollection<JobDetail> JobDetail { get; set; }
    }
}
