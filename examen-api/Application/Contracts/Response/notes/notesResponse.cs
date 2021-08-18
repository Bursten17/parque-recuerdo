using System;

namespace morcom_api.Application.Contracts.Response.notes
{
    public class notesResponse
    {
        public int n_id_document { get; set; }
        public string s_id_document { get; set; }
        public int n_item { get; set; }
        public string t_datetime_creation { get; set; }
        public DateTime t_datetime_creationAux { get; set; }
        public string s_description { get; set; }
    }
}