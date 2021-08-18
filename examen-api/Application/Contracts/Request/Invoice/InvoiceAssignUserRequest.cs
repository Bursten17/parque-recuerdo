namespace morcom_api.Application.Contracts.Request.Invoice
{
    public class InvoiceAssignUserRequest
    {
        public int n_id_invoice { get; set; }
        public int n_id_user_assign { get; set; }
    }
}