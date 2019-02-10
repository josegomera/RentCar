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
    /// Represents the single VehicleModel object view model.
    /// </summary>
    public partial class VehicleModelViewModel : SingleObjectViewModel<VehicleModel, int, IRentCarDbContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of VehicleModelViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static VehicleModelViewModel Create(IUnitOfWorkFactory<IRentCarDbContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new VehicleModelViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the VehicleModelViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the VehicleModelViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected VehicleModelViewModel(IUnitOfWorkFactory<IRentCarDbContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.VehicleModels, x => x.Description) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Vehicles for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Vehicle> LookUpVehicles {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (VehicleModelViewModel x) => x.LookUpVehicles,
                    getRepositoryFunc: x => x.Vehicles);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of VehicleBrands for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<VehicleBrand> LookUpVehicleBrands {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (VehicleModelViewModel x) => x.LookUpVehicleBrands,
                    getRepositoryFunc: x => x.VehicleBrands, 
                    projection: query => query.Where(brand => !brand.IsDisabled));
            }
        }


        /// <summary>
        /// The view model for the VehicleModelVehicles detail collection.
        /// </summary>
        public CollectionViewModelBase<Vehicle, Vehicle, int, IRentCarDbContextUnitOfWork> VehicleModelVehiclesDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (VehicleModelViewModel x) => x.VehicleModelVehiclesDetails,
                    getRepositoryFunc: x => x.Vehicles,
                    foreignKeyExpression: x => x.VehicleModelId,
                    navigationExpression: x => x.VehicleModel);
            }
        }
    }
}
