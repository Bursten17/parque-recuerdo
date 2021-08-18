using FluentValidation;
using morcom_api.Application.Contracts.Request.Rol;

namespace morcom_api.Application.Validators
{
    public class CreateRoleValidators : AbstractValidator<RoleRequest>
    {
        public CreateRoleValidators()
        {
            RuleFor(x => x.s_name).NotEmpty();
        }
    }
}