using FluentValidation;
using RentCar.DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Bl.Validators
{
    public class InspectionValidator : AbstractValidator<Inspection>
    {
        public InspectionValidator()
        {
            RuleFor(inspection => inspection.VehicleId).NotEqual(0);

            RuleFor(inspection => inspection.ClientId).NotEqual(0);

            RuleFor(inspection => inspection.EmployeeId).NotEqual(0);
        }
    }
}
