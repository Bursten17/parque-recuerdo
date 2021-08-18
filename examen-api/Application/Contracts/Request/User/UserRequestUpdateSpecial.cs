using System.Collections.Generic;
using morcom_api.Application.Contracts.Request.Address;
using morcom_api.Application.Contracts.Request.Phone;

namespace morcom_api.Application.Contracts.Request.User
{
    public class UserRequestUpdateSpecial
    {
        public UserRequest user { get; set; }
        public AddressRequestUpdate addressRequestUpdate { get; set; }
        public IEnumerable<UserOfficeRequestUpdate> a_offices { get; set; }
        public IEnumerable<PhoneRequestUpdate> listRequestPhone { get; set; }
    }
}