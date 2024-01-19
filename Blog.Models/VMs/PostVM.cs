namespace Blog.Models.VMs
{
    public class PostVM
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string GenreName { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }
        public string AuthorFullName => $"{AuthorFirstName} {AuthorLastName}";
        public List<CommentVM> Comments { get; set; }
        public List<LikeVM> Likes { get; set; }
    }
}
