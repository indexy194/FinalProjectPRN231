namespace FinalProjectPRN231.CoreBusiness.Entities
{
    public class WorkExperience : CommonEntity
    {
        public int Id { get; set; }
        public int EmployeerId { get; set; }
        public string CompanyName { get; set; }
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Relevant { get; set; }
        public virtual Employeer Employeer { get; set; }
    }
}
