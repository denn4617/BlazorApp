using EstaldoApp.Models;
using EstaldoApp.Web.Services;
using Microsoft.AspNetCore.Components;

namespace EstaldoApp.Web.Pages;

public class AddressListBase : ComponentBase
{
    [Inject] 
    public IAddressService AddressService { get; set; }
    public IEnumerable<JsonRootObject> Adresser { get; set; }
    public IEnumerable<JsonRootObject> SortedAdresser { get; set; }
    public int side { get; set; } = 1;
    protected string inputVal { get; set; }
    protected override async Task OnInitializedAsync()
    {
        Adresser = (await AddressService.GetAddressesService("Hobrovej 42D, 9000 Aalborg", "1")).ToList();
    }

    protected async Task<IEnumerable<JsonRootObject>> GetAdresses(string input, string side)
    {
        return await AddressService.GetAddressesService(input, side);
    }
    protected async Task<IEnumerable<JsonRootObject>> GetEveryAdress(string vejkode, string kommunekode)
    {
        return await AddressService.GetEveryAddressService(vejkode, kommunekode);
    }

    protected async Task<IEnumerable<JsonRootObject>> GetSortedAdresses(string vejkode, string kommunekode, string side)
    {
        //return await AddressService.GetSortedAddressesService(vejkode, kommunekode);
        return await AddressService.GetSortedAddressesService(vejkode, kommunekode, side);
    }
}