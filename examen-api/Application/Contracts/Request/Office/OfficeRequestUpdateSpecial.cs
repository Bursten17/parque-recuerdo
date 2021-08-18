using System.Collections.Generic;
using morcom_api.Application.Contracts.Request.Address;
using morcom_api.Application.Contracts.Request.Phone;

namespace morcom_api.Application.Contracts.Request.Office
{
    public class OfficeRequestUpdateSpecial
    {
        public OfficeRequest officeRequest { get; set; }
        public AddressRequestUpdate addressRequestUpdate { get; set; }
        public IEnumerable<PhoneRequestUpdate> listRequestPhone { get; set; }
    }
}