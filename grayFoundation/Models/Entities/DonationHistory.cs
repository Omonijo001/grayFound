namespace grayFoundation.Models.Entities
{
    public class DonationHistory : BaseEntity
    { 
        public string DonorId { get; set; }
        public Donor Donor { get; set; }
    }
}
