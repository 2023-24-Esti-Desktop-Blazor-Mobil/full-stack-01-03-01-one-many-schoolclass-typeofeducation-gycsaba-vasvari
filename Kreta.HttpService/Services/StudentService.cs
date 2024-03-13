using Kreta.Shared.Assamblers;
using Kreta.Shared.Dtos;
using Kreta.Shared.Models.SchoolCitizens;

namespace Kreta.HttpService.Services
{
    public class StudentService : BaseService<Student, StudentDto>, IStudentService
    {
        public StudentService(IHttpClientFactory? httpClientFactory, StudentAssambler studentAssambler) : base(httpClientFactory, studentAssambler)
        {
        }
    }
}
