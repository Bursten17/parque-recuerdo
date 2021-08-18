using System.Net;

namespace morcom_api.Application.Utils
{
    public class ResponseStatus
    {
        public ResponseStatus(HttpStatusCode _status, string _message, object _data = null)
        {
            status = _status;
            message = _message;
            data = _data;
        }

        public HttpStatusCode status { get; set; }
        public string message { get; set; }
        public object data { get; set; }
    }
}