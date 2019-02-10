using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.ViewModel;
using RentCar.App.RentCarDbContextDataModel;

namespace RentCar.App.ViewModels {
    /// <summary>
    /// Represents the root POCO view model for the RentCarDbContext data model.
    /// </summary>
    public partial class RentCarDbContextViewModel : DocumentsViewModel<RentCarDbContextModuleDescription, IRentCarDbContextUnitOfWork> {

		const string TablesGroup = "Tables";

		const string ViewsGroup = "Views";
		INavigationService NavigationService { get { return this.GetService<INavigationService>(); } }
	
        /// <summary>
        /// Creates a new instance of RentCarDbContextViewModel as a POCO view model.
        /// </summary>
        public static RentCarDbContextViewModel Create() {
            return ViewModelSource.Create(() => new RentCarDbContextViewModel());
        }

		
        /// <summary>
        /// Initializes a new instance of the RentCarDbContextViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the RentCarDbContextViewModel type without the POCO proxy factory.
        /// </summary>
        protected RentCarDbContextViewModel()
		    : base(UnitOfWorkSource.GetUnitOfWorkFactory()) {
        }

        protected override RentCarDbContextModuleDescription[] CreateModules() {
			return new RentCarDbContextModuleDescription[] {
              //  new RentCarDbContextModuleDescription( "Client Preferred Contact Mediums", "ClientPreferredContactMediumCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.ClientPreferredContactMediums)),
                new RentCarDbContextModuleDescription( "Rentas", "RentCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Rents)),
                new RentCarDbContextModuleDescription( "Inspecciones", "InspectionCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Inspections)),
                new RentCarDbContextModuleDescription( "Clientes", "ClientCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Clients)),
                new RentCarDbContextModuleDescription( "Empleados", "EmployeeCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Employees)),
                new RentCarDbContextModuleDescription( "Vehículos", "VehicleCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Vehicles)),
                new RentCarDbContextModuleDescription( "Marcas de vehículos", "VehicleBrandCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.VehicleBrands)),
                new RentCarDbContextModuleDescription( "Modelos de vehículos", "VehicleModelCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.VehicleModels)),
                new RentCarDbContextModuleDescription( "Tipos de vehículos", "VehicleTypeCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.VehicleTypes)),
                new RentCarDbContextModuleDescription( "Combustibles", "FuelTypeCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.FuelTypes)),
                new RentCarDbContextModuleDescription( "Usuarios", "UserCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Users)),
			};
        }
                		protected override void OnActiveModuleChanged(RentCarDbContextModuleDescription oldModule) {
            if(ActiveModule != null && NavigationService != null) {
                NavigationService.ClearNavigationHistory();
            }
            base.OnActiveModuleChanged(oldModule);
        }
	}

    public partial class RentCarDbContextModuleDescription : ModuleDescription<RentCarDbContextModuleDescription> {
        public RentCarDbContextModuleDescription(string title, string documentType, string group, Func<RentCarDbContextModuleDescription, object> peekCollectionViewModelFactory = null)
            : base(title, documentType, group, peekCollectionViewModelFactory) {
        }
    }
}