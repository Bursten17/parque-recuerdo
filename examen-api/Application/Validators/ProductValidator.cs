using FluentValidation;
using morcom_api.Application.Contracts.Request.Product;

namespace morcom_api.Application.Validators
{
    public class CreateProductValidator: AbstractValidator<ProductRequestCreate>
    {
        public CreateProductValidator()
        {
            RuleFor(x => x.s_name).NotEmpty();
            RuleFor(x => x.n_price).NotEmpty();
            RuleFor(x => x.n_id_category).NotEmpty();
        }
    }

    public class UpdateProductValidator: AbstractValidator<ProductRequestUpdate>
    {
        public UpdateProductValidator()
        {
            RuleFor(x => x.s_name).NotEmpty();
            RuleFor(x => x.n_price).NotEmpty();
            RuleFor(x => x.n_id_category).NotEmpty();
        }
    }
}