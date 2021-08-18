using System.Collections.Generic;

namespace morcom_api.Application.Contracts.Request.User
{
    public class UserRequestUpdateState
    {
        public IEnumerable<UserRequestUpdate> listRequest { get; set; }
    }
}