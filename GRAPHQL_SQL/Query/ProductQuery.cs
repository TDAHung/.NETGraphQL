using GraphQL;
using GraphQL.Types;
using GRAPHQL_SQL.Interfaces;
using GRAPHQL_SQL.Type;

namespace GRAPHQL_SQL.Query
{
    public class ProductQuery : ObjectGraphType
    {
         public ProductQuery(IProductResolver productResolver)
        {
            Field<ListGraphType<ProductType>>("Products").Resolve(context => {
                return productResolver.GetProducts();
            });

            Field<ProductType>("Product").Arguments(new QueryArgument<IntGraphType> { Name = "productId" }).Resolve(context => {
                return productResolver.GetProductById(context.GetArgument<int>("productId"));
            });
        }
    }
}
