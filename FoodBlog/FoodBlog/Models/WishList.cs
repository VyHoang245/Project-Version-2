namespace FoodBlog.Models
{
    public class WishList
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public int PostId { get; set; }
        public Post Post { get; set; }

        public DateTime? CreateDate { get; set; }
    }
}
