using Blog.Domain.Enums;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Domain.Entities
{
    public class Post : IBaseEntity
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public Status Status { get; set; }

        public int AuthorID { get; set; }
        public Author Author { get; set; } //bir post'un bir yazarı olur.

        public int GenreID { get; set; }
        public Genre Genre { get; set; } //bir post'un bir türü olur.

        public List<Comment> Comments { get; set; } //bir post'un birden fazla yorumu olur.
        public List<Like> Likes { get; set; } //bir post'un birden fazla like'ı olur.
    }
}