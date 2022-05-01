using EstaldoApp.Models;

namespace EstaldoApp.Web.Services;

public interface IAddressService
{
    //Returns a list of addresses
    Task<IEnumerable<JsonRootObject>> GetAddressService(string input);
}