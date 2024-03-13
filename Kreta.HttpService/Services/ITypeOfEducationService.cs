using Kreta.Shared.Models;

namespace Kreta.HttpService.Services
{
    public interface ITypeOfEducationService : IBaseService<TypeOfEducation>
    {
        public Task<List<TypeOfEducation>> SelectAllIncludedAsync();
    }
}
