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
    /// Represents the VehicleModels collection view model.
    /// </summary>
    public partial class VehicleModelCollectionViewModel : CollectionViewModel<VehicleModel, int, IRentCarDbContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of VehicleModelCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static VehicleModelCollectionViewModel Create(IUnitOfWorkFactory<IRentCarDbContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new VehicleModelCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the VehicleModelCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the VehicleModelCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected VehicleModelCollectionViewModel(IUnitOfWorkFactory<IRentCarDbContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.VehicleModels) {
        }
    }
}