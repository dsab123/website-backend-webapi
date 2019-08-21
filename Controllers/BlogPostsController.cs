using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using website_webapi.Models;
using website_webapi.Logic;
using website_webapi.Repositories;


namespace website_webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogPostsController : ControllerBase
    {
        private readonly IBlogPostsRepository blogPostsRepository;

        public BlogPostsController(IBlogPostsRepository blogPostsRepository) {
            this.blogPostsRepository = blogPostsRepository;
        }

        // GET api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BlogPost>>> GetAllBlogPosts()
        {
            var result = await (new BlogPostsLogic(this.blogPostsRepository)).GetAllBlogPosts();
            
            // must return a list because "C# doesn't support implicit cast operators on interfaces"
            // (https://docs.microsoft.com/en-us/aspnet/core/web-api/action-return-types?view=aspnetcore-2.2#actionresultt-type)
            
            return result.ToList(); 
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<BlogPost>> GetBlogPost(int id) {
            return  await (new BlogPostsLogic(this.blogPostsRepository)).GetBlogPost(id);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
