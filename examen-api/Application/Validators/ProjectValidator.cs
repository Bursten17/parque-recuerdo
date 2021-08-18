using FluentValidation;
using morcom_api.Application.Contracts.Request.Project;

namespace morcom_api.Application.Validators
{
    public class CreateProjectValidator : AbstractValidator<ProjectRequest>
    {
        public CreateProjectValidator()
        {
            RuleFor(x => x.n_id_client).NotEmpty();
            RuleFor(x => x.s_name).NotEmpty();
            RuleFor(x => x.n_id_type_community).NotEmpty();
            RuleFor(x => x.d_start_date).NotEmpty();
            RuleFor(x => x.d_end_date).NotEmpty();
            RuleFor(x => x.d_pay_date).NotEmpty();
        }
    }
}
