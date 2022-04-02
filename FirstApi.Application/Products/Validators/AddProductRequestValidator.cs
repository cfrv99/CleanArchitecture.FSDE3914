using FirstApi.Application.Products.Requests;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApi.Application.Products.Validators
{
    public class AddProductRequestValidator : AbstractValidator<AddProductRequest>
    {
        public AddProductRequestValidator()
        {
            RuleFor(i => i.Name).NotEmpty().WithMessage(i => $"{nameof(i.Name)} can not be empty");
        }
    }
}
