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
    /// Represents the single VehicleBrand object view model.
    /// </summary>
    public partial class VehicleBrandViewModel : SingleObjectViewModel<VehicleBrand, int, IRentCarDbContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of VehicleBrandViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static VehicleBrandViewModel Create(IUnitOfWorkFactory<IRentCarDbContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new VehicleBrandViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the VehicleBrandViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the VehicleBrandViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected VehicleBrandViewModel(IUnitOfWorkFactory<IRentCarDbContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.VehicleBrands, x => x.Description) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Vehicles for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Vehicle> LookUpVehicles {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (VehicleBrandViewModel x) => x.LookUpVehicles,
                    getRepositoryFunc: x => x.Vehicles);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of VehicleModels for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<VehicleModel> LookUpVehicleModels {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (VehicleBrandViewModel x) => x.LookUpVehicleModels,
                    getRepositoryFunc: x => x.VehicleModels);
            }
        }


        /// <summary>
        /// The view model for the VehicleBrandVehicles detail collection.
        /// </summary>
        public CollectionViewModelBase<Vehicle, Vehicle, int, IRentCarDbContextUnitOfWork> VehicleBrandVehiclesDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (VehicleBrandViewModel x) => x.VehicleBrandVehiclesDetails,
                    getRepositoryFunc: x => x.Vehicles,
                    foreignKeyExpression: x => x.VehicleBrandId,
                    navigationExpression: x => x.VehicleBrand);
            }
        }

        /// <summary>
        /// The view model for the VehicleBrandVehicleModels detail collection.
        /// </summary>
        public CollectionViewModelBase<VehicleModel, VehicleModel, int, IRentCarDbContextUnitOfWork> VehicleBrandVehicleModelsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (VehicleBrandViewModel x) => x.VehicleBrandVehicleModelsDetails,
                    getRepositoryFunc: x => x.VehicleModels,
                    foreignKeyExpression: x => x.VehicleBrandId,
                    navigationExpression: x => x.VehicleBrand);
            }
        }
    }
}
