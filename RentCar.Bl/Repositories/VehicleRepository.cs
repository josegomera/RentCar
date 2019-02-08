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
    public class VehicleRepository : EntityBaseRepository<Vehicle>, IVehicleRepository
    {
        public VehicleRepository(RentCarDbContext context, IValidator<Vehicle> validator)
        : base(context, validator)
        {

        }
    }
}
