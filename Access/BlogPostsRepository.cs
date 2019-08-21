using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

using Dapper;
using website_webapi.Models;
using System.Linq;
using Npgsql;

namespace website_webapi.Repositories
{
    public class BlogPostsRepository : IBlogPostsRepository
    {
        private readonly IConfiguration Configuration;

        public IDbConnection Connection
        {
            get
            {
                return new NpgsqlConnection(this.Configuration.GetConnectionString("DefaultConnection"));
            }
        }

        public BlogPostsRepository(IConfiguration config)
        {
            this.Configuration = config;
        }
        
        public async Task<IEnumerable<BlogPost>> ReadAllBlogPosts()
        {
            using (IDbConnection db = this.Connection)
            {
                var result = await db.QueryAsync<BlogPost>(
                    "SELECT * FROM blogposts"
                    );
                return result.ToList();
            }
        }

        public async Task<BlogPost> ReadBlogPost(int id) 
        {
            using (IDbConnection db = this.Connection)
                {
                    var result = await db.QueryAsync<BlogPost>(
                        @"SELECT * FROM blogposts
                        WHERE id = @id", new { id }
                        );
                    return result.FirstOrDefault(); 
                }
        }
    }
}