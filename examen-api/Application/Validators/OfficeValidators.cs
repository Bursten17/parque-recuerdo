using FluentValidation;
using morcom_api.Application.Contracts.Request.Office;

namespace morcom_api.Application.Validators
{
    public class CreateOfficeValidators: AbstractValidator<OfficeRequestCreateSpecial>
    {
        public CreateOfficeValidators()
        {
            RuleFor(x => x.officeRequest.s_code).NotEmpty();
            RuleFor(x => x.officeRequest.s_name).NotEmpty();

            // RuleFor(x => x.addressRequestCreate.n_id_country).NotEmpty();
            RuleFor(x => x.addressRequestCreate.s_address_line_1).NotEmpty();
            RuleFor(x => x.addressRequestCreate.s_city).NotEmpty();
            RuleFor(x => x.addressRequestCreate.s_region).NotEmpty();
            RuleFor(x => x.addressRequestCreate.s_zip_code).NotEmpty();
        }
    }
}