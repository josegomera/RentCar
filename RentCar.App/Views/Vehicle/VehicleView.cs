using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace RentCar.App.Views.VehicleView{
    public partial class VehicleView : XtraUserControl {
        public VehicleView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<RentCar.App.ViewModels.VehicleViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                vehicleViewBindingSource, x => x.Entity, x => x.Update());
									// Binding for FuelType LookUp editor
			fluentAPI.SetBinding(FuelTypeLookUpEdit.Properties, p => p.DataSource, x => x.LookUpFuelTypes.Entities);
						// Binding for VehicleBrand LookUp editor
			fluentAPI.SetBinding(VehicleBrandLookUpEdit.Properties, p => p.DataSource, x => x.LookUpVehicleBrands.Entities);
						// Binding for VehicleModel LookUp editor
			fluentAPI.SetBinding(VehicleModelLookUpEdit.Properties, p => p.DataSource, x => x.LookUpVehicleModels.Entities);
						// Binding for VehicleType LookUp editor
			fluentAPI.SetBinding(VehicleTypeLookUpEdit.Properties, p => p.DataSource, x => x.LookUpVehicleTypes.Entities);
									fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[0]), x => x.Save());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[1]), x => x.SaveAndClose());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[2]), x => x.SaveAndNew());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[3]), x => x.Reset());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[4]), x => x.Delete());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelCloseButton.Buttons[0]), x => x.Close());	
       }
    }
}
