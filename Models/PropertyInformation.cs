using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TryDynamicComponent.Models
{
    public class PropertyInformation
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public string State { get; set; }
    }

    public class PropertyInformationValidator: AbstractValidator<PropertyInformation>
    {
        public PropertyInformationValidator()
        {
            RuleFor(x => x.Street)
                .NotEmpty().WithMessage("You must enter street");

            RuleFor(x => x.City)
              .NotEmpty().WithMessage("You must enter City");

            //RuleFor(x => x.Zip)
            //  .NotEmpty().WithMessage("You must enter Zip");

            //RuleFor(x => x.State)
            //  .NotEmpty().WithMessage("You must enter State");
        }
    }
}
