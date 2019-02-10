using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.EF6;
using RentCar.DataModel.Context;
using RentCar.DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RentCar.App.RentCarDbContextDataModel {

    /// <summary>
    /// A RentCarDbContextUnitOfWork instance that represents the run-time implementation of the IRentCarDbContextUnitOfWork interface.
    /// </summary>
    public class RentCarDbContextUnitOfWork : DbUnitOfWork<RentCarDbContext>, IRentCarDbContextUnitOfWork {

        public RentCarDbContextUnitOfWork(Func<RentCarDbContext> contextFactory)
            : base(contextFactory) {
        }

        IRepository<ClientPreferredContactMedium, int> IRentCarDbContextUnitOfWork.ClientPreferredContactMediums {
            get { return GetRepository(x => x.Set<ClientPreferredContactMedium>(), (ClientPreferredContactMedium x) => x.Id); }
        }

        IRepository<Client, int> IRentCarDbContextUnitOfWork.Clients {
            get { return GetRepository(x => x.Set<Client>(), (Client x) => x.Id); }
        }

        IRepository<Employee, int> IRentCarDbContextUnitOfWork.Employees {
            get { return GetRepository(x => x.Set<Employee>(), (Employee x) => x.Id); }
        }

        IRepository<FuelType, int> IRentCarDbContextUnitOfWork.FuelTypes {
            get { return GetRepository(x => x.Set<FuelType>(), (FuelType x) => x.Id); }
        }

        IRepository<Vehicle, int> IRentCarDbContextUnitOfWork.Vehicles {
            get { return GetRepository(x => x.Set<Vehicle>(), (Vehicle x) => x.Id); }
        }

        IRepository<VehicleBrand, int> IRentCarDbContextUnitOfWork.VehicleBrands {
            get { return GetRepository(x => x.Set<VehicleBrand>(), (VehicleBrand x) => x.Id); }
        }

        IRepository<VehicleModel, int> IRentCarDbContextUnitOfWork.VehicleModels {
            get { return GetRepository(x => x.Set<VehicleModel>(), (VehicleModel x) => x.Id); }
        }

        IRepository<VehicleType, int> IRentCarDbContextUnitOfWork.VehicleTypes {
            get { return GetRepository(x => x.Set<VehicleType>(), (VehicleType x) => x.Id); }
        }

        IRepository<Inspection, int> IRentCarDbContextUnitOfWork.Inspections {
            get { return GetRepository(x => x.Set<Inspection>(), (Inspection x) => x.Id); }
        }

        IRepository<Rent, int> IRentCarDbContextUnitOfWork.Rents {
            get { return GetRepository(x => x.Set<Rent>(), (Rent x) => x.Id); }
        }

        IRepository<User, int> IRentCarDbContextUnitOfWork.Users {
            get { return GetRepository(x => x.Set<User>(), (User x) => x.Id); }
        }
    }
}
