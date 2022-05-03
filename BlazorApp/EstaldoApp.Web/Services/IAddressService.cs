using EstaldoApp.Models;

namespace EstaldoApp.Web.Services;

public interface IAddressService
{
    //Returns a list of addresses
    Task<IEnumerable<AddressRootObject>> GetAddressesService(string input, string side);
    Task<IEnumerable<AddressRootObject>> GetEveryAddressService(string vejkode, string kommunekode);
    Task<IEnumerable<AddressRootObject>> GetSortedAddressesService(string vejkode, string kommunekode, string side);
    Task<SelectedAddressRootObject> GetAddressInformationService(string id);
}