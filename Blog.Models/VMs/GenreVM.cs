using Blog.Domain.Enums;

namespace Blog.Models.VMs
{
    public class GenreVM
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Status Status { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
