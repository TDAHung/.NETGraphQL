using GRAPHQL_SQL.DB;
using GRAPHQL_SQL.Interfaces;
using GRAPHQL_SQL.Models;

namespace GRAPHQL_SQL.Resolver
{
    public class StudentResolver : IStudentResolver
    {
        private readonly GraphQLDbContext _context;
        public StudentResolver(GraphQLDbContext context) {
            _context = context;
        }

        public List<Student> GetStudents() {
            return _context.Student.ToList();
        }
    }
}
