using System.Collections.Generic;
using morcom_api.Application.Contracts.Request.Address;
using morcom_api.Application.Contracts.Request.Category;
using morcom_api.Application.Contracts.Request.Mail;
using morcom_api.Application.Contracts.Request.Phone;

namespace morcom_api.Application.Contracts.Request.Supplier
{
    public class SupplierRequestCreateSpecial
    {
        public SupplierRequest supplierRequest { get; set; }
        public AddressRequestCreate addressRequestCreate { get; set; }
        public MailRequestCreate mailRequestCreate { get; set; }
        public IEnumerable<PhoneRequestCreate> listRequestPhone { get; set; }
        public IEnumerable<CategoryRequest> listRequestCategory { get; set; }
    }
}