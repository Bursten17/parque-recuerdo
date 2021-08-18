using System;
using System.Collections.Generic;

namespace morcom_api.Application.Contracts.Request.Supplier
{
    public class SupplierRequestExcel
    {
        public IEnumerable<int> a_n_id_supplier { get; set; }
        public DateTime? t_datetime_creation_since { get; set; }
        public DateTime? t_datetime_creation_until { get; set; }
    }
}