using GraphQL.Types;

namespace GRAPHQL_SQL.Type
{
    public class ProductInputType : InputObjectGraphType
    {
        public ProductInputType()
        {
            Field<IntGraphType>("id");
            Field<StringGraphType>("name");
            Field<IntGraphType>("quantity");
        }
    }
}
