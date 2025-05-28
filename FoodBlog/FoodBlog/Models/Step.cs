namespace FoodBlog.Models
{
    public class Step
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public int Order { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }

        public Post Post { get; set; }
    }
}
