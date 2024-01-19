namespace Blog.Models.VMs
{
    public class CommentVM
    {
        public int ID { get; set; }
        public string Content { get; set; }
        public string Title { get; set; }
        public List<AppUserVM> Users { get; set; }
        public List<PostVM> Posts { get; set; }
    }
}
