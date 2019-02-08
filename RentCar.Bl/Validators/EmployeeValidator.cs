using FluentValidation;
using RentCar.DataModel.Entities;
using RentCar.DataModel.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Bl.Validators
{
    public class EmployeeValidator : AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(employee => employee.Name).NotEmpty().NotNull();

            RuleFor(employee => employee.Email).NotEmpty().NotNull().EmailAddress();

            RuleFor(employee => employee.Document).NotEmpty().NotNull();

            RuleFor(employee => employee.DocumentType).NotEmpty().NotNull();

            RuleFor(employee => employee.WorkShift).NotEmpty().NotNull().IsInEnum();

            RuleFor(employee => employee.CommissionPercentage).NotEmpty().NotNull();

            RuleFor(employee => employee.AdmissionDate).NotEmpty().NotNull();
        }
    }
}
