using EstaldoApp.Models;

namespace EstaldoApp.Web.Services;

public interface IAddressService
{
    //Returns a list of addresses
    Task<IEnumerable<JsonRootObject>> GetAddressesService(string input, string side);
    Task<IEnumerable<JsonRootObject>> GetEveryAddressService(string vejkode, string kommunekode);
    Task<IEnumerable<JsonRootObject>> GetSortedAddressesService(string vejkode, string kommunekode, string side);
    //Task<IEnumerable<JsonRootObject>> GetSortedAddressesService(string vejkode, string kommunekode);
}