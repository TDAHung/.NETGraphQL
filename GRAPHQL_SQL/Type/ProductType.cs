using GraphQL.Types;
using GRAPHQL_SQL.Models;

namespace GRAPHQL_SQL.Type
{
    public class ProductType : ObjectGraphType<Product>
    {
        public ProductType()
        {
            Field(product => product.Id);
            Field(product => product.Name);
            Field(product => product.Quantity);
        }
    }
}
