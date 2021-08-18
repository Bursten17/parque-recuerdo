using System;

namespace morcom_api.Application.Contracts.Request.Project
{
    public class ProjectRequestUpdate
    {
        public DateTime d_start_date { get; set; }
        public DateTime d_end_date { get; set; }
        public DateTime d_pay_date { get; set; }
    }
}