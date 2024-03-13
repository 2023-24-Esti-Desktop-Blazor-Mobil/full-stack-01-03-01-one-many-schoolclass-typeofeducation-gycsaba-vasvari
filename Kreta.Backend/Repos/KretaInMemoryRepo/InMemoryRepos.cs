using Kreta.Backend.Context;
using Kreta.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.Repos.KretaInMemoryRepo
{
    public class StudentInMemoryRepo : StudentRepo<KretaInMemoryContext>
    {
        public StudentInMemoryRepo(IDbContextFactory<KretaInMemoryContext> dbContextFactory) : base(dbContextFactory)
        {
        }
    }
    public class GradeInMemoryRepo : GradeRepo<KretaInMemoryContext>
    {
        public GradeInMemoryRepo(IDbContextFactory<KretaInMemoryContext> dbContextFactory) : base(dbContextFactory)
        {
        }
    }

    public class ParentInMemoryRepo : ParentRepo<KretaInMemoryContext>
    {
        public ParentInMemoryRepo(IDbContextFactory<KretaInMemoryContext> dbContextFactory) : base(dbContextFactory)
        {
        }
    }

    public class SubjectInMemoryRepo : SubjectRepo<KretaInMemoryContext>
    {
        public SubjectInMemoryRepo(IDbContextFactory<KretaInMemoryContext> dbContextFactory) : base(dbContextFactory)
        {
        }
    }

    public class TeacherInMemoryRepo : TeacherRepo<KretaInMemoryContext>
    {
        public TeacherInMemoryRepo(IDbContextFactory<KretaInMemoryContext> dbContextFactory) : base(dbContextFactory)
        {
        }
    }

    public class EducationLevelInMemoryRepo : EducationLevelRepo<KretaInMemoryContext>
    {
        public EducationLevelInMemoryRepo(IDbContextFactory<KretaInMemoryContext> dbContextFactory) : base(dbContextFactory)
        {
        }
    }

    public class AddressInMemoryRepo : AddressRepo<KretaInMemoryContext>
    {
        public AddressInMemoryRepo(IDbContextFactory<KretaInMemoryContext> dbContextFactory) : base(dbContextFactory)
        {
        }
    }

    public class PublicScpaceInMemoryRepo : PublicSpaceRepo<KretaInMemoryContext>
    {
        public PublicScpaceInMemoryRepo(IDbContextFactory<KretaInMemoryContext> dbContextFactory) : base(dbContextFactory)
        {
        }
    }

    public class SchoolClassInMemoryRepo : SchoolClassRepo<KretaInMemoryContext>
    {
        public SchoolClassInMemoryRepo(IDbContextFactory<KretaInMemoryContext> dbContextFactory) : base(dbContextFactory)
        {
        }
    }


    public class TypeOfEducationInMemoryRepo : TypeOfEducationRepo<KretaInMemoryContext>
    {
        public TypeOfEducationInMemoryRepo(IDbContextFactory<KretaInMemoryContext> dbContextFactory) : base(dbContextFactory)
        {
        }
    }
}
