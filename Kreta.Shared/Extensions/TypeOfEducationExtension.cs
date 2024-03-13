using Kreta.Shared.Dtos;
using Kreta.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreta.Shared.Extensions
{
    public static class TypeOfEducationExtension
    {
        public static TypeOfEducation ToModel(this TypeOfEducationDto dto)
        {
            return new TypeOfEducation
            {
                Id = dto.Id,
                EducationName = dto.EducationName,
                SchoolClasses = dto.SchoolClasses,
            };
        }

        public static TypeOfEducationDto ToDto(this TypeOfEducation model)
        {
            return new TypeOfEducationDto
            {
                Id = model.Id,
                EducationName = model.EducationName,
                SchoolClasses = model.SchoolClasses,
            };
        }
    }
}
