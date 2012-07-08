using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace teqBlog.Models
{
    public class BlogPost
    {
        public int BlogPostID { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

        public virtual ICollection<Photo> Photos { get; set; }

    }
}