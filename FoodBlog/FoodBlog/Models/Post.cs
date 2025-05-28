namespace FoodBlog.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Ingredient { get; set; }
        public string Description { get; set; }
        public int PrepTime { get; set; }
        public int CookingTime { get; set; }
        public string ImageUrl { get; set; }
        public DateTime CreatedAt { get; set; }

        public ICollection<Step> Steps { get; set; }
        public ICollection<PostCategory> PostCategories { get; set; }
        public ICollection<WishList> WishLists { get; set; }
    }
}
