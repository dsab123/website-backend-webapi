using System;
using System.Collections.Generic;
using System.Text;

namespace website_webapi.Models {
public class BlogPostException : Exception {

        public BlogPostException(string message) : base(message) 
        {
        }

        public static BlogPost ReturnErrorBlogPost()
        {
            return new BlogPost(-1);
        }
    }
}