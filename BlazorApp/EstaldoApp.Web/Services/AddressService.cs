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
    public async Task<IEnumerable<Root>> GetAddresses()
    {
        return await _httpClient.GetFromJsonAsync<Root[]>("adresser/autocomplete");
    }
}