namespace grayFoundation.Models.Entities
{
    public class ProjectVolunteer : BaseEntity
    {
        public string VolunteerId { get; set; }
        public Volunteer Volunteer { get; set; }
        public string ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
