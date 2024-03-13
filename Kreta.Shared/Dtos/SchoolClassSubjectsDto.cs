
namespace Kreta.Shared.Dtos
{
    public class SchoolClassSubjectsDto
    {
        public Guid Id { get; set; }
        public Guid SchoolClassId { get; set; }
        public Guid SubjectId { get; set; }
        public int NumberOfHours { get; set; }
        public bool IsTheHoursInOne { get; set; }
    }
}
