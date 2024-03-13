namespace Kreta.Shared.Dtos
{
    public class StudentDto
    {
        public Guid Id { get; set; }
        public Guid? EducationLevelId { get; set; }
        public Guid? SchoolClassID { get; set; }
        public Guid? MotherId { get; set; }
        public Guid? FatherId { get; set; }
        public Guid? AddressId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime BirthDay { get; set; }
        public string PlaceOfBirth { get; set; } = string.Empty;
        public bool IsWoman { get; set; }
    }
}
