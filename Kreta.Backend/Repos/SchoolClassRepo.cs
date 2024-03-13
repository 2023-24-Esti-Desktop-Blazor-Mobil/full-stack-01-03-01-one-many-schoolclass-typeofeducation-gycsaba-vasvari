using Kreta.Backend.Context;
using Kreta.Shared.Models;
using Kreta.Shared.Models.SchoolCitizens;
using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.Repos
{
    public class SchoolClassRepo<TDbContext> : RepositoryBase<TDbContext, SchoolClass>, ISchoolClassRepo
        where TDbContext : DbContext
    {
        public SchoolClassRepo(IDbContextFactory<TDbContext> dbContextFactory) : base(dbContextFactory)
        {
        }

        public IQueryable<SchoolClass> SelectAllIncluded()
        {
            return FindAll().Include(schoolClass => schoolClass.TypeOfEducation);
        }
    }
}
