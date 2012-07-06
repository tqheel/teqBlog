using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace teqBlog.Models
{
    public class teqBlogEntities : DbContext
    {
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Photo>Photo {get;set;}
    }
}