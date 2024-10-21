using FinalProjectPRN231.CoreBusiness.Entities;
using FinalProjectPRN231.CoreBusiness.Enums;

namespace FinalProjectPRN231.API.DTO.EmployeerDTO
{
    public class EmployeerDTO : CommonEntity
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public GenderType Gender { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Description { get; set; }
        public string CivilId { get; set; }
        public string AvatarUrl { get; set; }
        public DateTime HiredDate { get; set; }
        public DateTime TerminationDate { get; set; }
    }
}
