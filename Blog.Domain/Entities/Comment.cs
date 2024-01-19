﻿using Blog.Domain.Enums;

namespace Blog.Domain.Entities
{
    public class Comment : IBaseEntity
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public Status Status { get; set; }

        public string AppUserID { get; set; }
        public AppUser AppUser { get; set; }

        public int PostID { get; set; }
        public Post Post { get; set; }
    }
}