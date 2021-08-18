namespace morcom_api.Application.Contracts.Request.Incoterm
{
    public class IncotermRequestUpdate:IncotermRequestCreate
    {
        public int n_id_document { get; set; }
        public int observant { get; set; }
    }
}