using EstaldoApp.Models;
using EstaldoApp.Web.Services;
using Microsoft.AspNetCore.Components;

namespace EstaldoApp.Web.Pages;

public class AddressListBase : ComponentBase
{
    [Inject] 
    public IAddressService AddressService { get; set; }
    public IEnumerable<Root> Adresser { get; set; }

    protected string inputVal { get; set; }
    protected override async Task OnInitializedAsync()
    {
        Adresser = (await AddressService.GetAddressService("Hobrovej 42D, 9000 Aalborg")).ToList();
        Console.WriteLine("ADDRESS:" + Adresser.Count());
    }

    protected async Task<IEnumerable<Root>> GetAdresses(string input)
    {
        return await AddressService.GetAddressService(input);
    }

}