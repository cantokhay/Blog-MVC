namespace Blog.Models.VMs
{
    public class LikeVM
    {
        public int ID { get; set; }
        public int PostId { get; set; }
        public int AppUserId { get; set; }
        public string PostTitle { get; set; }
        public string AppUserName { get; set; }
    }
}
