using GraphQL.Types;

namespace GRAPHQL_SQL.Query
{
    public class AppQuery : ObjectGraphType
    {
        public AppQuery() {
            Field<StudentQuery>("students").Resolve(context => new { });
            Field<ProductQuery>("products").Resolve(context => new { });
        }
    }
}
