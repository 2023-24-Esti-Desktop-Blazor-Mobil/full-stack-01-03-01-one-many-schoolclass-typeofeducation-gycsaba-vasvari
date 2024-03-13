using Kreta.Shared.Assamblers;
using Kreta.Shared.Dtos;
using Kreta.Shared.Models;
using System.Diagnostics;
using System.Net.Http.Json;

namespace Kreta.HttpService.Services
{
    public class SchoolClassService : BaseService<SchoolClass, SchoolClassDto>, ISchoolClassService
    {
        public SchoolClassService(IHttpClientFactory? httpClientFactory, SchoolClassAssambler assambler) : base(httpClientFactory, assambler)
        {
        }

        public async Task<List<SchoolClass>> SelectAllIncludedAsync()
        {
            if (_httpClient is not null)
            {
                try
                {
                    List<SchoolClassDto>? resultDto = await _httpClient.GetFromJsonAsync<List<SchoolClassDto>>($"api/SchoolClass/included");
                    if (resultDto is not null)
                    {
                        List<SchoolClass> result = resultDto.Select(entity => _assambler.ToModel(entity)).ToList();
                        return result;
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
            return new List<SchoolClass>();
        }
    }
}
