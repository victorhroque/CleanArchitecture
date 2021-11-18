using CleanArchitecture.DTOs;

namespace CleanArchitecture.UseCasesPorts
{
    public interface IGetByIdProductOutputPort
    {
        Task Handle(GetByIdProductDTO product);
    }
}
