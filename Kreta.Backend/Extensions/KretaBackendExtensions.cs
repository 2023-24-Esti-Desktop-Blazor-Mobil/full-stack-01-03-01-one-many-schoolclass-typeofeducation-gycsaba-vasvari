using Kreta.Backend.Context;
using Kreta.Backend.Repos;
using Kreta.Backend.Repos.KretaInMemoryRepo;
using Kreta.Shared.Assamblers;
using Kreta.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.Extensions
{
    public static class KretaBackendExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {

            services.AddCors(option =>
                 option.AddPolicy(name: "KretaCors",
                     policy =>
                     {
                         policy.WithOrigins("https://localhost:7020/")
                         .AllowAnyHeader()
                         .AllowAnyMethod();
                     }
                 )
            );
        }

        public static void ConfigureInMemoryContext(this IServiceCollection services)
        {
            string dbName = "Kreta" + Guid.NewGuid();
            /*services.AddDbContextFactory<KretaContext>(
                options => options.UseInMemoryDatabase(databaseName: dbName)
                );*/
            services.AddDbContextFactory<KretaInMemoryContext>(
                options => options.UseInMemoryDatabase(databaseName: dbName)
                );
        }

        public static void ConfigureRepoService(this IServiceCollection services)
        {
            services.AddScoped<IStudentRepo, StudentInMemoryRepo>();
            services.AddScoped<IGradeRepo, GradeInMemoryRepo>();
            services.AddScoped<IParentRepo, ParentInMemoryRepo>();
            services.AddScoped<ITeacherRepo, TeacherInMemoryRepo>();
            services.AddScoped<ISubjectRepo, SubjectInMemoryRepo>();
            services.AddScoped<ISubjectRepo, SubjectInMemoryRepo>();
            services.AddScoped<IEducationLevelRepo, EducationLevelInMemoryRepo>();
            services.AddScoped<IAddressRepo, AddressInMemoryRepo>();
            services.AddScoped<IPublicSpaceRepo,PublicScpaceInMemoryRepo>();
            services.AddScoped<ISchoolClassRepo, SchoolClassInMemoryRepo>();
            services.AddScoped<ITypeOfEducationRepo, TypeOfEducationInMemoryRepo>();
        }

        public static void ConfigureAssamblers(this IServiceCollection services)
        {
            services.AddScoped<TeacherAssambler>();
            services.AddScoped<GradeAssambler>();
            services.AddScoped<ParentAssambler>();
            services.AddScoped<StudentAssambler>();
            services.AddScoped<SubjectAssambler>();
            services.AddScoped<EducationLevelAssambler>();
            services.AddScoped<SchoolClassAssambler>();
            services.AddScoped<AddressAssambler>();
            services.AddScoped<PublicSpaceAssambler>();
            services.AddScoped<SchoolClassAssambler>();
            services.AddScoped<TypeOfEducationAssambler>();
        }
    }
}
