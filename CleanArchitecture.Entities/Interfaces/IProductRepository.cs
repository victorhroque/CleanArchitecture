using CleanArchitecture.Entities.POCOs;

namespace CleanArchitecture.Entities.Interfaces
{
    public interface IProductRepository
    {
        Product? GetById(int id);
        void CreateProduct(Product product);
        IEnumerable<Product> GetAllProducts();
    }
}
