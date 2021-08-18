using FluentValidation;
using morcom_api.Application.Contracts.Request.Supplier;

namespace morcom_api.Application.Validators
{
    public class CreateSupplierValitator : AbstractValidator<SupplierRequestCreateSpecial>
    {
        
        public CreateSupplierValitator(){
            RuleFor(x => x.supplierRequest.s_name).NotEmpty();

            RuleFor(x => x.addressRequestCreate.n_id_country).NotEmpty();
            RuleFor(x => x.addressRequestCreate.s_address_line_1).NotEmpty();
            RuleFor(x => x.addressRequestCreate.s_city).NotEmpty();
            RuleFor(x => x.addressRequestCreate.s_region).NotEmpty();
            RuleFor(x => x.addressRequestCreate.s_zip_code).NotEmpty();
        }
    }

    public class UpdateSupplierValitator : AbstractValidator<SupplierRequestUpdateSpecial>
    {
        
        public UpdateSupplierValitator(){
            RuleFor(x => x.supplierRequest.s_name).NotEmpty();

            RuleFor(x => x.addressRequestUpdate.n_id_country).NotEmpty();
            RuleFor(x => x.addressRequestUpdate.s_address_line_1).NotEmpty();
            RuleFor(x => x.addressRequestUpdate.s_city).NotEmpty();
            RuleFor(x => x.addressRequestUpdate.s_region).NotEmpty();
            RuleFor(x => x.addressRequestUpdate.s_zip_code).NotEmpty();
        }
    }


}