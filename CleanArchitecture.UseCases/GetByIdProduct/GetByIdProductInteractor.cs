using CleanArchitecture.DTOs;
using CleanArchitecture.Entities.Interfaces;
using CleanArchitecture.UseCasesPorts;

namespace CleanArchitecture.UseCases.GetByIdProduct
{
    internal class GetByIdProductInteractor : IGetByIdProductInputPort
    {
        private readonly IProductRepository _productRepository;
        private readonly IGetByIdProductOutputPort _outPort;

        public GetByIdProductInteractor(IProductRepository productRepository, IGetByIdProductOutputPort outPort)
        {
            _productRepository = productRepository;
            _outPort = outPort;
        }

        public Task Handle(int id)
        {
            var product = _productRepository.GetById(id);
            var dto = new GetByIdProductDTO();

            if (product != null)
            {
                dto.Id = product.Id;
                dto.Name = product.Name;
            }

            _outPort.Handle(dto);
            return Task.CompletedTask;
        }
    }
}
