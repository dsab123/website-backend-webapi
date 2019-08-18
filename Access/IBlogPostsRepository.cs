
using System.Collections.Generic;
using System.Threading.Tasks;
using website_webapi.Models;

namespace website_webapi.Repositories
{
    public interface IBlogPostsRepository 
    {
        Task<IEnumerable<BlogPost>> ReadAllBlogPosts();

    }
}