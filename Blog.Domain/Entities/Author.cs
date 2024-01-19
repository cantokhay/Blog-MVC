using Blog.Domain.Enums;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Domain.Entities
{
    public class Author : IBaseEntity
    {

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public Status Status { get; set; }

        public List<Post> Posts { get; set; }
    }
}
