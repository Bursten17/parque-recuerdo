export interface UserModuleResponse {
    n_id_module?: Number,
    s_name_modulo: string,
    s_to: string,
    s_icon: string,
    a_submodule: UserModuleResponse[],
    a_operation: UserOperationResponse[],
    b_showSubmenu: Boolean
}

export interface UserOperationResponse {
    n_id_operation: Number,
    s_name_operation: string,
    n_state_operation: Number,
    b_state_operation: Boolean,
    n_state_rol_operation: Number
}