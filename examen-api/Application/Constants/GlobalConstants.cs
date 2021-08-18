namespace API.Application.Constants
{
    public class GlobalConstants
    {
        //FORMATS EXCEL
        public const string FORMAT_DATE = "yyyy-mm-dd";
        public const string FORMAT_DECIMAL = "0.00";

        // ID ROL
        public const int N_ID_ROLE_ADMIN = 1;
        public const int N_ID_ROLE_SRUPERVISOR = 2;

        // PART ROUTE PREFIX
        public const string ROUTE_PREFIX = "api/[controller]";

        // SERVER MESSAGE
        public const string REST_ERROR = "REST ERROR";
        public const string SERVER_ERROR = "SERVER ERROR";

        //EXCEL 
        public const string EXCELCONTENT_TYPE = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
        public const string EXCEL_CSV_CONTENT_TYPE = "text/csv";

        // PDF
        public const string PDF_CONTENT_TYPE = "application/pdf";

        // TYPES DATA
        public const string APPLICATION_TYPE_JSON = "application/json";

        // API Messages
        public const string ERROR_SAVING_CHANGES = "Problem saving changes";
        public const string NOT_FOUND = "Not Found";
        public const string FORBIDDEN = "Forbidden";
        public const string ERROR_CREATING_USER = "Error on creating the user";
        public const string ERROR_DELETE_MAIN_PHOTO = "You cannot delete your main photo";
        public const string ERROR_DELETE_PHOTO = "Problem deleting the photo";

        // OFFICE MESSAGE
        public const string ERROR_NAME_ALREADY_EXISTS = "Name already exists";

        // TABLE CODES
        public const int TB_OFFICE_ID_TB_SETTINGS = 12;
        public const int TB_USER_ID_TB_SETTINGS = 13;
        public const int TB_CLIENT_ID_TB_SETTINGS = 14;
        public const int TB_SUPPLIER_ID_TB_SETTINGS = 15;
        public const int TB_MAIL_ID_TB_SETTINGS = 16;

        //EMAIL TEMPLATE PATH
        public const string TEMPLATE_PATH_MAIL = @"mailTemplateHtml/{0}.html";

        //TABLES CODE QUOTE, PO, INVOICE
        public const int TB_QUOTE_CODE = 58;
        public const int TB_PO_CODE = 59;
        public const int TB_INVOICE_CODE = 60;

        public const string WWW_Authenticate = "WWW-Authenticate";
    }
}