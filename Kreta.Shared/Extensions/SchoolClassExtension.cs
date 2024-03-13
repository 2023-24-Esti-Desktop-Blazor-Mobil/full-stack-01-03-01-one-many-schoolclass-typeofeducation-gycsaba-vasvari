using Kreta.Shared.Dtos;
using Kreta.Shared.Models;

namespace Kreta.Shared.Extensions
{
    public static class SchoolClassExtension
    {
        public static SchoolClass ToModel(this SchoolClassDto dto)
        {
            return new SchoolClass
            {
                Id = dto.Id,
                SchoolYear = dto.SchoolYear,
                SchoolClassType = dto.SchoolClassType,
                YearOfEnrolment= dto.YearOfEnrolment,
                IsArchived = dto.IsArchived,
                HeadTeacherId = dto.HeadTeacherId,
                TypeOfEducationId = dto.TypeOfEducationId,
                TypeOfEducation = dto.TypeOfEducation,
            };
        }

        public static SchoolClassDto ToDto(this SchoolClass model)
        {
            return new SchoolClassDto
            {
                Id = model.Id,
                SchoolYear = model.SchoolYear,
                SchoolClassType = model.SchoolClassType,
                YearOfEnrolment = model.YearOfEnrolment,
                IsArchived = model.IsArchived,
                HeadTeacherId=model.HeadTeacherId,
                TypeOfEducationId = model.TypeOfEducationId,
                TypeOfEducation = model.TypeOfEducation,
            };
        }
    }
}
