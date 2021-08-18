using System.Collections.Generic;

namespace morcom_api.Application.Contracts.Request.Office
{
    public class OfficeRequestUpdateState
    {
        public IEnumerable<OfficeRequestState> listRequest { get; set; }
    }
}