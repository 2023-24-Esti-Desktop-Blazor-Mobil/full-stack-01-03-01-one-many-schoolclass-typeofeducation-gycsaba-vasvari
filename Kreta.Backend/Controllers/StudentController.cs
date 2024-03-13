using Kreta.Backend.Repos;
using Kreta.Shared.Assamblers;
using Kreta.Shared.Dtos;
using Kreta.Shared.Models.SchoolCitizens;
using Microsoft.AspNetCore.Mvc;

namespace Kreta.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : BaseController<Student, StudentDto>
    {
        public StudentController(StudentAssambler? assambler, IStudentRepo? repo) : base(assambler, repo)
        {
        }
    }
}
