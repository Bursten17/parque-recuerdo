using System.Collections.Generic;

namespace morcom_api.Application.Contracts.Request.Client
{
    public class ClientRequestStateUpdate
    {
        public IEnumerable<ClientRequestState> listRequest { get; set; }
    }
}