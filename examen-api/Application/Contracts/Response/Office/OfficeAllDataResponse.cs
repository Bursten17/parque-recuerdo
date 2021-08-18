using System.Collections.Generic;
using morcom_api.Application.Contracts.Response.Address;
using morcom_api.Application.Contracts.Response.Phone;

namespace morcom_api.Application.Contracts.Response.Office
{
    public class OfficeAllDataResponse
    {
        public OfficeResponse office { get; set; }
        public AddressResponse address { get; set; }
        public IEnumerable<PhoneResponse> listRequestPhone { get; set; }
    }
}