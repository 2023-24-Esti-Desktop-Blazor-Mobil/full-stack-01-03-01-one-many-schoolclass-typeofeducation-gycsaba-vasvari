using Kreta.Shared.Assamblers;
using Kreta.Shared.Dtos;
using Kreta.Shared.Models;
using System.Diagnostics;
using System.Net.Http.Json;

namespace Kreta.HttpService.Services
{
    public class TypleOfEducationService : BaseService<TypeOfEducation, TypeOfEducationDto>, ITypeOfEducationService
    {
        public TypleOfEducationService(IHttpClientFactory? httpClientFactory, TypeOfEducationAssambler assambler) : base(httpClientFactory, assambler)
        {
        }

        public async Task<List<TypeOfEducation>> SelectAllIncludedAsync()
        {
            if (_httpClient is not null)
            {
                try
                {

                    List<TypeOfEducationDto>? resultDto = await _httpClient.GetFromJsonAsync<List<TypeOfEducationDto>>($"api/TypeOfEducation/included");
                    if (resultDto is not null)
                    {
                        List<TypeOfEducation> result = resultDto.Select(entity => _assambler.ToModel(entity)).ToList();
                        return result;
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
            return new List<TypeOfEducation>();
        }
    }
}
