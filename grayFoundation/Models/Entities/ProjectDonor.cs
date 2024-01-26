namespace grayFoundation.Models.Entities
{
    public class ProjectDonor : BaseEntity
    {
        public string DonorId { get; set; }
        public Donor Donor { get; set; }
        public string ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
