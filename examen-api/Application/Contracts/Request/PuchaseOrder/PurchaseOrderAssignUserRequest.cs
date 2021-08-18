namespace morcom_api.Application.Contracts.Request.PuchaseOrder
{
    public class PurchaseOrderAssignUserRequest
    {
        public int n_id_purchase_order { get; set; }
        public int n_id_user_assign { get; set; }
    }
}