using Kreta.Shared.Models;
using Kreta.Shared.Models.SchoolCitizens;
using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.Context
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            Guid publicSpaceId1 = Guid.NewGuid();
            Guid publicSpaceId2 = Guid.NewGuid();
            Guid publicSpaceId3 = Guid.NewGuid();

            List<PublicSpace> publicSpaces = new List<PublicSpace>()
            {
                new PublicSpace()
                {
                    Id = publicSpaceId1,
                    NameOfPublicSpace="utca",
                },
                new PublicSpace()
                {
                    Id = publicSpaceId2,
                    NameOfPublicSpace="tér",
                },
                new PublicSpace()
                {
                    Id = publicSpaceId3,
                    NameOfPublicSpace="sugárút",
                },
            };

            Guid addressId1= Guid.NewGuid();
            Guid addressId2 = Guid.NewGuid();
            Guid addressId3 = Guid.NewGuid();
            List<Address> addresses = new List<Address> 
            { 
                new Address
                {
                    Id = addressId1,
                    City="Szeged",
                    PublicSpaceName="Szentháromság",
                    House=10,
                    PostalCode=6722,    
                    PublicScapeID=publicSpaceId1,
                },
                new Address
                {
                    Id = addressId2,
                    City="Szeged",
                    PublicSpaceName="Kossuth Lajos",
                    House=85,
                    PostalCode=6724,
                    PublicScapeID=publicSpaceId3,
                },
                new Address
                {
                    Id = addressId3,
                    City="Szeged",
                    PublicSpaceName="Boldogasszony",
                    House=85,
                    PostalCode=6722,
                    PublicScapeID=publicSpaceId3,
                },

            };

            Guid typeOfSubject1 = Guid.NewGuid();
            Guid typeOfSubject2 = Guid.NewGuid();
            Guid typeOfSubject3 = Guid.NewGuid();

            List<SubjectType> subjectTypes = new List<SubjectType>
            {
                new SubjectType
                {
                    Id = typeOfSubject1,
                    SubjectTypeName="Természettudomány",                   
                },
                new SubjectType
                {
                    Id = typeOfSubject2,
                    SubjectTypeName="Idegen nyelv",
                },
                new SubjectType
                {
                    Id = typeOfSubject3,
                    SubjectTypeName="Közgazdaságtan",
                },
            };

            Guid subjectId1 = Guid.NewGuid();
            Guid subjectId2 = Guid.NewGuid();
            Guid subjectId3 = Guid.NewGuid();

            List<Subject> subjects = new List<Subject>
            {
                new Subject
                {
                    Id=subjectId1,
                    SubjectName="Földrajz",
                    ShortName="Föci",
                    SubjectTypeId=typeOfSubject1,
                    CompulsoryExaminationSubject=false,
                    OptionalExaminationSubject=true,
                },
                new Subject
                {
                    Id=subjectId2,
                    SubjectName="Angol",
                    ShortName="Angol",
                    SubjectTypeId=typeOfSubject2,
                    CompulsoryExaminationSubject=true,
                    OptionalExaminationSubject=false,
                },
                new Subject
                {
                    Id=subjectId3,
                    SubjectName="Marketing",
                    ShortName="Market",
                    SubjectTypeId=typeOfSubject3,
                    CompulsoryExaminationSubject=false,
                    OptionalExaminationSubject=false,
                }
            };

            Guid typeOfEducation1= Guid.NewGuid();
            Guid typeOfEducation2 = Guid.NewGuid();
            Guid typeOfEducation3 = Guid.NewGuid();

            List<TypeOfEducation> typeOfEducations= new ()
            {
                new TypeOfEducation
                {
                    Id = typeOfEducation1,
                    EducationName="Szoftverfejlesztő és -tesztelő"
                },
                new TypeOfEducation 
                { 
                    Id = typeOfEducation2,
                    EducationName="Idegen nyelvű ipari és kereskedelmi technikus"
                },
                new TypeOfEducation
                {
                    Id = typeOfEducation3,
                    EducationName="Vállalkozási ügyviteli ügyintéző"
                }
            };

            Guid EducationLevelId1 = Guid.NewGuid();
            Guid EducationLevelId2 = Guid.NewGuid();
            List<EducationLevel> educationLevels = new()
            {
                new EducationLevel
                {
                    Id=EducationLevelId1,
                    StudentEducationLevel="érettségi",
                    DurationOfEducation=4,                   
                },
                new EducationLevel
                {
                    Id=EducationLevelId2,
                    StudentEducationLevel="szakképzés",
                    DurationOfEducation=2,
                }
            };
            
            Guid parentId1=Guid.NewGuid();
            Guid parentId2 = Guid.NewGuid();
            Guid parentId3 = Guid.NewGuid();
            Guid parentId4 = Guid.NewGuid();
            Guid parentId5 = Guid.NewGuid();
            Guid parentId6 = Guid.NewGuid();
            List<Parent> parents = new()
            {
                new Parent
                {
                    Id=parentId1,
                    FirstName="Virág",
                    LastName="Vas",
                    IsWoman=true,
                    BirthDay=new DateTime(1998,8,8),
                    PlaceOfBirth="Szeged",
                    MathersName="Érc Kitti",
                },
                new Parent
                {
                    Id=parentId2,
                    FirstName="Petra",
                    LastName="Pénzes",
                    IsWoman=true,
                    BirthDay=new DateTime(1997,7,7),
                    PlaceOfBirth="Kistelek",
                    MathersName="Szegény Szandi",

                },
                new Parent
                {
                    Id=parentId3,
                    FirstName="Ferenc",
                    LastName="Fukar",
                    IsWoman=false,
                    BirthDay=new DateTime(1995,5,5),
                    PlaceOfBirth="Szeged",
                    MathersName="Adakozó Andor",

                },
                new Parent
                {
                    Id=parentId4,
                    FirstName="Fruzsi",
                    LastName="Fukar",
                    IsWoman=true,
                    BirthDay=new DateTime(1994,4,4),
                    PlaceOfBirth="Makó",
                    MathersName="Adó Anna",

                },
                new Parent
                {
                    Id=parentId5,
                    FirstName="Hedvig",
                    LastName="Hosszú",
                    IsWoman=true,
                    BirthDay=new DateTime(1992,2,2),
                    PlaceOfBirth="Szeged",
                    MathersName="Alacsony Anikó",

                },
                new Parent
                {
                    Id=parentId6,
                    FirstName="Milán",
                    LastName="Magas",
                    IsWoman=false,
                    BirthDay=new DateTime(1992,2,2),
                    PlaceOfBirth="Deszk",
                    MathersName="Alacsony Anikó",

                }
            };


            List<Student> students = new()
            {
                new Student
                {
                    Id=Guid.NewGuid(),
                    FirstName="János",
                    LastName="Jegy",
                    IsWoman=false,
                    BirthDay=new DateTime(2022,10,10),
                    PlaceOfBirth="Szeged",
                    EducationLevelId=EducationLevelId1,
                    MotherId=parentId2,
                    AddressId=addressId1,
                },
                new Student
                {
                    Id=Guid.NewGuid(),
                    FirstName="Nóra",
                    LastName="Nagy",
                    IsWoman=true,
                    BirthDay=new DateTime(2021,4,4),
                    PlaceOfBirth="Kiskunhalas",
                    EducationLevelId=EducationLevelId2,
                },
                new Student
                {
                    Id=Guid.NewGuid(),
                    FirstName="Valér",
                    LastName="Vas",
                    IsWoman=false,
                    BirthDay=new DateTime(2022,7,7),
                    PlaceOfBirth="Makó",
                    EducationLevelId=EducationLevelId1,
                },
                new Student
                {
                    Id=Guid.NewGuid(),
                    FirstName="Márta",
                    LastName="Kis",
                    PlaceOfBirth="Szabadka",
                    IsWoman=true,
                    BirthDay=new DateTime(2019,9,9),
                    EducationLevelId=EducationLevelId1,
                },
                new Student
                {
                    Id=Guid.NewGuid(),
                    FirstName="Milán",
                    LastName="Magas",
                    IsWoman=false,
                    BirthDay=new DateTime(2017,7,7),
                    PlaceOfBirth="Apátfalva",
                    EducationLevelId=EducationLevelId2,
                    MotherId=parentId1,                    

                },
                new Student
                {
                    Id=Guid.NewGuid(),
                    FirstName="Fruzsina",
                    LastName="Fukar",
                    IsWoman=false,
                    BirthDay=new DateTime(2019,9,9),
                    PlaceOfBirth="Miskolc",
                    EducationLevelId=EducationLevelId2,
                    MotherId=parentId4,
                    FatherId=parentId3,
                },
                new Student
                {
                    Id=Guid.NewGuid(),
                    FirstName="Kinga",
                    LastName="Kilógó",
                    IsWoman=false,
                    BirthDay=new DateTime(2019,9,9),
                    PlaceOfBirth="Miskolc",
                    EducationLevelId=Guid.Empty,
                    MotherId=parentId4,
                    FatherId=parentId3,
                }
            };
            Guid teacherId1= Guid.NewGuid();
            Guid teacherId2 = Guid.NewGuid();
            Guid teacherId3 = Guid.NewGuid();
            Guid teacherId4 = Guid.NewGuid();
            Guid teacherId5 = Guid.NewGuid();
            List<Teacher> teachers = new()
            {
                new Teacher
                {
                    Id=teacherId1,
                    FirstName="Martin",
                    LastName="Magyar",
                    BirthDay=new DateTime(2000,10,10),
                    IsHeadTeacher=false,
                    PlaceOfBirth="Miskolc",
                    IsWoman=false,
                    MathersName="Miskolci Mária"
                },
                new Teacher
                {
                    Id=teacherId2,
                    FirstName="Mirjam",
                    LastName="Metek",
                    BirthDay=new DateTime(2000,11,11),
                    IsHeadTeacher=true,
                    PlaceOfBirth="Eger",
                    IsWoman=true,
                    MathersName="Egri Etelka"

                },
                new Teacher
                {
                    Id=teacherId3,
                    FirstName="Feri",
                    LastName="Földrajz",
                    BirthDay=new DateTime(2000,12,12),
                    IsHeadTeacher=true,
                    PlaceOfBirth="Szabadka",
                    IsWoman=false,
                    MathersName="Szabadkai Szabina"

                },
                new Teacher
                {
                    Id=teacherId4,
                    FirstName="Éva",
                    LastName="Ének",
                    BirthDay=new DateTime(2000,1,1),
                    IsHeadTeacher=false,
                    PlaceOfBirth="Baja",
                    IsWoman=true,
                    MathersName="Bajai Betti"
                },
                new Teacher
                {
                    Id=teacherId5,
                    FirstName="Adorján",
                    LastName="Angol",
                    BirthDay=new DateTime(2000,3,3),
                    IsHeadTeacher=false,
                    PlaceOfBirth="Kecskemét",
                    IsWoman=false,
                    MathersName="Kecskeméti Kati"
                }
            };

            Guid schoolClassId1 = Guid.NewGuid();
            Guid schoolClassId2 = Guid.NewGuid();
            Guid schoolClassId3 = Guid.NewGuid();
            List<SchoolClass> schoolClasses = new List<SchoolClass>
            {
                new SchoolClass
                {
                    Id=schoolClassId1,
                    SchoolYear=9,
                    SchoolClassType=SchoolClassType.ClassA,
                    YearOfEnrolment=2025,
                    IsArchived=false,
                    TypeOfEducationId=typeOfEducation1,
                    HeadTeacherId=teacherId2,
                },
                new SchoolClass
                {
                    Id=schoolClassId2,
                    SchoolYear=10,
                    SchoolClassType=SchoolClassType.ClassB,
                    YearOfEnrolment=2024,
                    IsArchived=false,
                    TypeOfEducationId=typeOfEducation2,
                },
                new SchoolClass
                {
                    Id=schoolClassId3,
                    SchoolYear=14,
                    SchoolClassType=SchoolClassType.ClassB,
                    YearOfEnrolment=2024,
                    IsArchived=false,
                    TypeOfEducationId=typeOfEducation3,
                },
            };

            modelBuilder.Entity<EducationLevel>().HasData(educationLevels);
            modelBuilder.Entity<TypeOfEducation>().HasData(typeOfEducations);
            modelBuilder.Entity<SubjectType>().HasData(subjectTypes);
            modelBuilder.Entity<Address>().HasData(addresses);

            modelBuilder.Entity<Student>().HasData(students);
            modelBuilder.Entity<Teacher>().HasData(teachers);
            modelBuilder.Entity<Parent>().HasData(parents);
            modelBuilder.Entity<SchoolClass>().HasData(schoolClasses);
            modelBuilder.Entity<Subject>().HasData(subjects);
            modelBuilder.Entity<PublicSpace>().HasData(publicSpaces); 
        }
    }
}
