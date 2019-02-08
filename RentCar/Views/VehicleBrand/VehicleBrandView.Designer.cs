﻿namespace RentCar.Views.VehicleBrandView {
    partial class VehicleBrandView {
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
			this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
			this.windowsUIButtonPanelCloseButton = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.windowsUIButtonPanelMain = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
			this.labelControl = new DevExpress.XtraEditors.LabelControl();
						this.VehiclesGridControl = new DevExpress.XtraGrid.GridControl();
			this.VehiclesGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.VehiclesBarManager = new DevExpress.XtraBars.BarManager();
			this.VehiclesBar = new DevExpress.XtraBars.Bar();
			this.VehiclesXtraUserControl = new DevExpress.XtraEditors.XtraUserControl();
			this.VehiclesPopUpMenu = new DevExpress.XtraBars.PopupMenu(this.components);
						this.bbiVehiclesNew = new DevExpress.XtraBars.BarButtonItem();
						this.bbiVehiclesEdit = new DevExpress.XtraBars.BarButtonItem();
						this.bbiVehiclesDelete = new DevExpress.XtraBars.BarButtonItem();
						this.bbiVehiclesRefresh = new DevExpress.XtraBars.BarButtonItem();
						((System.ComponentModel.ISupportInitialize)(this.VehiclesBarManager)).BeginInit();
						this.VehicleModelsGridControl = new DevExpress.XtraGrid.GridControl();
			this.VehicleModelsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.VehicleModelsBarManager = new DevExpress.XtraBars.BarManager();
			this.VehicleModelsBar = new DevExpress.XtraBars.Bar();
			this.VehicleModelsXtraUserControl = new DevExpress.XtraEditors.XtraUserControl();
			this.VehicleModelsPopUpMenu = new DevExpress.XtraBars.PopupMenu(this.components);
						this.bbiVehicleModelsNew = new DevExpress.XtraBars.BarButtonItem();
						this.bbiVehicleModelsEdit = new DevExpress.XtraBars.BarButtonItem();
						this.bbiVehicleModelsDelete = new DevExpress.XtraBars.BarButtonItem();
						this.bbiVehicleModelsRefresh = new DevExpress.XtraBars.BarButtonItem();
						((System.ComponentModel.ISupportInitialize)(this.VehicleModelsBarManager)).BeginInit();
						 
			this.SuspendLayout();
			// 
            // windowsUIButtonPanelCloseButton
            // 
            this.windowsUIButtonPanelCloseButton.ButtonInterval = 0;
            this.windowsUIButtonPanelCloseButton.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("", null, "Backward;Size32x32;GrayScaled")});
            this.windowsUIButtonPanelCloseButton.ContentAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.windowsUIButtonPanelCloseButton.Dock = System.Windows.Forms.DockStyle.Left;
			this.windowsUIButtonPanelCloseButton.ForeColor = System.Drawing.Color.Gray;
            this.windowsUIButtonPanelCloseButton.MaximumSize = new System.Drawing.Size(45, 0);
            this.windowsUIButtonPanelCloseButton.MinimumSize = new System.Drawing.Size(45, 0);
            this.windowsUIButtonPanelCloseButton.Name = "windowsUIButtonPanelCloseButton";
            this.windowsUIButtonPanelCloseButton.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.windowsUIButtonPanelCloseButton.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.windowsUIButtonPanelCloseButton.Text = "windowsUIButtonPanel1";
			// 
            // windowsUIButtonPanelMain
            // 
			this.windowsUIButtonPanelMain.AppearanceButton.Hovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.FontSizeDelta = -1;
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.Options.UseBackColor = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.Options.UseFont = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.Options.UseForeColor = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Normal.FontSizeDelta = -1;
            this.windowsUIButtonPanelMain.AppearanceButton.Normal.Options.UseFont = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.FontSizeDelta = -1;
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.Options.UseBackColor = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.Options.UseFont = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.Options.UseForeColor = true;
            this.windowsUIButtonPanelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.windowsUIButtonPanelMain.EnableImageTransparency = true;
            this.windowsUIButtonPanelMain.ForeColor = System.Drawing.Color.White;
            this.windowsUIButtonPanelMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.windowsUIButtonPanelMain.Name = "windowsUIButtonPanelMain";
            this.windowsUIButtonPanelMain.Text = "windowsUIButtonPanelMain";
			this.windowsUIButtonPanelMain.MinimumSize = new System.Drawing.Size(60, 60);
			this.windowsUIButtonPanelMain.MaximumSize = new System.Drawing.Size(0, 60);
            this.windowsUIButtonPanelMain.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.windowsUIButtonPanelMain.UseButtonBackgroundImages = false;
						this.windowsUIButtonPanelMain.Buttons.Add(new DevExpress.XtraBars.Docking2010.WindowsUIButton("Save", null, "Save;Size32x32;GrayScaled"));
						this.windowsUIButtonPanelMain.Buttons.Add(new DevExpress.XtraBars.Docking2010.WindowsUIButton("Save And Close", null, "SaveAndClose;Size32x32;GrayScaled"));
						this.windowsUIButtonPanelMain.Buttons.Add(new DevExpress.XtraBars.Docking2010.WindowsUIButton("Save And New", null, "SaveAndNew;Size32x32;GrayScaled"));
						this.windowsUIButtonPanelMain.Buttons.Add(new DevExpress.XtraBars.Docking2010.WindowsUIButton("Reset Changes", null, "Reset;Size32x32;GrayScaled"));
						this.windowsUIButtonPanelMain.Buttons.Add(new DevExpress.XtraBars.Docking2010.WindowsUIButton("Delete", null, "Edit/Delete;Size32x32;GrayScaled"));
						// 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.TextVisible = false;
			// 
            // dataLayoutControl1item.CommandPropertyName
            // 
            this.dataLayoutControl1.AllowCustomization = false;
			this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataLayoutControl1.Root = this.layoutControlGroup1;
			this.vehicleBrandViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.vehicleBrandViewBindingSource.DataSource = typeof(RentCar.DataModel.Entities.VehicleBrand);
			this.dataLayoutControl1.DataSource = vehicleBrandViewBindingSource;
			//
			//Create GridControls
			//
			DevExpress.XtraDataLayout.RetrieveFieldsParameters parameters = new DevExpress.XtraDataLayout.RetrieveFieldsParameters();
           	parameters.DataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged;
						//
			//VehiclesGridControl
			//
			this.VehiclesGridControl.MainView = this.VehiclesGridView;
			this.VehiclesGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VehiclesGridControl.Name = "VehiclesGridControl";
            this.VehiclesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.VehiclesGridView});
			//
			//VehiclesGridView
			//
            this.VehiclesGridView.GridControl = this.VehiclesGridControl;
            this.VehiclesGridView.Name = "VehiclesGridView";
            this.VehiclesGridView.OptionsBehavior.Editable = false;
            this.VehiclesGridView.OptionsBehavior.ReadOnly = true;
			this.VehiclesGridView.OptionsView.ShowGroupPanel = false;
			//
			//VehiclesPopulateColumnsParameters
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnsParameters VehiclesPopulateColumnsParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnsParameters();
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters VehicleTypeVehiclesChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            VehicleTypeVehiclesChildPopulateColumnParameters_NotVisible.FieldName = "VehicleType";
		    VehicleTypeVehiclesChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			VehiclesPopulateColumnsParameters.CustomColumnParameters.Add(VehicleTypeVehiclesChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters VehicleBrandVehiclesChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            VehicleBrandVehiclesChildPopulateColumnParameters_NotVisible.FieldName = "VehicleBrand";
		    VehicleBrandVehiclesChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			VehiclesPopulateColumnsParameters.CustomColumnParameters.Add(VehicleBrandVehiclesChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters VehicleModelVehiclesChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            VehicleModelVehiclesChildPopulateColumnParameters_NotVisible.FieldName = "VehicleModel";
		    VehicleModelVehiclesChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			VehiclesPopulateColumnsParameters.CustomColumnParameters.Add(VehicleModelVehiclesChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters FuelTypeVehiclesChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            FuelTypeVehiclesChildPopulateColumnParameters_NotVisible.FieldName = "FuelType";
		    FuelTypeVehiclesChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			VehiclesPopulateColumnsParameters.CustomColumnParameters.Add(FuelTypeVehiclesChildPopulateColumnParameters_NotVisible);
			 
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters VehiclesVehiclesChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            VehiclesVehiclesChildPopulateColumnParameters.FieldName = "VehiclesVehicles";
            VehiclesVehiclesChildPopulateColumnParameters.Path = "Vehicles.Description";
			VehiclesPopulateColumnsParameters.CustomColumnParameters.Add(VehiclesVehiclesChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters VehicleModelsVehiclesChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            VehicleModelsVehiclesChildPopulateColumnParameters.FieldName = "VehicleModelsVehicles";
            VehicleModelsVehiclesChildPopulateColumnParameters.Path = "VehicleModels.Description";
			VehiclesPopulateColumnsParameters.CustomColumnParameters.Add(VehicleModelsVehiclesChildPopulateColumnParameters);
			 
		    this.VehiclesGridView.PopulateColumns(typeof(RentCar.DataModel.Entities.Vehicle),VehiclesPopulateColumnsParameters);
			//
			//VehiclesBindingSource
			//
			System.Windows.Forms.BindingSource VehiclesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			VehiclesBindingSource.DataSource = typeof(RentCar.DataModel.Entities.Vehicle);
            this.VehiclesGridControl.DataSource = VehiclesBindingSource;
			//
			//VehiclesXtraUserControl
			//
            this.VehiclesXtraUserControl.Controls.Add(VehiclesGridControl);
			this.VehiclesXtraUserControl.Name = "VehiclesXtraUserControl";
			this.VehiclesXtraUserControl.MinimumSize = new System.Drawing.Size(100, 100); 
							//
			//VehiclesNew
			//
			this.bbiVehiclesNew.Caption = "New";
			this.bbiVehiclesNew.Name = "bbiVehiclesNew";
			this.bbiVehiclesNew.ImageUri.Uri = "New";
			this.bbiVehiclesNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.VehiclesBarManager.Items.Add(this.bbiVehiclesNew);
			this.VehiclesBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiVehiclesNew));
			this.VehiclesPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiVehiclesNew));
						//
			//VehiclesEdit
			//
			this.bbiVehiclesEdit.Caption = "Edit";
			this.bbiVehiclesEdit.Name = "bbiVehiclesEdit";
			this.bbiVehiclesEdit.ImageUri.Uri = "Edit";
			this.bbiVehiclesEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.VehiclesBarManager.Items.Add(this.bbiVehiclesEdit);
			this.VehiclesBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiVehiclesEdit));
			this.VehiclesPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiVehiclesEdit));
						//
			//VehiclesDelete
			//
			this.bbiVehiclesDelete.Caption = "Delete";
			this.bbiVehiclesDelete.Name = "bbiVehiclesDelete";
			this.bbiVehiclesDelete.ImageUri.Uri = "Delete";
			this.bbiVehiclesDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.VehiclesBarManager.Items.Add(this.bbiVehiclesDelete);
			this.VehiclesBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiVehiclesDelete));
			this.VehiclesPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiVehiclesDelete));
						//
			//VehiclesRefresh
			//
			this.bbiVehiclesRefresh.Caption = "Refresh";
			this.bbiVehiclesRefresh.Name = "bbiVehiclesRefresh";
			this.bbiVehiclesRefresh.ImageUri.Uri = "Refresh";
			this.bbiVehiclesRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.VehiclesBarManager.Items.Add(this.bbiVehiclesRefresh);
			this.VehiclesBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiVehiclesRefresh));
			this.VehiclesPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiVehiclesRefresh));
						//
			//VehiclesBar
			//
			this.VehiclesBar.BarName = "Vehicles";
            this.VehiclesBar.DockCol = 0;
            this.VehiclesBar.DockRow = 0;
            this.VehiclesBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.VehiclesBar.OptionsBar.AllowQuickCustomization = false;
            this.VehiclesBar.OptionsBar.DrawDragBorder = false;
            this.VehiclesBar.Text = "Vehicles";
			//
			//VehiclesBarManager
			//
			this.VehiclesBarManager.AllowCustomization = false;
            this.VehiclesBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.VehiclesBar});
            this.VehiclesBarManager.Form = VehiclesXtraUserControl;
            this.VehiclesBarManager.MainMenu = this.VehiclesBar;
			// 
            // VehiclesPopUpMenu
            // 
            this.VehiclesPopUpMenu.Manager = this.VehiclesBarManager;
            this.VehiclesPopUpMenu.Name = "VehiclesPopUpMenu";
			//
			//VehiclesRetriveFieldParameters
			//
			DevExpress.XtraDataLayout.RetrieveFieldParameters VehiclesRetriveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            VehiclesRetriveFieldParameters.FieldName = "Vehicles";
            VehiclesRetriveFieldParameters.ControlForField = VehiclesXtraUserControl;
			VehiclesRetriveFieldParameters.CreateTabGroupForItem = true;
			parameters.CustomListParameters.Add(VehiclesRetriveFieldParameters);
						//
			//VehicleModelsGridControl
			//
			this.VehicleModelsGridControl.MainView = this.VehicleModelsGridView;
			this.VehicleModelsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VehicleModelsGridControl.Name = "VehicleModelsGridControl";
            this.VehicleModelsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.VehicleModelsGridView});
			//
			//VehicleModelsGridView
			//
            this.VehicleModelsGridView.GridControl = this.VehicleModelsGridControl;
            this.VehicleModelsGridView.Name = "VehicleModelsGridView";
            this.VehicleModelsGridView.OptionsBehavior.Editable = false;
            this.VehicleModelsGridView.OptionsBehavior.ReadOnly = true;
			this.VehicleModelsGridView.OptionsView.ShowGroupPanel = false;
			//
			//VehicleModelsPopulateColumnsParameters
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnsParameters VehicleModelsPopulateColumnsParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnsParameters();
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters VehicleBrandVehicleModelsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            VehicleBrandVehicleModelsChildPopulateColumnParameters_NotVisible.FieldName = "VehicleBrand";
		    VehicleBrandVehicleModelsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			VehicleModelsPopulateColumnsParameters.CustomColumnParameters.Add(VehicleBrandVehicleModelsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters VehiclesVehicleModelsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            VehiclesVehicleModelsChildPopulateColumnParameters_NotVisible.FieldName = "Vehicles";
		    VehiclesVehicleModelsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			VehicleModelsPopulateColumnsParameters.CustomColumnParameters.Add(VehiclesVehicleModelsChildPopulateColumnParameters_NotVisible);
			 
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters VehiclesVehicleModelsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            VehiclesVehicleModelsChildPopulateColumnParameters.FieldName = "VehiclesVehicleModels";
            VehiclesVehicleModelsChildPopulateColumnParameters.Path = "Vehicles.Description";
			VehicleModelsPopulateColumnsParameters.CustomColumnParameters.Add(VehiclesVehicleModelsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters VehicleModelsVehicleModelsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            VehicleModelsVehicleModelsChildPopulateColumnParameters.FieldName = "VehicleModelsVehicleModels";
            VehicleModelsVehicleModelsChildPopulateColumnParameters.Path = "VehicleModels.Description";
			VehicleModelsPopulateColumnsParameters.CustomColumnParameters.Add(VehicleModelsVehicleModelsChildPopulateColumnParameters);
			 
		    this.VehicleModelsGridView.PopulateColumns(typeof(RentCar.DataModel.Entities.VehicleModel),VehicleModelsPopulateColumnsParameters);
			//
			//VehicleModelsBindingSource
			//
			System.Windows.Forms.BindingSource VehicleModelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			VehicleModelsBindingSource.DataSource = typeof(RentCar.DataModel.Entities.VehicleModel);
            this.VehicleModelsGridControl.DataSource = VehicleModelsBindingSource;
			//
			//VehicleModelsXtraUserControl
			//
            this.VehicleModelsXtraUserControl.Controls.Add(VehicleModelsGridControl);
			this.VehicleModelsXtraUserControl.Name = "VehicleModelsXtraUserControl";
			this.VehicleModelsXtraUserControl.MinimumSize = new System.Drawing.Size(100, 100); 
							//
			//VehicleModelsNew
			//
			this.bbiVehicleModelsNew.Caption = "New";
			this.bbiVehicleModelsNew.Name = "bbiVehicleModelsNew";
			this.bbiVehicleModelsNew.ImageUri.Uri = "New";
			this.bbiVehicleModelsNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.VehicleModelsBarManager.Items.Add(this.bbiVehicleModelsNew);
			this.VehicleModelsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiVehicleModelsNew));
			this.VehicleModelsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiVehicleModelsNew));
						//
			//VehicleModelsEdit
			//
			this.bbiVehicleModelsEdit.Caption = "Edit";
			this.bbiVehicleModelsEdit.Name = "bbiVehicleModelsEdit";
			this.bbiVehicleModelsEdit.ImageUri.Uri = "Edit";
			this.bbiVehicleModelsEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.VehicleModelsBarManager.Items.Add(this.bbiVehicleModelsEdit);
			this.VehicleModelsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiVehicleModelsEdit));
			this.VehicleModelsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiVehicleModelsEdit));
						//
			//VehicleModelsDelete
			//
			this.bbiVehicleModelsDelete.Caption = "Delete";
			this.bbiVehicleModelsDelete.Name = "bbiVehicleModelsDelete";
			this.bbiVehicleModelsDelete.ImageUri.Uri = "Delete";
			this.bbiVehicleModelsDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.VehicleModelsBarManager.Items.Add(this.bbiVehicleModelsDelete);
			this.VehicleModelsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiVehicleModelsDelete));
			this.VehicleModelsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiVehicleModelsDelete));
						//
			//VehicleModelsRefresh
			//
			this.bbiVehicleModelsRefresh.Caption = "Refresh";
			this.bbiVehicleModelsRefresh.Name = "bbiVehicleModelsRefresh";
			this.bbiVehicleModelsRefresh.ImageUri.Uri = "Refresh";
			this.bbiVehicleModelsRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.VehicleModelsBarManager.Items.Add(this.bbiVehicleModelsRefresh);
			this.VehicleModelsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiVehicleModelsRefresh));
			this.VehicleModelsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiVehicleModelsRefresh));
						//
			//VehicleModelsBar
			//
			this.VehicleModelsBar.BarName = "VehicleModels";
            this.VehicleModelsBar.DockCol = 0;
            this.VehicleModelsBar.DockRow = 0;
            this.VehicleModelsBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.VehicleModelsBar.OptionsBar.AllowQuickCustomization = false;
            this.VehicleModelsBar.OptionsBar.DrawDragBorder = false;
            this.VehicleModelsBar.Text = "VehicleModels";
			//
			//VehicleModelsBarManager
			//
			this.VehicleModelsBarManager.AllowCustomization = false;
            this.VehicleModelsBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.VehicleModelsBar});
            this.VehicleModelsBarManager.Form = VehicleModelsXtraUserControl;
            this.VehicleModelsBarManager.MainMenu = this.VehicleModelsBar;
			// 
            // VehicleModelsPopUpMenu
            // 
            this.VehicleModelsPopUpMenu.Manager = this.VehicleModelsBarManager;
            this.VehicleModelsPopUpMenu.Name = "VehicleModelsPopUpMenu";
			//
			//VehicleModelsRetriveFieldParameters
			//
			DevExpress.XtraDataLayout.RetrieveFieldParameters VehicleModelsRetriveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            VehicleModelsRetriveFieldParameters.FieldName = "VehicleModels";
            VehicleModelsRetriveFieldParameters.ControlForField = VehicleModelsXtraUserControl;
			VehicleModelsRetriveFieldParameters.CreateTabGroupForItem = true;
			parameters.CustomListParameters.Add(VehicleModelsRetriveFieldParameters);
						 
			//
			//call RetrieveFields
			//
            this.dataLayoutControl1.RetrieveFields(parameters);
			// 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(RentCar.ViewModels.VehicleBrandViewModel);
			// 
            // labelControl
            // 
            this.labelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl.Name = "labelControl";
            this.labelControl.Text = "VehicleBrand - Element View";
            this.labelControl.AllowHtmlString = true;
            this.labelControl.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.labelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
			//
			//VehicleBrandView
			//
			this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.dataLayoutControl1);
			this.Controls.Add(this.labelControl);
            this.Controls.Add(this.windowsUIButtonPanelCloseButton);
            this.Controls.Add(this.windowsUIButtonPanelMain);
			this.Size = new System.Drawing.Size(1024, 768);
            this.Name = "VehicleBrandView";
						((System.ComponentModel.ISupportInitialize)(this.VehiclesBarManager)).EndInit();
						((System.ComponentModel.ISupportInitialize)(this.VehicleModelsBarManager)).EndInit();
						this.ResumeLayout(false);
		}
		
        #endregion

		private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
		private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelCloseButton;
		private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelMain;
		private DevExpress.XtraEditors.LabelControl labelControl;
		private System.Windows.Forms.BindingSource vehicleBrandViewBindingSource;
				private DevExpress.XtraGrid.GridControl VehiclesGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView VehiclesGridView;
		private DevExpress.XtraBars.BarManager VehiclesBarManager;
		private DevExpress.XtraBars.Bar VehiclesBar;
		private DevExpress.XtraEditors.XtraUserControl VehiclesXtraUserControl;
		private DevExpress.XtraBars.PopupMenu VehiclesPopUpMenu;
				private DevExpress.XtraBars.BarButtonItem bbiVehiclesNew;
				private DevExpress.XtraBars.BarButtonItem bbiVehiclesEdit;
				private DevExpress.XtraBars.BarButtonItem bbiVehiclesDelete;
				private DevExpress.XtraBars.BarButtonItem bbiVehiclesRefresh;
						private DevExpress.XtraGrid.GridControl VehicleModelsGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView VehicleModelsGridView;
		private DevExpress.XtraBars.BarManager VehicleModelsBarManager;
		private DevExpress.XtraBars.Bar VehicleModelsBar;
		private DevExpress.XtraEditors.XtraUserControl VehicleModelsXtraUserControl;
		private DevExpress.XtraBars.PopupMenu VehicleModelsPopUpMenu;
				private DevExpress.XtraBars.BarButtonItem bbiVehicleModelsNew;
				private DevExpress.XtraBars.BarButtonItem bbiVehicleModelsEdit;
				private DevExpress.XtraBars.BarButtonItem bbiVehicleModelsDelete;
				private DevExpress.XtraBars.BarButtonItem bbiVehicleModelsRefresh;
						 
	}
}
