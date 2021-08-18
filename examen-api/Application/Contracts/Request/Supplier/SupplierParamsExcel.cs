using System;

namespace morcom_api.Application.Contracts.Request.Supplier
{
    public class SupplierParamsExcel
    {
        public SupplierParamsExcel(int? n_id_supplier, DateTime? t_datetime_creation_since, DateTime? t_datetime_creation_until)
        {
            _n_id_supplier = n_id_supplier;
            _t_datetime_creation_since = t_datetime_creation_since;
            _t_datetime_creation_until = t_datetime_creation_until;
        }
        public int? _n_id_supplier { get; set; }
        public DateTime? _t_datetime_creation_since { get; set; }
        public DateTime? _t_datetime_creation_until { get; set; }
    }
}