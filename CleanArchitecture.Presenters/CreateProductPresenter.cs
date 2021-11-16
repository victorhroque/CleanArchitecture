using CleanArchitecture.DTOs;
using CleanArchitecture.UseCasesPorts;

namespace CleanArchitecture.Presenters
{
    public class CreateProductPresenter : ICreateProductOuputPort, IPresenter<ProductDTO>
    {
        public ProductDTO Content { get; private set; }

        public Task Handle(ProductDTO product)
        {
            Content = product;
            return Task.CompletedTask;
        }
    }
}
