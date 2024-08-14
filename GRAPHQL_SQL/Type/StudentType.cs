using GraphQL.Types;
using GRAPHQL_SQL.Models;

namespace GRAPHQL_SQL.Type
{
    public class StudentType : ObjectGraphType<Student>
    {
        public StudentType()
        {
            Field(student => student.Id);
            Field(student => student.Name);
            Field(student => student.Description);
        }
    }
}
