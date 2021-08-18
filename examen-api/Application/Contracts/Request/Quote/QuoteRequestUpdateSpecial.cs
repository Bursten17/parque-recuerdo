using System.Collections.Generic;
using morcom_api.Application.Contracts.Request.Incoterm;
using morcom_api.Application.Contracts.Request.Notes;
using morcom_api.Application.Contracts.Request.QuoteDetail;

namespace morcom_api.Application.Contracts.Request.Quote
{
    public class QuoteRequestUpdateSpecial
    {
        public QuoteRequestUpdate quoteRequestUpdate { get; set; }
        public IEnumerable<QuoteRequestDetailUpdate> listRequestProduct { get; set; }
        public IEnumerable<IncotermRequestUpdate> listRequestIncoterm { get; set; }
    }
}