using API.Application.Contracts.Request.IdentityService;
using FluentValidation;

namespace morcom_api.Application.Validators
{
    public class LoginAuthValidator : AbstractValidator<LoginUserRequest>
    {
        public LoginAuthValidator()
        {
            RuleFor(x => x.usuario).NotEmpty();
            RuleFor(x => x.clave).ValidatePassword();
        }
    }
}