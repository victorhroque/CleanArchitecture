using CleanArchitecture.DTOs;
using CleanArchitecture.Entities.Interfaces;
using CleanArchitecture.UseCasesPorts;

namespace CleanArchitecture.UseCases.GetAllProducts
{
    internal class GetAllProductsInteractor : IGetAllProductsInputPort
    {
        readonly IProductRepository _productRepository;
        readonly IGetAllProductsOutputPort _port;

        public GetAllProductsInteractor(IProductRepository productRepository, IGetAllProductsOutputPort port)
        {
            _productRepository = productRepository;
            _port = port;
        }

        public Task Handle()
        {
            var produtcs = _productRepository.GetAllProducts().Select(x => new ProductDTO
            {
                Id = x.Id,
                Name = x.Name
            });
            _port.Handle(produtcs);
            return Task.CompletedTask;
        }
    }
}
