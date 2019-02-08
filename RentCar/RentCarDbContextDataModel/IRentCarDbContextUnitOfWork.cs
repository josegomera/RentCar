using DevExpress.Mvvm.DataModel;
using RentCar.DataModel.Context;
using RentCar.DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RentCar.RentCarDbContextDataModel {

    /// <summary>
    /// IRentCarDbContextUnitOfWork extends the IUnitOfWork interface with repositories representing specific entities.
    /// </summary>
    public interface IRentCarDbContextUnitOfWork : IUnitOfWork {
        
        /// <summary>
        /// The Client entities repository.
        /// </summary>
		IRepository<Client, int> Clients { get; }
        
        /// <summary>
        /// The Employee entities repository.
        /// </summary>
		IRepository<Employee, int> Employees { get; }
        
        /// <summary>
        /// The FuelType entities repository.
        /// </summary>
		IRepository<FuelType, int> FuelTypes { get; }
        
        /// <summary>
        /// The Vehicle entities repository.
        /// </summary>
		IRepository<Vehicle, int> Vehicles { get; }
        
        /// <summary>
        /// The VehicleBrand entities repository.
        /// </summary>
		IRepository<VehicleBrand, int> VehicleBrands { get; }
        
        /// <summary>
        /// The VehicleModel entities repository.
        /// </summary>
		IRepository<VehicleModel, int> VehicleModels { get; }
        
        /// <summary>
        /// The VehicleType entities repository.
        /// </summary>
		IRepository<VehicleType, int> VehicleTypes { get; }
        
        /// <summary>
        /// The Inspection entities repository.
        /// </summary>
		IRepository<Inspection, int> Inspections { get; }
        
        /// <summary>
        /// The Rent entities repository.
        /// </summary>
		IRepository<Rent, int> Rents { get; }
    }
}
