using System.Collections.Generic;
using morcom_api.Application.Contracts.Response.Address;
using morcom_api.Application.Contracts.Response.Phone;

namespace morcom_api.Application.Contracts.Response.User
{
    public class UserAllDataResponse
    {
        public UsersResponse user { get; set; }
        public AddressResponse address { get; set; }
        public IEnumerable<PhoneResponse> phone { get; set; }
    }
}