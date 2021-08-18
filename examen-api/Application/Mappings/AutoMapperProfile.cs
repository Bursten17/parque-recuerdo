using AutoMapper;
using morcom_api.Application.Contracts.Request.Incoterm;
using morcom_api.Application.Contracts.Request.Invoice;
using morcom_api.Application.Contracts.Request.InvoiceDetail;
using morcom_api.Application.Contracts.Request.PuchaseOrder;
using morcom_api.Application.Contracts.Request.PurchaseOrderDetail;
using morcom_api.Application.Contracts.Request.Quote;
using morcom_api.Application.Contracts.Request.QuoteDetail;
using morcom_api.Application.Contracts.Response.Incoterm;
using morcom_api.Application.Contracts.Response.Invoice;
using morcom_api.Application.Contracts.Response.InvoiceDetail;
using morcom_api.Application.Contracts.Response.PurchaseOrde;
using morcom_api.Application.Contracts.Response.PurchaseOrderDetail;
using morcom_api.Application.Contracts.Response.Quote;
using morcom_api.Application.Contracts.Response.QuoteDetail;

namespace morcom_api.Application.Mappings
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            // Controller: Quote | Method: CloneQuoteById
            CreateMap<QuoteResponse , QuoteRequestCreate>();
            CreateMap<QuoteDetailResponse, QuoteRequestDetailCreate>();
            CreateMap<IncotermResponse, IncotermRequestCreate>();

            // Controller: PO | Method: CloneQuoteById
            CreateMap<PurchaseOrderResponse , PurchaseOrderRequestCreate>();
            CreateMap<PurchaseOrderDetailResponse, PurchaseOrderRequestDetailCreate>();

            // Controller: PO | Method: CloneQuoteById
            CreateMap<InvoiceResponse, InvoiceRequestCreate>();
            CreateMap<InvoiceDetailResponse,InvoiceRequestDetailCreate>();

        }
    }
}