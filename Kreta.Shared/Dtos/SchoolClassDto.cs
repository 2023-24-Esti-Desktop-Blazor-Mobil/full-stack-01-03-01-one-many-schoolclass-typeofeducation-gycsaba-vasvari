using Kreta.Shared.Models;

namespace Kreta.Shared.Dtos
{
    public class SchoolClassDto
    {
        public Guid Id { get; set; }
        public bool HasId => Id != Guid.Empty;
        public int SchoolYear { get; set; }
        public SchoolClassType SchoolClassType { get; set; }
        public Guid? TypeOfEducationId { get; set; }
        public virtual TypeOfEducation? TypeOfEducation { get; set; }
        public Guid? HeadTeacherId { get; set; }
        public int YearOfEnrolment { get; set; }
        public bool IsArchived { get; set; }
    }
}
