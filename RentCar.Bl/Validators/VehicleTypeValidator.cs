using FluentValidation;
using RentCar.DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Bl.Validators
{
    public class VehicleTypeValidator : AbstractValidator<VehicleType>
    {
        public VehicleTypeValidator()
        {
            RuleFor(vehicleType => vehicleType.Description).NotEmpty().NotNull();
        }
    }
}
