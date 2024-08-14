using GRAPHQL_SQL.Models;

namespace GRAPHQL_SQL.Interfaces
{
    public interface IStudentResolver
    {
        List<Student> GetStudents();
    }
}
