namespace grayFoundation.Models.Entities
{
    public class Like : BaseEntity
    {
        public int Count { get; set; }
        public string PostId { get; set; }
        public Post Post { get; set; }
    }
}
