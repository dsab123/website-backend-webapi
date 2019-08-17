using System;
using System.Collections.Generic;
using System.Text;


public class BlogPostException : Exception {

    public BlogPostException(string message) : base(message) 
    {
    }

    public static BlogPost ReturnErrorBlogPost()
    {
        return new BlogPost(-1);
    }
}