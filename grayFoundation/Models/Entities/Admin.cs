namespace grayFoundation.Models.Entities
{
    public class Admin : BaseEntity
    {
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
