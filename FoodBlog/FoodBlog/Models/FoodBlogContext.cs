using Microsoft.EntityFrameworkCore;

namespace FoodBlog.Models
{
    public class FoodBlogContext : DbContext
    {
        public FoodBlogContext(DbContextOptions<FoodBlogContext> options) : base(options) { }
    }
}
