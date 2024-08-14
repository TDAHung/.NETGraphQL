using GRAPHQL_SQL.DB;
using GRAPHQL_SQL.Interfaces;
using GRAPHQL_SQL.Models;

namespace GRAPHQL_SQL.Services
{
    public class ProductResolver : IProductResolver
    {
        private GraphQLDbContext _context;

        public ProductResolver(GraphQLDbContext context)
        {
            _context = context;
        }

        public Product AddProduct(Product product)
        {
            _context.Product.Add(product);
            _context.SaveChanges();
            return product;
        }

        public void DeleteProduct(int id)
        {
           var product = _context.Product.Find(id);
            _context.Product.Remove(product);
            _context.SaveChanges();
        }

        public Product GetProductById(int id)
        {
            return _context.Product.FirstOrDefault(product => product.Id == id);
        }

        public Product GetProductByName(string name)
        {
            return _context.Product.FirstOrDefault(product => product.Name == name);
        }

        public List<Product> GetProducts()
        {
            return _context.Product.ToList();
        }

        public Product UpdateProduct(int id, Product newProduct)
        {
            var product = _context.Product.Find(id);
            product.Name = newProduct.Name;
            product.Quantity = newProduct.Quantity;
            _context.SaveChanges();
            return product;
        }
    }
}
