namespace grayFoundation.Models.Entities
{
    public class Event : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string AddressId { get; set; }
        public Address Address { get; set; }
    }
}
