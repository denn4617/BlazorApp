using EstaldoApp.Models;
using EstaldoApp.Web.Services;
using Microsoft.AspNetCore.Components;

namespace EstaldoApp.Web.Pages;

public class AddressListBase : ComponentBase
{
    [Inject] 
    public IAddressService AddressService { get; set; }
    public IEnumerable<Root> Adresser { get; set; }

    protected override async Task OnInitializedAsync()
    {
        Adresser = (await AddressService.GetAddresses()).ToList();
        Console.WriteLine("ADDRESS:" + Adresser.Count());
    }
    
}