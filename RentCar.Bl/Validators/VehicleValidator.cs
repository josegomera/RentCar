using FluentValidation;
using RentCar.DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Bl.Validators
{
    public class VehicleValidator : AbstractValidator<Vehicle>
    {
        public VehicleValidator()
        {
            RuleFor(vehicle => vehicle.VehicleBrandId).NotEqual(0); 

            RuleFor(vehicle => vehicle.VehicleModelId).NotEqual(0);

            RuleFor(vehicle => vehicle.VehicleTypeId).NotEqual(0);

            RuleFor(vehicle => vehicle.FuelTypeId).NotEqual(0);

            RuleFor(vehicle => vehicle.Description).NotEmpty().NotNull();

            RuleFor(vehicle => vehicle.ChasisNumber).NotEmpty().NotNull();

            RuleFor(vehicle => vehicle.MotorNumber).NotEmpty().NotNull();

            RuleFor(vehicle => vehicle.PlacaNumber).NotEmpty().NotNull();
        }
    }
}
