using System.Collections.Generic;

namespace morcom_api.Application.Contracts.Request.Project
{
    public class ProjectRequestStateUpdate
    {
        public IEnumerable<ProjectRequestState> listRequest { get; set; }
    }
}