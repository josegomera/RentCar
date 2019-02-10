using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using DevExpress.Utils.MVVM.Services;
using DevExpress.Utils.MVVM;
using DevExpress.XtraBars.Navigation;

namespace RentCar.App.Views.RentCarDbContextView{
    public partial class RentCarDbContextView : XtraUserControl {
        public RentCarDbContextView() {
		     InitializeComponent();
			 if(!mvvmContext.IsDesignMode)
                InitializeNavigation();
        }
        void InitializeNavigation() {
			DevExpress.XtraEditors.WindowsFormsSettings.SetDPIAware();
            DevExpress.XtraEditors.WindowsFormsSettings.EnableFormSkins();
            DevExpress.XtraEditors.WindowsFormsSettings.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            DevExpress.XtraEditors.WindowsFormsSettings.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.True;
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2013");
            float fontSize = 10f;
            DevExpress.XtraEditors.WindowsFormsSettings.DefaultFont = new System.Drawing.Font("Segoe UI", fontSize);
            DevExpress.XtraEditors.WindowsFormsSettings.DefaultMenuFont = new System.Drawing.Font("Segoe UI", fontSize);

			tileBar.SelectionColorMode = SelectionColorMode.UseItemBackColor;
            mvvmContext.RegisterService(DocumentManagerService.Create(navigationFrame));
            DevExpress.Utils.MVVM.MVVMContext.RegisterFlyoutDialogService();
            // We want to use buttons in Ribbon to show the specific modules
            var fluentAPI = mvvmContext.OfType<RentCar.App.ViewModels.RentCarDbContextViewModel>();
						tileBar.SelectedItem = tileBarItemRentCollectionView;

            // fluentAPI.BindCommand(tileBarItemClientPreferredContactMediumCollectionView, (x, m) => x.Show(m), x => x.Modules[0]);
            fluentAPI.BindCommand(tileBarItemRentCollectionView, (x, m) => x.Show(m), x => x.Modules[0]);
            fluentAPI.BindCommand(tileBarItemInspectionCollectionView, (x, m) => x.Show(m), x => x.Modules[1]);
            fluentAPI.BindCommand(tileBarItemClientCollectionView, (x, m) => x.Show(m), x => x.Modules[2]);
			fluentAPI.BindCommand(tileBarItemEmployeeCollectionView, (x, m) => x.Show(m), x => x.Modules[3]);
			fluentAPI.BindCommand(tileBarItemVehicleCollectionView, (x, m) => x.Show(m), x => x.Modules[4]);
			fluentAPI.BindCommand(tileBarItemVehicleBrandCollectionView, (x, m) => x.Show(m), x => x.Modules[5]);
			fluentAPI.BindCommand(tileBarItemVehicleModelCollectionView, (x, m) => x.Show(m), x => x.Modules[6]);
			fluentAPI.BindCommand(tileBarItemVehicleTypeCollectionView, (x, m) => x.Show(m), x => x.Modules[7]);
            fluentAPI.BindCommand(tileBarItemFuelTypeCollectionView, (x, m) => x.Show(m), x => x.Modules[8]);
           // fluentAPI.BindCommand(tileBarItemUserCollectionView, (x, m) => x.Show(m), x => x.Modules[9]);
						            // We want show the default module when our UserControl is loaded
            fluentAPI.WithEvent<EventArgs>(this, "Load")
                .EventToCommand(x => x.OnLoaded(null), x => x.DefaultModule);
		
        }
    }
}
