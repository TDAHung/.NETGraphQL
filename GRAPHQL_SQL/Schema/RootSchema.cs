using GRAPHQL_SQL.Mutation;
using GRAPHQL_SQL.Query;

namespace GRAPHQL_SQL.Schema
{
    public class RootSchema : GraphQL.Types.Schema
    {

        public RootSchema(IServiceProvider serviceProvider) : base(serviceProvider) {
            Query = serviceProvider.GetRequiredService<AppQuery>();
            Mutation = serviceProvider.GetRequiredService<AppMutation>();
        }
    }
}
