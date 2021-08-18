namespace morcom_api.Application.Contracts.Request.InvoiceDetail
{
    public class InvoiceRequestDetailUpdate:InvoiceRequestDetailCreate
    {
        public int observant { get; set; }
    }
}