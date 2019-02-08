namespace RentCar.Views.RentCarDbContextView {
    partial class RentCarDbContextView {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
		 #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
            this.tileBar = new DevExpress.XtraBars.Navigation.TileBar();
            this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
			this.tileBarGroupTables = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.tileBarGroupViews = new DevExpress.XtraBars.Navigation.TileBarGroup();
						this.tileBarItemClientCollectionView = new DevExpress.XtraBars.Navigation.TileBarItem();
						this.tileBarItemEmployeeCollectionView = new DevExpress.XtraBars.Navigation.TileBarItem();
						this.tileBarItemFuelTypeCollectionView = new DevExpress.XtraBars.Navigation.TileBarItem();
						this.tileBarItemVehicleCollectionView = new DevExpress.XtraBars.Navigation.TileBarItem();
						this.tileBarItemVehicleBrandCollectionView = new DevExpress.XtraBars.Navigation.TileBarItem();
						this.tileBarItemVehicleModelCollectionView = new DevExpress.XtraBars.Navigation.TileBarItem();
						this.tileBarItemVehicleTypeCollectionView = new DevExpress.XtraBars.Navigation.TileBarItem();
						this.tileBarItemInspectionCollectionView = new DevExpress.XtraBars.Navigation.TileBarItem();
						this.tileBarItemRentCollectionView = new DevExpress.XtraBars.Navigation.TileBarItem();
						            this.SuspendLayout();
			/// 
            // tileBar
            // 
            this.tileBar.AllowDrag = false;
			this.tileBar.AllowGlyphSkinning = true;
			this.tileBar.AllowSelectedItem = true;
            this.tileBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileBar.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar.Groups.Add(this.tileBarGroupTables);
            this.tileBar.Groups.Add(this.tileBarGroupViews);
			this.tileBar.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
            this.tileBar.Location = new System.Drawing.Point(0, 0);
            this.tileBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tileBar.Name = "tileBar";
            this.tileBar.Padding = new System.Windows.Forms.Padding(29, 11, 29, 11);
            this.tileBar.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
			this.tileBar.AppearanceGroupText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.tileBar.AppearanceGroupText.Options.UseForeColor = true;
            this.tileBar.ItemPadding = new System.Windows.Forms.Padding(8, 6, 12, 6);
            this.tileBar.IndentBetweenGroups = 10;
            this.tileBar.IndentBetweenItems = 10;
            this.tileBar.DropDownButtonWidth = 30;
            this.tileBar.SelectionBorderWidth = 2;
            this.tileBar.WideTileWidth = 150;
            this.tileBar.MinimumSize = new System.Drawing.Size(100, 110);
			this.tileBar.MaximumSize = new System.Drawing.Size(0, 110);
			this.tileBar.SelectionBorderWidth = 2;
            this.tileBar.Text = "tileBar";
			//
			//tileBarGroupTables
			//
			this.tileBarGroupTables.Name = "tileBarGroupTables";
            this.tileBarGroupTables.Text = "TABLES";
			// 
            // tileBarGroupViews
            // 
            this.tileBarGroupViews.Name = "tileBarGroupViews";
            this.tileBarGroupViews.Text = "VIEWS";
            			//
			//tileBarItemClientCollectionView
			//
			DevExpress.XtraEditors.TileItemElement tileItemElementClientCollectionView = new DevExpress.XtraEditors.TileItemElement();
            tileItemElementClientCollectionView.Text = "Clients";
            tileItemElementClientCollectionView.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
			this.tileBarItemClientCollectionView.Elements.Add(tileItemElementClientCollectionView);
			this.tileBarItemClientCollectionView.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(156)))));
            this.tileBarItemClientCollectionView.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarGroupTables.Items.Add(this.tileBarItemClientCollectionView);
						//
			//tileBarItemEmployeeCollectionView
			//
			DevExpress.XtraEditors.TileItemElement tileItemElementEmployeeCollectionView = new DevExpress.XtraEditors.TileItemElement();
            tileItemElementEmployeeCollectionView.Text = "Employees";
            tileItemElementEmployeeCollectionView.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
			this.tileBarItemEmployeeCollectionView.Elements.Add(tileItemElementEmployeeCollectionView);
			this.tileBarItemEmployeeCollectionView.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tileBarItemEmployeeCollectionView.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarGroupTables.Items.Add(this.tileBarItemEmployeeCollectionView);
						//
			//tileBarItemFuelTypeCollectionView
			//
			DevExpress.XtraEditors.TileItemElement tileItemElementFuelTypeCollectionView = new DevExpress.XtraEditors.TileItemElement();
            tileItemElementFuelTypeCollectionView.Text = "Fuel Types";
            tileItemElementFuelTypeCollectionView.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
			this.tileBarItemFuelTypeCollectionView.Elements.Add(tileItemElementFuelTypeCollectionView);
			this.tileBarItemFuelTypeCollectionView.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(109)))), ((int)(((byte)(0)))));
            this.tileBarItemFuelTypeCollectionView.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarGroupTables.Items.Add(this.tileBarItemFuelTypeCollectionView);
						//
			//tileBarItemVehicleCollectionView
			//
			DevExpress.XtraEditors.TileItemElement tileItemElementVehicleCollectionView = new DevExpress.XtraEditors.TileItemElement();
            tileItemElementVehicleCollectionView.Text = "Vehicles";
            tileItemElementVehicleCollectionView.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
			this.tileBarItemVehicleCollectionView.Elements.Add(tileItemElementVehicleCollectionView);
			this.tileBarItemVehicleCollectionView.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(196)))));
            this.tileBarItemVehicleCollectionView.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarGroupTables.Items.Add(this.tileBarItemVehicleCollectionView);
						//
			//tileBarItemVehicleBrandCollectionView
			//
			DevExpress.XtraEditors.TileItemElement tileItemElementVehicleBrandCollectionView = new DevExpress.XtraEditors.TileItemElement();
            tileItemElementVehicleBrandCollectionView.Text = "Vehicle Brands";
            tileItemElementVehicleBrandCollectionView.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
			this.tileBarItemVehicleBrandCollectionView.Elements.Add(tileItemElementVehicleBrandCollectionView);
			this.tileBarItemVehicleBrandCollectionView.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(112)))), ((int)(((byte)(56)))));
            this.tileBarItemVehicleBrandCollectionView.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarGroupTables.Items.Add(this.tileBarItemVehicleBrandCollectionView);
						//
			//tileBarItemVehicleModelCollectionView
			//
			DevExpress.XtraEditors.TileItemElement tileItemElementVehicleModelCollectionView = new DevExpress.XtraEditors.TileItemElement();
            tileItemElementVehicleModelCollectionView.Text = "Vehicle Models";
            tileItemElementVehicleModelCollectionView.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
			this.tileBarItemVehicleModelCollectionView.Elements.Add(tileItemElementVehicleModelCollectionView);
			this.tileBarItemVehicleModelCollectionView.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(156)))));
            this.tileBarItemVehicleModelCollectionView.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarGroupTables.Items.Add(this.tileBarItemVehicleModelCollectionView);
						//
			//tileBarItemVehicleTypeCollectionView
			//
			DevExpress.XtraEditors.TileItemElement tileItemElementVehicleTypeCollectionView = new DevExpress.XtraEditors.TileItemElement();
            tileItemElementVehicleTypeCollectionView.Text = "Vehicle Types";
            tileItemElementVehicleTypeCollectionView.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
			this.tileBarItemVehicleTypeCollectionView.Elements.Add(tileItemElementVehicleTypeCollectionView);
			this.tileBarItemVehicleTypeCollectionView.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tileBarItemVehicleTypeCollectionView.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarGroupTables.Items.Add(this.tileBarItemVehicleTypeCollectionView);
						//
			//tileBarItemInspectionCollectionView
			//
			DevExpress.XtraEditors.TileItemElement tileItemElementInspectionCollectionView = new DevExpress.XtraEditors.TileItemElement();
            tileItemElementInspectionCollectionView.Text = "Inspections";
            tileItemElementInspectionCollectionView.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
			this.tileBarItemInspectionCollectionView.Elements.Add(tileItemElementInspectionCollectionView);
			this.tileBarItemInspectionCollectionView.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(109)))), ((int)(((byte)(0)))));
            this.tileBarItemInspectionCollectionView.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarGroupTables.Items.Add(this.tileBarItemInspectionCollectionView);
						//
			//tileBarItemRentCollectionView
			//
			DevExpress.XtraEditors.TileItemElement tileItemElementRentCollectionView = new DevExpress.XtraEditors.TileItemElement();
            tileItemElementRentCollectionView.Text = "Rents";
            tileItemElementRentCollectionView.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
			this.tileBarItemRentCollectionView.Elements.Add(tileItemElementRentCollectionView);
			this.tileBarItemRentCollectionView.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(196)))));
            this.tileBarItemRentCollectionView.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarGroupTables.Items.Add(this.tileBarItemRentCollectionView);
						
				
			// 
            // navigationFrame
            // 
            this.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.navigationFrame.Name = "navigationFrame";
            this.navigationFrame.SelectedPage = null;
            this.navigationFrame.SelectedPageIndex = -1;
            this.navigationFrame.Text = "navigationFrame";
			// 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(RentCar.ViewModels.RentCarDbContextViewModel);
			// 
            // RentCarDbContextView
            // 
			this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.navigationFrame);
            this.Controls.Add(this.tileBar);
			this.Size = new System.Drawing.Size(1024, 768);
            this.Name = "RentCarDbContextView";
			this.Text = "RentCarDbContextView";
            this.ResumeLayout(false);
		}
		
        #endregion

		private DevExpress.XtraBars.Navigation.TileBar tileBar;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame;
        private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroupTables;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroupViews;
				private DevExpress.XtraBars.Navigation.TileBarItem tileBarItemClientCollectionView;
				private DevExpress.XtraBars.Navigation.TileBarItem tileBarItemEmployeeCollectionView;
				private DevExpress.XtraBars.Navigation.TileBarItem tileBarItemFuelTypeCollectionView;
				private DevExpress.XtraBars.Navigation.TileBarItem tileBarItemVehicleCollectionView;
				private DevExpress.XtraBars.Navigation.TileBarItem tileBarItemVehicleBrandCollectionView;
				private DevExpress.XtraBars.Navigation.TileBarItem tileBarItemVehicleModelCollectionView;
				private DevExpress.XtraBars.Navigation.TileBarItem tileBarItemVehicleTypeCollectionView;
				private DevExpress.XtraBars.Navigation.TileBarItem tileBarItemInspectionCollectionView;
				private DevExpress.XtraBars.Navigation.TileBarItem tileBarItemRentCollectionView;
					}
}
