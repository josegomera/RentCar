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
    /// Represents the single Vehicle object view model.
    /// </summary>
    public partial class VehicleViewModel : SingleObjectViewModel<Vehicle, int, IRentCarDbContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of VehicleViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static VehicleViewModel Create(IUnitOfWorkFactory<IRentCarDbContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new VehicleViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the VehicleViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the VehicleViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected VehicleViewModel(IUnitOfWorkFactory<IRentCarDbContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Vehicles, x => x.Description) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of FuelTypes for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<FuelType> LookUpFuelTypes {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (VehicleViewModel x) => x.LookUpFuelTypes,
                    getRepositoryFunc: x => x.FuelTypes);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of VehicleBrands for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<VehicleBrand> LookUpVehicleBrands {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (VehicleViewModel x) => x.LookUpVehicleBrands,
                    getRepositoryFunc: x => x.VehicleBrands);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of VehicleModels for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<VehicleModel> LookUpVehicleModels {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (VehicleViewModel x) => x.LookUpVehicleModels,
                    getRepositoryFunc: x => x.VehicleModels);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of VehicleTypes for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<VehicleType> LookUpVehicleTypes {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (VehicleViewModel x) => x.LookUpVehicleTypes,
                    getRepositoryFunc: x => x.VehicleTypes);
            }
        }

    }
}
