using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using RentCar.App.RentCarDbContextDataModel;
using RentCar.App.Common;
using RentCar.DataModel.Entities;

namespace RentCar.App.ViewModels {

    /// <summary>
    /// Represents the FuelTypes collection view model.
    /// </summary>
    public partial class FuelTypeCollectionViewModel : CollectionViewModel<FuelType, int, IRentCarDbContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of FuelTypeCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static FuelTypeCollectionViewModel Create(IUnitOfWorkFactory<IRentCarDbContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new FuelTypeCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the FuelTypeCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the FuelTypeCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected FuelTypeCollectionViewModel(IUnitOfWorkFactory<IRentCarDbContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.FuelTypes) {
        }
    }
}