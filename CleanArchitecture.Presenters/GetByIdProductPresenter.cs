using CleanArchitecture.DTOs;
using CleanArchitecture.UseCasesPorts;

namespace CleanArchitecture.Presenters
{
    internal class GetByIdProductPresenter : IGetByIdProductOutputPort, IPresenter<GetByIdProductDTO>
    {
        public GetByIdProductDTO Content { get; private set; }

        public Task Handle(GetByIdProductDTO product)
        {
            Content = product;
            return Task.CompletedTask;
        }
    }
}
