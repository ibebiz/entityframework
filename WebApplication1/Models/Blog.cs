using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Rating { get; set; }
        public IList<Post> Posts { get; set; }
    }

    public class Post
    {
        public int Id { get; set; }
        [MaxLength(200)]
        public string Title { get; set; }
        public string Content { get; set; }
        public string Abstract { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
    public partial class BlogContext : DbContext
    {
        public BlogContext()
            : base("BlogDb")
        {
        }

       
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; } 

    }
}