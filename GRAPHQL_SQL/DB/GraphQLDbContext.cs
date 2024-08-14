using GRAPHQL_SQL.Models;
using Microsoft.EntityFrameworkCore;

namespace GRAPHQL_SQL.DB
{
    public class GraphQLDbContext : DbContext
    {
        public GraphQLDbContext(DbContextOptions<GraphQLDbContext> options) : base(options) {
            
        }

        public DbSet<Product> Product { get; set; }
        public DbSet<Student> Student { get; set; }
    }
}
