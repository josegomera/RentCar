using FluentValidation;
using RentCar.DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Bl.Validators
{
    public class RentValidator : AbstractValidator<Rent>
    {
        public RentValidator()
        {
            RuleFor(rent => rent.VehicleId).NotEqual(0);

            RuleFor(rent => rent.ClientId).NotEqual(0);

            RuleFor(rent => rent.EmployeeId).NotEqual(0);

            RuleFor(rent => rent.Comment).NotEmpty().NotNull();

            RuleFor(rent => rent.AmountPerDay).NotEmpty().NotNull();

            RuleFor(rent => rent.RentDate).NotEmpty().NotNull();

            RuleFor(rent => rent.ReturnDate).NotEmpty().NotNull();
        }
    }
}
