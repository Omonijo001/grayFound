namespace grayFoundation.Models.Entities
{
    public class User : BaseUser
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public ICollection<UserRole> UserRoles { get; set; } = new HashSet<UserRole>();
    }
}
