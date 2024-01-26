namespace grayFoundation.Models.Entities
{
    public class BaseUser : BaseEntity
    {
        public string ProfilePicture { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string RegistrationNumber { get; set; }
        public string AddressId { get; set; }
        public Address Address { get; set; }
    }
}
