using Blog.Domain.Enums;
using Blog.Models.VMs;
using System.ComponentModel.DataAnnotations;

namespace Blog.Models.DTOs.Comment
{
    public class CommentUpdateDTO
    {
        public int ID { get; set; }
        public DateTime UpdateDate { get; set; }
        public Status Status { get; set; }
        [Required(ErrorMessage = "Must be filled!")]
        public string AppUserID { get; set; }
        [Required(ErrorMessage = "Must be filled!")]
        public int PostId { get; set; }
        public List<AppUserVM> Users { get; set; }
        public List<PostVM> Posts { get; set; }
    }
}
