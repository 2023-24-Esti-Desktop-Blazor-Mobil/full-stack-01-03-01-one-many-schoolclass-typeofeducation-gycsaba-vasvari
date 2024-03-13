using Kreta.Shared.Models;
using Kreta.Shared.Models.SchoolCitizens;
using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.Repos
{
    public class EducationLevelRepo<TDbContext> : RepositoryBase<TDbContext, EducationLevel>, IEducationLevelRepo
        where TDbContext : DbContext
    {
        public EducationLevelRepo(IDbContextFactory<TDbContext> dbContextFactory) : base(dbContextFactory)
        {
        }

    }
}
