using RentCar.DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Bl.Repositories.Base    
{
    public interface IVehicleTypeRepository : IEntityBaseRepository<VehicleType> { }
    public interface IVehicleModelRepository : IEntityBaseRepository<VehicleModel> { }
    public interface IVehicleBrandRepository : IEntityBaseRepository<VehicleBrand> { }
    public interface IFuelTypeRepository : IEntityBaseRepository<FuelType> { }
    public interface IVehicleRepository : IEntityBaseRepository<Vehicle> { }
    public interface IEmployeeRepository : IEntityBaseRepository<Employee> { }
    public interface IClientRepository : IEntityBaseRepository<Client> { }
    public interface IInspectionRepository : IEntityBaseRepository<Inspection> { }
    public interface IRentRepository : IEntityBaseRepository<Rent> { }
}
