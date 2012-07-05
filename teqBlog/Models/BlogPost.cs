﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace teqBlog.Models
{
    public class BlogPost
    {
        public int PostID { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}