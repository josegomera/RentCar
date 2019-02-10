using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace RentCar.App.Views.ClientView{
    public partial class ClientView : XtraUserControl {
        public ClientView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<RentCar.App.ViewModels.ClientViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                clientViewBindingSource, x => x.Entity, x => x.Update());
						#region ClientPreferredContactMediums Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(ClientPreferredContactMediumsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.ClientClientPreferredContactMediumsDetails.SelectedEntity,
                    args => args.Row as RentCar.DataModel.Entities.ClientPreferredContactMedium,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(ClientPreferredContactMediumsGridView, "RowClick")
						 .EventToCommand(
						     x => x.ClientClientPreferredContactMediumsDetails.Edit(null), x => x.ClientClientPreferredContactMediumsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			ClientPreferredContactMediumsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    ClientPreferredContactMediumsPopUpMenu.ShowPopup(ClientPreferredContactMediumsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the ClientClientPreferredContactMediumsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(ClientPreferredContactMediumsGridControl, g => g.DataSource, x => x.ClientClientPreferredContactMediumsDetails.Entities);
			
														fluentAPI.BindCommand(bbiClientPreferredContactMediumsNew, x => x.ClientClientPreferredContactMediumsDetails.New());
																													fluentAPI.BindCommand(bbiClientPreferredContactMediumsEdit,x => x.ClientClientPreferredContactMediumsDetails.Edit(null), x=>x.ClientClientPreferredContactMediumsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiClientPreferredContactMediumsDelete,x => x.ClientClientPreferredContactMediumsDetails.Delete(null), x=>x.ClientClientPreferredContactMediumsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiClientPreferredContactMediumsRefresh, x => x.ClientClientPreferredContactMediumsDetails.Refresh());
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
