using System.Collections.Generic;
using morcom_api.Application.Contracts.Request.Incoterm;
using morcom_api.Application.Contracts.Request.Notes;
using morcom_api.Application.Contracts.Request.QuoteDetail;

namespace morcom_api.Application.Contracts.Request.Quote
{
    public class QuoteRequestCreateSpecial
    {
        public QuoteRequestCreate quoteRequestCreate { get; set; }
        public IEnumerable<QuoteRequestDetailCreate> listRequestProduct { get; set; }
        public IEnumerable<IncotermRequestCreate> listRequestIncoterm { get; set; }
        public IEnumerable<notesCreateRequest> listNotes { get; set; }
    }
}