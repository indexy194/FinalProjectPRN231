namespace FinalProjectPRN231.API.DTO.Users
{
    public class UserDTO : BaseUserDTO
    {
    }
    public class BaseUserDTO
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string DisplayName { get; set; }
        public DateTime? CreatedUtc { get; set; }
        public DateTime? BirthYear { get; set; }
        public string PhoneNumber { get; set; }
        public string CityName { get; set; }
        public string GraduatedSchool { get; set; }
        public string AvatarUrl { get; set; }
    }
}
