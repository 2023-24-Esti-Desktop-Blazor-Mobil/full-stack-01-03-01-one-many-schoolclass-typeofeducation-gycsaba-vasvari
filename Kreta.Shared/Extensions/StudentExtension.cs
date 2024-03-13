using Kreta.Shared.Dtos;
using Kreta.Shared.Models.SchoolCitizens;

namespace Kreta.Shared.Extensions
{
    public static class StudentExtension
    {
        public static StudentDto ToDto(this Student student)
        {
            return new StudentDto
            {
                Id = student.Id,
                EducationLevelId = student.EducationLevelId,
                SchoolClassID = student.SchoolClassID,
                MotherId = student.MotherId,
                FatherId = student.FatherId,
                AddressId = student.AddressId,
                FirstName = student.FirstName,
                LastName = student.LastName,
                BirthDay = student.BirthDay,
                PlaceOfBirth = student.PlaceOfBirth,    
                IsWoman = student.IsWoman,
            };
        }

        public static Student ToModel(this StudentDto studentdto)
        {
            return new Student
            {
                Id = studentdto.Id,
                EducationLevelId = studentdto.EducationLevelId,
                SchoolClassID=studentdto.SchoolClassID,
                MotherId=studentdto.MotherId,
                FatherId=studentdto.FatherId,
                AddressId = studentdto.AddressId,
                FirstName = studentdto.FirstName,
                LastName = studentdto.LastName,
                BirthDay = studentdto.BirthDay,
                PlaceOfBirth=studentdto.PlaceOfBirth,
                IsWoman=studentdto.IsWoman,

            };
        }
    }

}
