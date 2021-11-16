using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CleanArchitecture.RepositoryEFCore.DataContext
{
    internal class CleanArchitectureContextFactory : IDesignTimeDbContextFactory<CleanArchitectureContext>
    {
        public CleanArchitectureContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CleanArchitectureContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb; database=CleanArchitecture");
            return new CleanArchitectureContext(optionsBuilder.Options);
        }
    }
}
