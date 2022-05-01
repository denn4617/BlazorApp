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
    public async Task<IEnumerable<JsonRootObject>> GetAddressService(string input)
    {
        //Generation of query from user input
        return await _httpClient.GetFromJsonAsync<JsonRootObject[]>($"adresser/autocomplete?q={input}&fuzzy=");
    }
}