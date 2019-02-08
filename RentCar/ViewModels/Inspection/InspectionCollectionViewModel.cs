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
    /// Represents the Inspections collection view model.
    /// </summary>
    public partial class InspectionCollectionViewModel : CollectionViewModel<Inspection, int, IRentCarDbContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of InspectionCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static InspectionCollectionViewModel Create(IUnitOfWorkFactory<IRentCarDbContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new InspectionCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the InspectionCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the InspectionCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected InspectionCollectionViewModel(IUnitOfWorkFactory<IRentCarDbContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Inspections) {
        }
    }
}