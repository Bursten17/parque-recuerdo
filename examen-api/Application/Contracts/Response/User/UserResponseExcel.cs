using System.ComponentModel;

namespace morcom_api.Application.Contracts.Response.User
{
    public class UserResponseExcel
    {
        [Description("User Code")]
        public int n_id_user { get; set; }

        [Description("Name")]
        public string s_name { get; set; }

        [Description("Last Name")]
        public string s_last_name { get; set; }

        [Description("Mother Last Name")]
        public string s_mother_last_name { get; set; }

        [Description("Mail")]
        public string s_mail { get; set; }

        [Description("Employee Code")]
        public string s_employee_code { get; set; }

        [Description("Role Code")]
        public int n_id_role { get; set; }

        [Description("Role Name")]
        public string s_name_role { get; set; }

        [Description("Area Code")]
        public int n_id_area { get; set; }

        [Description("Area Name")]
        public string s_name_area { get; set; }

        [Description("State Code")]
        public int n_id_state { get; set; }

        [Description("State Name")]
        public string s_name_state { get; set; }

        [Description("Gender")]
        public string s_gender { get; set; }

        [Description("Birthdate")]
        public string d_birthdate { get; set; }

        [Description("Date Creation")]
        public string t_datetime_creation { get; set; }
    }
}