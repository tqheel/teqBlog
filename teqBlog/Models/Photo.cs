using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace teqBlog.Models
{
    public class Photo
    {
        public int PhotoID { get; set; }
        public string FileName { get; set; }
        public int BlogPostID { get; set; }

        public virtual BlogPost BlogPost { get; set; }
    }
}