namespace grayFoundation.Models.Entities
{
    public class BaseEntity
    {
        public string Id { get; set; } = Guid.NewGuid().ToString().Substring(0, 5);
        public bool IsDeleted { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
