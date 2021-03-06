using FluentValidation;

namespace morcom_api.Application.Validators
{
    public static class ValidatorExtension
    {
        public static IRuleBuilder<T, string> ValidatePassword<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            var options = ruleBuilder
                .NotEmpty()
                .MinimumLength(8).WithMessage("Password must be at least 8 characters")
                .MaximumLength(8).WithMessage("Password must be at least 8 characters")
                .Matches("[A-Z]").WithMessage("Password must contain 1 uppercase letter")
                .Matches("[a-z]").WithMessage("Password must have at least 1 lowercase letter")
                .Matches("[0-9]").WithMessage("Password must contain a number")
                .Matches("[^a-zA-Z0-9]").WithMessage("Password must contain an alphanumeric");
            return options;
        }
    }
}