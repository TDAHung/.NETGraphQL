using GRAPHQL_SQL.Models;

namespace GRAPHQL_SQL.Interfaces
{
    public interface IProductResolver
    {
        List<Product> GetProducts();

        Product GetProductById(int id);

        Product GetProductByName(string name);

        Product AddProduct(Product product);

        Product UpdateProduct(int id, Product product);

        void DeleteProduct(int id);
    }
}
