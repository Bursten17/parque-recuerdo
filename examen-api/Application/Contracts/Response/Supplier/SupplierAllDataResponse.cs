using System.Collections.Generic;
using morcom_api.Application.Contracts.Response.Address;
using morcom_api.Application.Contracts.Response.Category;
using morcom_api.Application.Contracts.Response.Mail;
using morcom_api.Application.Contracts.Response.Phone;

namespace morcom_api.Application.Contracts.Response.Supplier
{
    public class SupplierAllDataResponse
    {
        public SupplierResponse supplier { get; set; }
        public AddressResponse address{ get; set; }
        public MailResponse mail{ get; set; }
        public IEnumerable<PhoneResponse> listRequestPhone { get; set; }
        public IEnumerable<CategoryResponse> listRequestCategory { get; set; }
    }
}