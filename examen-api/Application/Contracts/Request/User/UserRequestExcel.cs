using System;
using System.Collections.Generic;

namespace morcom_api.Application.Contracts.Request.User
{
    public class UserRequestExcel
    {
        public IEnumerable<int> a_n_id_user { get; set; }
        public DateTime? t_datetime_creation_since { get; set; }
        public DateTime? t_datetime_creation_until { get; set; }
    }
}