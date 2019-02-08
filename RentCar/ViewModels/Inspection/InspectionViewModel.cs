using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using RentCar.RentCarDbContextDataModel;
using RentCar.Common;
using RentCar.DataModel.Entities;

namespace RentCar.ViewModels {

    /// <summary>
    /// Represents the single Inspection object view model.
    /// </summary>
    public partial class InspectionViewModel : SingleObjectViewModel<Inspection, int, IRentCarDbContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of InspectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static InspectionViewModel Create(IUnitOfWorkFactory<IRentCarDbContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new InspectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the InspectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the InspectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected InspectionViewModel(IUnitOfWorkFactory<IRentCarDbContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Inspections, x => x.Id) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Clients for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Client> LookUpClients {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (InspectionViewModel x) => x.LookUpClients,
                    getRepositoryFunc: x => x.Clients);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Employees for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Employee> LookUpEmployees {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (InspectionViewModel x) => x.LookUpEmployees,
                    getRepositoryFunc: x => x.Employees);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Vehicles for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Vehicle> LookUpVehicles {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (InspectionViewModel x) => x.LookUpVehicles,
                    getRepositoryFunc: x => x.Vehicles);
            }
        }

    }
}
