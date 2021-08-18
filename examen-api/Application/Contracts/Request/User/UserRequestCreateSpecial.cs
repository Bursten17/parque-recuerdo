using System;
using System.Collections.Generic;
using morcom_api.Application.Contracts.Request.Address;
using morcom_api.Application.Contracts.Request.Mail;
using morcom_api.Application.Contracts.Request.Phone;
using morcom_api.Application.Contracts.Response.IdentityService;

namespace morcom_api.Application.Contracts.Request.User
{
    public class UserRequestCreateSpecial
    {
        public UserRequest user { get; set; }
        public AddressRequestCreate addressRequestCreate { get; set; }
        public IEnumerable<UserOfficeRequest> a_offices { get; set; }
        public IEnumerable<PhoneRequestCreate> listRequestPhone { get; set; }
    }
}