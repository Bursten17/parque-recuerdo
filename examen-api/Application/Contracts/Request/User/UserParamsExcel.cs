using System;

namespace morcom_api.Application.Contracts.Request.User
{
    public class UserParamsExcel
    {
        public UserParamsExcel(int? n_id_user, DateTime? t_datetime_creation_since, DateTime? t_datetime_creation_until)
        {
            _n_id_user = n_id_user;
            _t_datetime_creation_since = t_datetime_creation_since;
            _t_datetime_creation_until = t_datetime_creation_until;
        }
        public int? _n_id_user { get; set; }
        public DateTime? _t_datetime_creation_since { get; set; }
        public DateTime? _t_datetime_creation_until { get; set; }
    }
}