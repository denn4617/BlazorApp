using EstaldoApp.Models;
using System.Net.Http.Json;

namespace EstaldoApp.Web.Services;

public class AddressService : IAddressService
{
    private readonly HttpClient _httpClient;

    public AddressService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
 
    public async Task<IEnumerable<JsonRootObject>> GetAddressesService(string input, string side)
    {
        return await _httpClient.GetFromJsonAsync<JsonRootObject[]>($"adresser/autocomplete?q={input}&fuzzy=&side={side}&per_side=5");
    }
    public async Task<IEnumerable<JsonRootObject>> GetEveryAddressService(string vejkode, string kommunekode)
    {
        return await _httpClient.GetFromJsonAsync<JsonRootObject[]>($"adresser/autocomplete?vejkode={vejkode}&kommunekode={kommunekode}");
    }
    public async Task<IEnumerable<JsonRootObject>> GetSortedAddressesService(string vejkode, string kommunekode, string side)
    {
        return await _httpClient.GetFromJsonAsync<JsonRootObject[]>($"adresser/autocomplete?vejkode={vejkode}&kommunekode={kommunekode}&side={side}&per_side=5");
    }
}