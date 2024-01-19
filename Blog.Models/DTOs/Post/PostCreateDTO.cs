using Blog.Domain.Enums;
using Blog.Models.VMs;
using System.ComponentModel.DataAnnotations;

namespace Blog.Models.DTOs.Post
{
    public class PostCreateDTO
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }
        public Status Status { get; set; }
        [Required(ErrorMessage = "Must be filled!")]
        public int AuthorId { get; set; }
        [Required(ErrorMessage = "Must be filled!")]
        public int GenreId { get; set; }
        public List<GenreVM> Genres { get; set; }
        public List<AuthorVM> Authors { get; set; }
    }
}
