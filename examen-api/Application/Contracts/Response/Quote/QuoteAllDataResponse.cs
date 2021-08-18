using System.Collections.Generic;
using morcom_api.Application.Contracts.Response.Incoterm;
using morcom_api.Application.Contracts.Response.QuoteDetail;

namespace morcom_api.Application.Contracts.Response.Quote
{
    public class QuoteAllDataResponse
    {
        public QuoteResponse quote { get; set; }
        public IEnumerable<QuoteDetailResponse> listRequestProduct { get; set; }
        public IEnumerable<IncotermResponse> listRequestIncoterm { get; set; }
    }
}