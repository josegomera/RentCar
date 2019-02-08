using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using RentCar.RentCarDbContextDataModel;
using RentCar.Common;
using RentCar.DataModel.Entities;

namespace RentCar.ViewModels {

    /// <summary>
    /// Represents the Vehicles collection view model.
    /// </summary>
    public partial class VehicleCollectionViewModel : CollectionViewModel<Vehicle, int, IRentCarDbContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of VehicleCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static VehicleCollectionViewModel Create(IUnitOfWorkFactory<IRentCarDbContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new VehicleCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the VehicleCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the VehicleCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected VehicleCollectionViewModel(IUnitOfWorkFactory<IRentCarDbContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Vehicles) {
        }
    }
}