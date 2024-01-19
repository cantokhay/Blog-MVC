using Blog.Domain.Enums;

namespace Blog.Models.DTOs.Genre
{
    public class GenreUpdateDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Status Status { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
