using System.Collections.Generic;
using morcom_api.Application.Contracts.Response.Address;
using morcom_api.Application.Contracts.Response.Mail;
using morcom_api.Application.Contracts.Response.Phone;

namespace morcom_api.Application.Contracts.Response.Client
{
    public class ClientAllDataResponse
    {
        public ClientResponse client { get; set; }
        public AddressResponse address{ get; set; }
        public MailResponse mail { get; set; }
        public IEnumerable<PhoneResponse> listRequestPhone { get; set; }
    }
}