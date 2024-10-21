namespace FinalProjectPRN231.CoreBusiness.Entities
{
    public class Salary : CommonEntity
    {
        public int Id { get; set; }
        public int EmployeerId { get; set; }
        public decimal BaseSalary { get; set; }
        public decimal Allowance {  get; set; }
        public decimal Deduction {  get; set; } 
        public DateTime PayDate { get; set; }
        public virtual Employeer Employeer { get; set; }
    }
}
