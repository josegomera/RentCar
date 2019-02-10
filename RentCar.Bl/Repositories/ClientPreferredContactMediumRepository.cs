using FluentValidation;
using RentCar.Bl.Repositories.Base;
using RentCar.Bl.Repositories.Base.Implementation;
using RentCar.DataModel.Context;
using RentCar.DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Bl.Repositories
{
    public class ClientPreferredContactMediumRepository : EntityBaseRepository<ClientPreferredContactMedium>, IClientPreferredContactMediumRepository
    {
        public ClientPreferredContactMediumRepository(RentCarDbContext context, IValidator<ClientPreferredContactMedium> validator)
        : base(context, validator)
        {

        }
    }
}
