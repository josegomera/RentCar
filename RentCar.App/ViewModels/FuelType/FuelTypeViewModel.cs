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
    /// Represents the single FuelType object view model.
    /// </summary>
    public partial class FuelTypeViewModel : SingleObjectViewModel<FuelType, int, IRentCarDbContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of FuelTypeViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static FuelTypeViewModel Create(IUnitOfWorkFactory<IRentCarDbContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new FuelTypeViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the FuelTypeViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the FuelTypeViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected FuelTypeViewModel(IUnitOfWorkFactory<IRentCarDbContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.FuelTypes, x => x.Description) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Vehicles for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Vehicle> LookUpVehicles {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (FuelTypeViewModel x) => x.LookUpVehicles,
                    getRepositoryFunc: x => x.Vehicles);
            }
        }


        /// <summary>
        /// The view model for the FuelTypeVehicles detail collection.
        /// </summary>
        public CollectionViewModelBase<Vehicle, Vehicle, int, IRentCarDbContextUnitOfWork> FuelTypeVehiclesDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (FuelTypeViewModel x) => x.FuelTypeVehiclesDetails,
                    getRepositoryFunc: x => x.Vehicles,
                    foreignKeyExpression: x => x.FuelTypeId,
                    navigationExpression: x => x.FuelType);
            }
        }
    }
}
