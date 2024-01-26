namespace grayFoundation.Models.Entities
{
    public class Donor : BaseEntity
    {
        public string UserId { get; set;}
        public User User { get; set; }
        public ICollection<ProjectDonor> ProjectDonors { get; set; } = new HashSet<ProjectDonor>();
    }
}
