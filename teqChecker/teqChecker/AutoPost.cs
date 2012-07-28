using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using teqBlogModel;


namespace teqChecker
{
    class AutoPost
    {
        public static void PostPic(string url, string fileName)
        {
            using (teqBlogEntities context = new teqBlogEntities())
            {
                BlogPost p = new BlogPost();
                p.Title = "Auto Posted Photo: " + fileName;
                p.Body="<img src='" + url + "' alt='" + fileName + "' />"
            }
        }
    }
}
