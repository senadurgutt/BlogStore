﻿using WebApplication1.Entity;

namespace WebApplication1.Models
{
    public class PostsViewModel
    {
        public List<Post> Posts { get; set; } = new();
        public List<Tag> Tags{ get; set; } = new();

    }
    
}
