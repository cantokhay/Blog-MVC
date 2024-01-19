using Blog.Domain.Enums;

namespace Blog.Models.DTOs.Genre
{
    public class GenreCreateDTO
    {
        public string Name { get; set; }
        public Status Status { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
