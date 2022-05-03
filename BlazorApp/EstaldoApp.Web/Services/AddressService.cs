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
 
    public async Task<IEnumerable<AddressRootObject>> GetAddressesService(string input, string side)
    {
        return await _httpClient.GetFromJsonAsync<AddressRootObject[]>($"adresser/autocomplete?q={input}&fuzzy=&side={side}&per_side=5");
    }
    public async Task<IEnumerable<AddressRootObject>> GetEveryAddressService(string vejkode, string kommunekode)
    {
        return await _httpClient.GetFromJsonAsync<AddressRootObject[]>($"adresser/autocomplete?vejkode={vejkode}&kommunekode={kommunekode}");
    }
    public async Task<IEnumerable<AddressRootObject>> GetSortedAddressesService(string vejkode, string kommunekode, string side)
    {
        return await _httpClient.GetFromJsonAsync<AddressRootObject[]>($"adresser/autocomplete?vejkode={vejkode}&kommunekode={kommunekode}&side={side}&per_side=5");
    }

    public async Task<IEnumerable<SelectedAddressRootObject>> GetAddressInformationService(string id)
    {
        return await _httpClient.GetFromJsonAsync<SelectedAddressRootObject[]>($"https://api.dataforsyningen.dk/adresser?id={id}");
    }
}