namespace grayFoundation.Models.Entities
{
    public class Project : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Goals { get; set; }
        public string Image { get; set; }
        public ICollection<ProjectDonor> ProjectDonors { get; set; } = new HashSet<ProjectDonor>();
        public ICollection<ProjectVolunteer> ProjectVolunteers { get; set; } = new HashSet<ProjectVolunteer>();
    }
}
