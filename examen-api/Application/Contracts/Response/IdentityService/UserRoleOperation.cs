namespace morcom_api.Application.Contracts.Response.IdentityService
{
    public class UserRoleOperation
    {
        public int n_id_role { get; set; }
        public int n_id_operation { get; set; }
        public string s_name_operation { get; set; }
        public int n_state_operation { get; set; }
        public int n_id_module { get; set; }
        public string s_name_modulo { get; set; }
        public int n_parent { get; set; }
        public string s_name_parent { get; set; }
        public int n_state_rol_operation { get; set; }
        public string s_to { get; set; }
        public string s_icon { get; set; }
    }
}
