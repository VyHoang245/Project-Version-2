﻿namespace FoodBlog.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        public ICollection<PostCategory> PostCategories { get; set; }
    }
}
