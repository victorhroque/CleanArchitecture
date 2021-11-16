using CleanArchitecture.DTOs;

namespace CleanArchitecture.UseCasesPorts
{
    public interface ICreateProductOuputPort
    {
        Task Handle(ProductDTO product);
    }
}
