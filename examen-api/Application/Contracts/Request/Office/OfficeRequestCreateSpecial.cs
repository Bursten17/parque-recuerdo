using System.Collections.Generic;
using morcom_api.Application.Contracts.Request.Address;
using morcom_api.Application.Contracts.Request.Phone;

namespace morcom_api.Application.Contracts.Request.Office
{
    public class OfficeRequestCreateSpecial
    {
        public OfficeRequest officeRequest { get; set; }
        public AddressRequestCreate addressRequestCreate { get; set; }
        public IEnumerable<PhoneRequestCreate> listRequestPhone { get; set; }
    }
}