using System.ComponentModel;

namespace morcom_api.Application.Contracts.Response.Supplier
{
    public class SupplierResponseExcel
    {
        [Description("Provider Code")]
        public int n_id_supplier { get; set; }

        [Description("Name")]
        public string s_name { get; set; }

        [Description("Country Code")]
        public int n_id_country { get; set; }

        [Description("Country Name")]
        public string s_name_country { get; set; }

        [Description("Date Creation")]
        public string t_datetime_creation { get; set; }

        [Description("State")]
        public int n_state { get; set; }
    }
}