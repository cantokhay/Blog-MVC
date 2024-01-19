using Blog.Domain.Enums;

namespace Blog.Domain.Entities
{
    public class Genre : IBaseEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public Status Status { get; set; }

        public List<Post> Posts { get; set; }
    }
}