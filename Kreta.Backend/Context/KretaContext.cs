using Kreta.Shared.Models;
using Kreta.Shared.Models.SchoolCitizens;
using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.Context
{
    public class KretaContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<EducationLevel> EducationLevels { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<SchoolClass> SchoolClasses { get; set; }
        public DbSet<TypeOfEducation> TypeOfEducations {  get; set; } 
        public DbSet<SubjectType> SubjectTypes { get; set; }    
        public DbSet<Address> Addresss { get; set; }
        public DbSet<PublicSpace> PublicSpaces { get; set; }
        public KretaContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TypeOfEducation>()
                .HasMany(toe => toe.SchoolClasses)
                .WithOne(sc => sc.TypeOfEducation)
                .HasForeignKey(sc => sc.TypeOfEducationId)
                .IsRequired(false);
        }
    }
}
