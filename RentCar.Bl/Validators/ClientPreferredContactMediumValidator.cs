using FluentValidation;
using RentCar.DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Bl.Validators
{
    public class ClientPreferredContactMediumValidator : AbstractValidator<ClientPreferredContactMedium>
    {
        public ClientPreferredContactMediumValidator()
        {
            RuleFor(clientPreferredContactMedium => clientPreferredContactMedium.ClientId).NotEmpty().NotNull().NotEqual(0);

            RuleFor(clientPreferredContactMedium => clientPreferredContactMedium.PreferredContactMedium).NotEmpty().NotNull().IsInEnum();
        }
    }
}
