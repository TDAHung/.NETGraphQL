using GraphQL.Types;
using GRAPHQL_SQL.Interfaces;
using GRAPHQL_SQL.Models;
using GRAPHQL_SQL.Type;

namespace GRAPHQL_SQL.Query
{
    public class StudentQuery : ObjectGraphType
    { 
        public StudentQuery(IStudentResolver studentResolver) {
            Field<ListGraphType<StudentType>>("data").Resolve(context =>
            {
                return studentResolver.GetStudents();
            });
            
        }
    }
}
