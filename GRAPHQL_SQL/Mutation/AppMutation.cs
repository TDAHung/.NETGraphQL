using GraphQL.Types;
using GRAPHQL_SQL.Query;

namespace GRAPHQL_SQL.Mutation
{
    public class AppMutation : ObjectGraphType
    {
        public AppMutation() {
            Field<ProductMutation>("products").Resolve(context => new { });
        }
    }
}
