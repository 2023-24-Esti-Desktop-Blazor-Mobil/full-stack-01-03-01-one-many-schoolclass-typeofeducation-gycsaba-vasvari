using Kreta.Backend.Repos;
using Kreta.Shared.Assamblers;
using Kreta.Shared.Dtos;
using Kreta.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kreta.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EducationLevelController : BaseController<EducationLevel, EducationLevelDto>
    {
        public EducationLevelController(EducationLevelAssambler? assambler, IEducationLevelRepo? repo) : base(assambler, repo)
        {
        }
    }
}
