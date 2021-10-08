using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TryDynamicComponent.Models
{
    public class TaxInformation
    {
        public decimal AdditionalTax { get; set; }
        public decimal EstimatedTax { get; set; }
    }

    public class TaxInformationValidator:AbstractValidator<TaxInformation>
    {
        public TaxInformationValidator()
        {
            RuleFor(x => x.AdditionalTax).Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Should not be empty");

            RuleFor(x => x.EstimatedTax).Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Should not be empty");
        }
    }
}
