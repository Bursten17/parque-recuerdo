using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using morcom_api.Application.Contracts.Response.IdentityService;

namespace API.Application.Contracts.Response.IdentityService
{
    public class UserResponse
    {
        public string usuario { get; set; }
        public string token { get; set; }
        
    }
}