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
    public class ClientRepository : EntityBaseRepository<Client>, IClientRepository
    {
        public ClientRepository(RentCarDbContext context, IValidator<Client> validator)
        : base(context, validator)
        {

        }
    }
}
