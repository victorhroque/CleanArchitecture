using CleanArchitecture.DTOs;
using CleanArchitecture.Entities.Interfaces;
using CleanArchitecture.Entities.POCOs;
using CleanArchitecture.UseCasesPorts;

namespace CleanArchitecture.UseCases.CreateProduct
{
    public class CreateProductInteractor : ICreateProductInputPort
    {
        readonly IProductRepository _productRepository;
        readonly IUnitOfWork _unitOfWork;
        readonly ICreateProductOuputPort _port;

        public CreateProductInteractor(IProductRepository productRepository, IUnitOfWork unitOfWork,
            ICreateProductOuputPort createProductOuputPort)
        {
            _productRepository = productRepository;
            _unitOfWork = unitOfWork;
            _port = createProductOuputPort;
        }


        public async Task Handle(CreateProductDTO product)
        {
            Product newProduct = new Product
            {
                Name = product.ProductName
            };

            _productRepository.CreateProduct(newProduct);
            await _unitOfWork.SaveChangesAsync();
            await _port.Handle(new ProductDTO
            {
                Id = newProduct.Id,
                Name = newProduct.Name
            });
        }
    }
}
