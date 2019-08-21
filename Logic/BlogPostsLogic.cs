using System.Collections.Generic;
using System.Threading.Tasks;
using website_webapi.Models;
using website_webapi.Repositories;

namespace website_webapi.Logic
{
    public class BlogPostsLogic 
    {
        IBlogPostsRepository BlogPostsRepository;

        public BlogPostsLogic(IBlogPostsRepository blogPostsRepository) {
            this.BlogPostsRepository = blogPostsRepository;
        }

        public async Task<BlogPost> GetBlogPost(int id) {
            return await this.BlogPostsRepository.ReadBlogPost(id);
        }

        public async Task<IEnumerable<BlogPost>> GetAllBlogPosts() {
            return await this.BlogPostsRepository.ReadAllBlogPosts();
        }
    }
}