namespace FinalProjectPRN231.CoreBusiness.Entities
{
    public class JobDetail : CommonEntity
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public string JobTitle { get; set; }
        public Decimal MinSalary { get; set; }
        public Decimal MaxSalary { get; set; }
        public virtual Department Department { get; set; } 

    }
}
