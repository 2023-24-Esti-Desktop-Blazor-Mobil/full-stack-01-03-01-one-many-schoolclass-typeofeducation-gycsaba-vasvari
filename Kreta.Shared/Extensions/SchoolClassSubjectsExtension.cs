using Kreta.Shared.Dtos;
using Kreta.Shared.Models;

namespace Kreta.Shared.Extensions
{
    public static class SchoolClassSubjectsExtension
    {
        public static SchoolClassSubjects ToModel(this SchoolClassSubjectsDto dto)
        {
            return new SchoolClassSubjects
            {
                Id= dto.Id,
                SchoolClassId = dto.SchoolClassId,
                SubjectId = dto.SubjectId,
                NumberOfHours = dto.NumberOfHours,
                IsTheHoursInOne= dto.IsTheHoursInOne,
            };
        }

        public static SchoolClassSubjectsDto ToDto(this SchoolClassSubjects model)
        {
            return new SchoolClassSubjectsDto
            {
                Id = model.Id,
                SchoolClassId = model.SchoolClassId,
                SubjectId = model.SubjectId,
                NumberOfHours = model.NumberOfHours,
                IsTheHoursInOne = model.IsTheHoursInOne,
            };
        }
    }
}
