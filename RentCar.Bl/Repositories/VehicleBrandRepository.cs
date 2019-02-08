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
    public class VehicleBrandRepository : EntityBaseRepository<VehicleBrand>, IVehicleBrandRepository
    {
        public VehicleBrandRepository(RentCarDbContext context, IValidator<VehicleBrand> validator)
        : base(context, validator)
        {

        }
    }
}
