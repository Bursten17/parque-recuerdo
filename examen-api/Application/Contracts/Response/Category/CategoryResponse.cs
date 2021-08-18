namespace morcom_api.Application.Contracts.Response.Category
{
    public class CategoryResponse
    { 
        public int n_id_supplier { get; set; }
        public int n_id_category { get; set; }
        public string s_category_name { get; set; }
        public int n_id_sub_category { get; set; }
        public string s_sub_category_name { get; set; }
        public int n_state { get; set; }
    }
}