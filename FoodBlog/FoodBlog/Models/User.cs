using Microsoft.Extensions.Hosting;

namespace FoodBlog.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime? Dob { get; set; }
        public string Email { get; set; }

        public int RoleId { get; set; }
        public Role Role { get; set; }

        public ICollection<Post> Posts { get; set; }
        public ICollection<WishList> WishLists { get; set; }
    }
}
