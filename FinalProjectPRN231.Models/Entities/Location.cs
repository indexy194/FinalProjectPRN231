namespace FinalProjectPRN231.CoreBusiness.Entities
{
    public class Location : CommonEntity
    {
        public int Id { get; set; }
        public int EmployeerId { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public virtual Employeer Employeer { get; set; }
    }
}
