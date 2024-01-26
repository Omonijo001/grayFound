using static System.Net.Mime.MediaTypeNames;
using System;

namespace grayFoundation.Models.Entities
{
    public class Post : BaseEntity
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public decimal CountOfLike { get; set; }
        public decimal CountOfComment { get; set; }
        public ICollection<Comment> Comments { get; set; } = new HashSet<Comment>();
        public ICollection<Like> Likes { get; set; } = new HashSet<Like>();
    }
}
