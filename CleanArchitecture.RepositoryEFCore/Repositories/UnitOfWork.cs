using CleanArchitecture.Entities.Interfaces;
using CleanArchitecture.RepositoryEFCore.DataContext;

namespace CleanArchitecture.RepositoryEFCore.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly CleanArchitectureContext Context;

        public UnitOfWork(CleanArchitectureContext context) => Context = context;

        public async Task<int> SaveChangesAsync()
        {
            return await Context.SaveChangesAsync();
        }
    }
}
