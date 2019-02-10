using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using RentCar.App.RentCarDbContextDataModel;
using RentCar.App.Common;
using RentCar.DataModel.Entities;

namespace RentCar.App.ViewModels {

    /// <summary>
    /// Represents the single Rent object view model.
    /// </summary>
    public partial class RentViewModel : SingleObjectViewModel<Rent, int, IRentCarDbContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of RentViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static RentViewModel Create(IUnitOfWorkFactory<IRentCarDbContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new RentViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the RentViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the RentViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected RentViewModel(IUnitOfWorkFactory<IRentCarDbContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Rents, x => x.Comment) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Clients for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Client> LookUpClients {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (RentViewModel x) => x.LookUpClients,
                    getRepositoryFunc: x => x.Clients,
                    projection: query => query.Where(client => !client.IsDisabled));
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Employees for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Employee> LookUpEmployees {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (RentViewModel x) => x.LookUpEmployees,
                    getRepositoryFunc: x => x.Employees,
                    projection: query => query.Where(employee => !employee.IsDisabled));
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Vehicles for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Vehicle> LookUpVehicles {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (RentViewModel x) => x.LookUpVehicles,
                    getRepositoryFunc: x => x.Vehicles,
                    projection: query => query.Where(vehicle => !vehicle.IsDisabled));
            }
        }

    }
}
