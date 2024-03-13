using Kreta.Shared.Assamblers;
using Kreta.Shared.Dtos;
using Kreta.Shared.Models;

namespace Kreta.HttpService.Services
{
    public class SubjectService : BaseService<Subject, SubjectDto>, ISubjectService
    {
        public SubjectService(IHttpClientFactory? httpClientFactory, SubjectAssambler assambler) : base(httpClientFactory, assambler)
        {
        }
    }
}
