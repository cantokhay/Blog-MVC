using Blog.Domain.Enums;
using Blog.Models.VMs;
using System.ComponentModel.DataAnnotations;

namespace Blog.Models.DTOs.Post
{
    public class PostUpdateDTO
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime UpdateDate { get; set; }
        public Status Status { get; set; }
        public int AuthorId { get; set; }
        public int GenreId { get; set; }
        public List<GenreVM> Genres { get; set; }
        public List<AuthorVM> Authors { get; set; }
    }
}
