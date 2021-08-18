using System.Collections.Generic;
using morcom_api.Application.Contracts.Request.Address;
using morcom_api.Application.Contracts.Request.Category;
using morcom_api.Application.Contracts.Request.Mail;
using morcom_api.Application.Contracts.Request.Phone;

namespace morcom_api.Application.Contracts.Request.Supplier
{
    public class SupplierRequestUpdateSpecial
    {
        public SupplierRequest supplierRequest { get; set; }
        public AddressRequestUpdate addressRequestUpdate { get; set; }
        public MailRequestUpdate mailRequestUpdate { get; set; }
        public IEnumerable<PhoneRequestUpdate> listRequestPhone { get; set; }
        public IEnumerable<CategoryRequestUpdate> listRequestCategory { get; set; }
    }
}