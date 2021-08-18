using FluentValidation;
using morcom_api.Application.Contracts.Request.Client;

namespace morcom_api.Application.Validators
{
    public class CreateClientValidators : AbstractValidator<ClientRequestCreateSpecial>
    {
        public CreateClientValidators()
        {
            RuleFor(x => x.clientRequest.s_name).NotEmpty();
            // RuleFor(x => x.clientRequest.s_nationality).NotEmpty();
            RuleFor(x => x.clientRequest.n_client_type).NotEmpty();

            RuleFor(x => x.addressRequestCreate.n_id_country).NotEmpty();
            RuleFor(x => x.addressRequestCreate.s_address_line_1).NotEmpty();
            RuleFor(x => x.addressRequestCreate.s_city).NotEmpty();
            RuleFor(x => x.addressRequestCreate.s_region).NotEmpty();
            RuleFor(x => x.addressRequestCreate.s_zip_code).NotEmpty();
        }
    }

    public class UpdateClientValidators : AbstractValidator<ClientRequestUpdateSpecial>
    {
        public UpdateClientValidators()
        {
            RuleFor(x => x.clientRequest.s_name).NotEmpty();
            // RuleFor(x => x.clientRequest.s_nationality).NotEmpty();
            RuleFor(x => x.clientRequest.n_client_type).NotEmpty();

            RuleFor(x => x.addressRequestUpdate.n_id_country).NotEmpty();
            RuleFor(x => x.addressRequestUpdate.s_address_line_1).NotEmpty();
            RuleFor(x => x.addressRequestUpdate.s_city).NotEmpty();
            RuleFor(x => x.addressRequestUpdate.s_region).NotEmpty();
            RuleFor(x => x.addressRequestUpdate.s_zip_code).NotEmpty();
        }
    }
}