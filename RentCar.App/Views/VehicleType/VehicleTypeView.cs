using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace RentCar.App.Views.VehicleTypeView{
    public partial class VehicleTypeView : XtraUserControl {
        public VehicleTypeView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<RentCar.App.ViewModels.VehicleTypeViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                vehicleTypeViewBindingSource, x => x.Entity, x => x.Update());
						#region Vehicles Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(VehiclesGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.VehicleTypeVehiclesDetails.SelectedEntity,
                    args => args.Row as RentCar.DataModel.Entities.Vehicle,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(VehiclesGridView, "RowClick")
						 .EventToCommand(
						     x => x.VehicleTypeVehiclesDetails.Edit(null), x => x.VehicleTypeVehiclesDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			VehiclesGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    VehiclesPopUpMenu.ShowPopup(VehiclesGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the VehicleTypeVehiclesDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(VehiclesGridControl, g => g.DataSource, x => x.VehicleTypeVehiclesDetails.Entities);
			
														fluentAPI.BindCommand(bbiVehiclesNew, x => x.VehicleTypeVehiclesDetails.New());
																													fluentAPI.BindCommand(bbiVehiclesEdit,x => x.VehicleTypeVehiclesDetails.Edit(null), x=>x.VehicleTypeVehiclesDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiVehiclesDelete,x => x.VehicleTypeVehiclesDetails.Delete(null), x=>x.VehicleTypeVehiclesDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiVehiclesRefresh, x => x.VehicleTypeVehiclesDetails.Refresh());
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
