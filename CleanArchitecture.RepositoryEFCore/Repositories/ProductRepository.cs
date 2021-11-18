using CleanArchitecture.Entities.Interfaces;
using CleanArchitecture.Entities.POCOs;
using CleanArchitecture.RepositoryEFCore.DataContext;

namespace CleanArchitecture.RepositoryEFCore.Repositories
{
    public class ProductRepository : IProductRepository
    {
        readonly CleanArchitectureContext Context;

        public ProductRepository(CleanArchitectureContext context) => Context = context;

        public void CreateProduct(Product product)
        {
            Context.Add(product);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return Context.Products;
        }

        public Product? GetById(int id)
        {
            return Context.Products.FirstOrDefault(p => p.Id == id);
        }
    }
}
