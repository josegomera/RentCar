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
    public class ClientValidator : AbstractValidator<Client>
    {
        public ClientValidator()
        {
            RuleFor(client => client.Name).NotEmpty().NotNull();

            RuleFor(client => client.Email).NotEmpty().NotNull().EmailAddress();

            RuleFor(client => client.Document).NotEmpty().NotNull();

            RuleFor(client => client.DocumentType).NotEmpty().NotNull();

            RuleFor(client => client.CreditCardNumber).NotEmpty().CreditCard();

            RuleFor(client => client.PersonType).NotEmpty().NotNull().IsInEnum();

            RuleFor(client => client.CreditLimit).NotEmpty().NotNull();
        }
    }
}
