namespace grayFoundation.Models.Entities
{
    public class Volunteer : BaseEntity
    {
        public string UserId { get; set; }
        public User User { get; set; }
        public string VoluntaryRole { get; set; }
        public string Skills { get; set; }
        public string Availability { get; set; }
        public string PastExperiences { get; set; }
        public ICollection<ProjectVolunteer> ProjectVolunteers { get; set; } = new HashSet<ProjectVolunteer>();
    }
}
