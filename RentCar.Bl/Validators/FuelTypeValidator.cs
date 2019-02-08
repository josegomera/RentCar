using FluentValidation;
using RentCar.DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Bl.Validators
{
    public class FuelTypeValidator : AbstractValidator<FuelType>
    {
        public FuelTypeValidator()
        {
            RuleFor(fluelType => fluelType.Description).NotEmpty().NotNull();
        }
    }
}
