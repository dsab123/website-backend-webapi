using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

using Dapper;
using website_webapi.Models;

namespace website_webapi.Repositories
{
    public class BlogPostsRepository : IBlogPostsRepository
    {
        private readonly IConfiguration Configuration;

        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(this.Configuration.GetConnectionString("DefaultConnectionString"));
            }
        }

        public BlogPostsRepository(IConfiguration config)
        {
            this.Configuration = config;
        }
        public async Task<IEnumerable<BlogPost>> ReadAllBlogPosts()
        {
            using (IDbConnection db = new SqlConnection(this.Configuration["Data:DefaultConnection:ConnectionString"]))
            {
                return await db.QueryAsync<BlogPost>("Select * From blogposts");                
            }
        }
    }
}