namespace CleanArchitecture.UseCasesPorts
{
    public interface IGetByIdProductInputPort
    {
        Task Handle(int id);
    }
}
