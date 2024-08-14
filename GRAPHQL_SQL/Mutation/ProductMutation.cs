using GraphQL;
using GraphQL.Types;
using GRAPHQL_SQL.Interfaces;
using GRAPHQL_SQL.Models;
using GRAPHQL_SQL.Type;

namespace GRAPHQL_SQL.Mutation
{
    public class ProductMutation : ObjectGraphType
    {
        public ProductMutation(IProductResolver productResolver)
        {
            Field<ProductType>("CreateProduct")
                .Arguments(new QueryArguments(new QueryArgument<ProductInputType> { Name = "product" }))
                .Resolve(context => {
                    return productResolver.AddProduct(context.GetArgument<Product>("product"));
                });

            Field<ProductType>("UpdateProduct")
                .Arguments(
                    new QueryArguments(
                        new QueryArgument<ProductInputType> { Name = "product" },
                        new QueryArgument<IntGraphType> { Name = "productId" }
                ))
                .Resolve(context => {
                    var productId = context.GetArgument<int>("productId");
                    var product = context.GetArgument<Product>("product");
                    return productResolver.UpdateProduct(productId, context.GetArgument<Product>("product"));
                });

            Field<StringGraphType>("DeleteProduct")
                .Arguments(
                    new QueryArguments(
                        new QueryArgument<IntGraphType> { Name = "productId" }
                ))
                .Resolve(context => {
                    var productId = context.GetArgument<int>("productId");
                    return "Product with id:" + productId + "has been deleted";
                });
        }
    }
}
