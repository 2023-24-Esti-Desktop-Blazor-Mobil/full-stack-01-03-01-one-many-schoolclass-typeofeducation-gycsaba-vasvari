namespace Kreta.Shared.Models
{
    public class SchoolClassSubjects : IDbEntity<SchoolClassSubjects>
    {
        public SchoolClassSubjects()
        {
            Id = Guid.Empty;
            SchoolClassId = Guid.Empty;
            SubjectId = Guid.Empty;
            NumberOfHours = -1;
            IsTheHoursInOne = false;
        }

        public SchoolClassSubjects(Guid id, Guid schoolClassId, Guid subjectId, int numberOfHours, bool theHoursInOne)
        {
            Id = id;
            SchoolClassId = schoolClassId;
            SubjectId = subjectId;
            NumberOfHours = numberOfHours;
            IsTheHoursInOne = theHoursInOne;
        }

        public Guid Id { get; set; }
        public Guid SchoolClassId { get; set; }
        public Guid SubjectId { get; set; }
        public int NumberOfHours { get; set; }
        public bool IsTheHoursInOne { get; set; }
        public bool HasId => Id != Guid.Empty;
    }
}
