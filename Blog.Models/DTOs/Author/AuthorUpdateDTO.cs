using Blog.Domain.Enums;
using Blog.Models.VMs;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Blog.Models.DTOs.Author
{
    public class AuthorUpdateDTO
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Must be filled!")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Must be filled!")]
        public string LastName { get; set; }
        public DateTime UpdateDate { get; set; }
        public Status Status { get; set; }
        public List<PostVM> Posts { get; set; }
    }
}
