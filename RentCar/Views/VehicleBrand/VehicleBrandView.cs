using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace RentCar.Views.VehicleBrandView{
    public partial class VehicleBrandView : XtraUserControl {
        public VehicleBrandView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<RentCar.ViewModels.VehicleBrandViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                vehicleBrandViewBindingSource, x => x.Entity, x => x.Update());
						#region Vehicles Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(VehiclesGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.VehicleBrandVehiclesDetails.SelectedEntity,
                    args => args.Row as RentCar.DataModel.Entities.Vehicle,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(VehiclesGridView, "RowClick")
						 .EventToCommand(
						     x => x.VehicleBrandVehiclesDetails.Edit(null), x => x.VehicleBrandVehiclesDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			VehiclesGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    VehiclesPopUpMenu.ShowPopup(VehiclesGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the VehicleBrandVehiclesDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(VehiclesGridControl, g => g.DataSource, x => x.VehicleBrandVehiclesDetails.Entities);
			
														fluentAPI.BindCommand(bbiVehiclesNew, x => x.VehicleBrandVehiclesDetails.New());
																													fluentAPI.BindCommand(bbiVehiclesEdit,x => x.VehicleBrandVehiclesDetails.Edit(null), x=>x.VehicleBrandVehiclesDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiVehiclesDelete,x => x.VehicleBrandVehiclesDetails.Delete(null), x=>x.VehicleBrandVehiclesDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiVehiclesRefresh, x => x.VehicleBrandVehiclesDetails.Refresh());
																	#endregion
						#region VehicleModels Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(VehicleModelsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.VehicleBrandVehicleModelsDetails.SelectedEntity,
                    args => args.Row as RentCar.DataModel.Entities.VehicleModel,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(VehicleModelsGridView, "RowClick")
						 .EventToCommand(
						     x => x.VehicleBrandVehicleModelsDetails.Edit(null), x => x.VehicleBrandVehicleModelsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			VehicleModelsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    VehicleModelsPopUpMenu.ShowPopup(VehicleModelsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the VehicleBrandVehicleModelsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(VehicleModelsGridControl, g => g.DataSource, x => x.VehicleBrandVehicleModelsDetails.Entities);
			
														fluentAPI.BindCommand(bbiVehicleModelsNew, x => x.VehicleBrandVehicleModelsDetails.New());
																													fluentAPI.BindCommand(bbiVehicleModelsEdit,x => x.VehicleBrandVehicleModelsDetails.Edit(null), x=>x.VehicleBrandVehicleModelsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiVehicleModelsDelete,x => x.VehicleBrandVehicleModelsDetails.Delete(null), x=>x.VehicleBrandVehicleModelsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiVehicleModelsRefresh, x => x.VehicleBrandVehicleModelsDetails.Refresh());
																	#endregion
												fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[0]), x => x.Save());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[1]), x => x.SaveAndClose());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[2]), x => x.SaveAndNew());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[3]), x => x.Reset());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[4]), x => x.Delete());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelCloseButton.Buttons[0]), x => x.Close());	
       }
    }
}
