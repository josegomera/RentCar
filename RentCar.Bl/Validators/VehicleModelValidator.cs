using FluentValidation;
using RentCar.DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Bl.Validators
{
    public class VehicleModelValidator : AbstractValidator<VehicleModel>
    {
        public VehicleModelValidator()
        {
            RuleFor(vehicleModel => vehicleModel.VehicleBrandId).NotNull().NotEqual(0);

            RuleFor(vehicleModel => vehicleModel.Description).NotEmpty().NotNull();
        }
    }
}
