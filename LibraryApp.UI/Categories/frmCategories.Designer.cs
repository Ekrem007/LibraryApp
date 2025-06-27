namespace LibraryApp.UI.frmAuthor
{
	partial class frmCategories
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			gridControlCategories = new DevExpress.XtraGrid.GridControl();
			gridViewCategories = new DevExpress.XtraGrid.Views.Grid.GridView();
			colCategoryId = new DevExpress.XtraGrid.Columns.GridColumn();
			colCategorryName = new DevExpress.XtraGrid.Columns.GridColumn();
			colTotalBooks = new DevExpress.XtraGrid.Columns.GridColumn();
			colTotalAvailableBooks = new DevExpress.XtraGrid.Columns.GridColumn();
			colTotalNotAvailableBooks = new DevExpress.XtraGrid.Columns.GridColumn();
			barManagerCategories = new DevExpress.XtraBars.BarManager(components);
			bar1 = new DevExpress.XtraBars.Bar();
			bar2 = new DevExpress.XtraBars.Bar();
			bar3 = new DevExpress.XtraBars.Bar();
			barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			btnAddCategory = new DevExpress.XtraBars.BarButtonItem();
			btnUpdateCategory = new DevExpress.XtraBars.BarButtonItem();
			btnDeleteCategory = new DevExpress.XtraBars.BarButtonItem();
			btnRefreshData = new DevExpress.XtraBars.BarButtonItem();
			btnGetCategoryHasBooks = new DevExpress.XtraBars.BarButtonItem();
			popupMenuCategories = new DevExpress.XtraBars.PopupMenu(components);
			((System.ComponentModel.ISupportInitialize)gridControlCategories).BeginInit();
			((System.ComponentModel.ISupportInitialize)gridViewCategories).BeginInit();
			((System.ComponentModel.ISupportInitialize)barManagerCategories).BeginInit();
			((System.ComponentModel.ISupportInitialize)popupMenuCategories).BeginInit();
			SuspendLayout();
			// 
			// gridControlCategories
			// 
			gridControlCategories.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
			gridControlCategories.Location = new System.Drawing.Point(13, 13);
			gridControlCategories.MainView = gridViewCategories;
			gridControlCategories.Margin = new System.Windows.Forms.Padding(4);
			gridControlCategories.Name = "gridControlCategories";
			gridControlCategories.Size = new System.Drawing.Size(1059, 465);
			gridControlCategories.TabIndex = 2;
			gridControlCategories.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewCategories });
			gridControlCategories.DoubleClick += gridControlCategories_DoubleClick;
			gridControlCategories.KeyDown += gridControlCategories_KeyDown;
			// 
			// gridViewCategories
			// 
			gridViewCategories.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colCategoryId, colCategorryName, colTotalBooks, colTotalAvailableBooks, colTotalNotAvailableBooks });
			gridViewCategories.DetailHeight = 431;
			gridViewCategories.GridControl = gridControlCategories;
			gridViewCategories.Name = "gridViewCategories";
			gridViewCategories.OptionsEditForm.PopupEditFormWidth = 933;
			// 
			// colCategoryId
			// 
			colCategoryId.Caption = "Id";
			colCategoryId.FieldName = "Id";
			colCategoryId.MinWidth = 25;
			colCategoryId.Name = "colCategoryId";
			colCategoryId.OptionsColumn.AllowEdit = false;
			colCategoryId.Visible = true;
			colCategoryId.VisibleIndex = 0;
			colCategoryId.Width = 94;
			// 
			// colCategorryName
			// 
			colCategorryName.Caption = "Category Name";
			colCategorryName.FieldName = "CategoryName";
			colCategorryName.MinWidth = 25;
			colCategorryName.Name = "colCategorryName";
			colCategorryName.OptionsColumn.AllowEdit = false;
			colCategorryName.Visible = true;
			colCategorryName.VisibleIndex = 1;
			colCategorryName.Width = 94;
			// 
			// colTotalBooks
			// 
			colTotalBooks.AccessibleName = "colTotalBooks";
			colTotalBooks.Caption = "Total Books";
			colTotalBooks.FieldName = "TotalBooks";
			colTotalBooks.MinWidth = 25;
			colTotalBooks.Name = "colTotalBooks";
			colTotalBooks.Visible = true;
			colTotalBooks.VisibleIndex = 2;
			colTotalBooks.Width = 94;
			// 
			// colTotalAvailableBooks
			// 
			colTotalAvailableBooks.AccessibleName = "colTotalAvailableBooks";
			colTotalAvailableBooks.Caption = "Total Available Books";
			colTotalAvailableBooks.FieldName = "TotalAvailableBooks";
			colTotalAvailableBooks.MinWidth = 25;
			colTotalAvailableBooks.Name = "colTotalAvailableBooks";
			colTotalAvailableBooks.Visible = true;
			colTotalAvailableBooks.VisibleIndex = 3;
			colTotalAvailableBooks.Width = 94;
			// 
			// colTotalNotAvailableBooks
			// 
			colTotalNotAvailableBooks.AccessibleName = "colTotalNotAvailableBooks";
			colTotalNotAvailableBooks.Caption = "Total Not Available Books";
			colTotalNotAvailableBooks.FieldName = "TotalNotAvailableBooks";
			colTotalNotAvailableBooks.MinWidth = 25;
			colTotalNotAvailableBooks.Name = "colTotalNotAvailableBooks";
			colTotalNotAvailableBooks.Visible = true;
			colTotalNotAvailableBooks.VisibleIndex = 4;
			colTotalNotAvailableBooks.Width = 94;
			// 
			// barManagerCategories
			// 
			barManagerCategories.Bars.AddRange(new DevExpress.XtraBars.Bar[] { bar1, bar2, bar3 });
			barManagerCategories.DockControls.Add(barDockControlTop);
			barManagerCategories.DockControls.Add(barDockControlBottom);
			barManagerCategories.DockControls.Add(barDockControlLeft);
			barManagerCategories.DockControls.Add(barDockControlRight);
			barManagerCategories.Form = this;
			barManagerCategories.Items.AddRange(new DevExpress.XtraBars.BarItem[] { btnAddCategory, btnUpdateCategory, btnDeleteCategory, btnRefreshData, btnGetCategoryHasBooks });
			barManagerCategories.MainMenu = bar2;
			barManagerCategories.MaxItemId = 5;
			barManagerCategories.StatusBar = bar3;
			// 
			// bar1
			// 
			bar1.BarName = "Tools";
			bar1.DockCol = 0;
			bar1.DockRow = 1;
			bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			bar1.Text = "Tools";
			// 
			// bar2
			// 
			bar2.BarName = "Main menu";
			bar2.DockCol = 0;
			bar2.DockRow = 0;
			bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			bar2.OptionsBar.MultiLine = true;
			bar2.OptionsBar.UseWholeRow = true;
			bar2.Text = "Main menu";
			// 
			// bar3
			// 
			bar3.BarName = "Status bar";
			bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
			bar3.DockCol = 0;
			bar3.DockRow = 0;
			bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
			bar3.OptionsBar.AllowQuickCustomization = false;
			bar3.OptionsBar.DrawDragBorder = false;
			bar3.OptionsBar.UseWholeRow = true;
			bar3.Text = "Status bar";
			// 
			// barDockControlTop
			// 
			barDockControlTop.CausesValidation = false;
			barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			barDockControlTop.Location = new System.Drawing.Point(0, 0);
			barDockControlTop.Manager = barManagerCategories;
			barDockControlTop.Size = new System.Drawing.Size(1103, 41);
			// 
			// barDockControlBottom
			// 
			barDockControlBottom.CausesValidation = false;
			barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			barDockControlBottom.Location = new System.Drawing.Point(0, 472);
			barDockControlBottom.Manager = barManagerCategories;
			barDockControlBottom.Size = new System.Drawing.Size(1103, 20);
			// 
			// barDockControlLeft
			// 
			barDockControlLeft.CausesValidation = false;
			barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			barDockControlLeft.Location = new System.Drawing.Point(0, 41);
			barDockControlLeft.Manager = barManagerCategories;
			barDockControlLeft.Size = new System.Drawing.Size(0, 431);
			// 
			// barDockControlRight
			// 
			barDockControlRight.CausesValidation = false;
			barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			barDockControlRight.Location = new System.Drawing.Point(1103, 41);
			barDockControlRight.Manager = barManagerCategories;
			barDockControlRight.Size = new System.Drawing.Size(0, 431);
			// 
			// btnAddCategory
			// 
			btnAddCategory.AccessibleName = "btnAddCategory";
			btnAddCategory.Caption = "➕   Add Category";
			btnAddCategory.Id = 0;
			btnAddCategory.Name = "btnAddCategory";
			// 
			// btnUpdateCategory
			// 
			btnUpdateCategory.AccessibleName = "btnUpdateCategory";
			btnUpdateCategory.Caption = "🔄Update Category";
			btnUpdateCategory.Id = 1;
			btnUpdateCategory.Name = "btnUpdateCategory";
			// 
			// btnDeleteCategory
			// 
			btnDeleteCategory.AccessibleName = "btnDeleteCategory";
			btnDeleteCategory.Caption = "❌   Delete Category";
			btnDeleteCategory.Id = 2;
			btnDeleteCategory.Name = "btnDeleteCategory";
			// 
			// btnRefreshData
			// 
			btnRefreshData.AccessibleName = "btnRefreshData";
			btnRefreshData.Caption = "🔄 Yenile";
			btnRefreshData.Id = 3;
			btnRefreshData.Name = "btnRefreshData";
			// 
			// btnGetCategoryHasBooks
			// 
			btnGetCategoryHasBooks.AccessibleName = "btnGetCategoryHasBooks";
			btnGetCategoryHasBooks.Caption = "Get Category Has Books";
			btnGetCategoryHasBooks.Id = 4;
			btnGetCategoryHasBooks.Name = "btnGetCategoryHasBooks";
			// 
			// popupMenuCategories
			// 
			popupMenuCategories.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(btnAddCategory), new DevExpress.XtraBars.LinkPersistInfo(btnUpdateCategory), new DevExpress.XtraBars.LinkPersistInfo(btnDeleteCategory), new DevExpress.XtraBars.LinkPersistInfo(btnRefreshData), new DevExpress.XtraBars.LinkPersistInfo(btnGetCategoryHasBooks) });
			popupMenuCategories.Manager = barManagerCategories;
			popupMenuCategories.Name = "popupMenuCategories";
			// 
			// frmCategories
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(1103, 492);
			Controls.Add(gridControlCategories);
			Controls.Add(barDockControlLeft);
			Controls.Add(barDockControlRight);
			Controls.Add(barDockControlBottom);
			Controls.Add(barDockControlTop);
			Name = "frmCategories";
			Text = "frmCategories";
			((System.ComponentModel.ISupportInitialize)gridControlCategories).EndInit();
			((System.ComponentModel.ISupportInitialize)gridViewCategories).EndInit();
			((System.ComponentModel.ISupportInitialize)barManagerCategories).EndInit();
			((System.ComponentModel.ISupportInitialize)popupMenuCategories).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridControlCategories;
		private DevExpress.XtraGrid.Views.Grid.GridView gridViewCategories;
		private DevExpress.XtraGrid.Columns.GridColumn colCategoryId;
		private DevExpress.XtraGrid.Columns.GridColumn colCategorryName;
		private DevExpress.XtraBars.BarManager barManagerCategories;
		private DevExpress.XtraBars.Bar bar1;
		private DevExpress.XtraBars.Bar bar2;
		private DevExpress.XtraBars.Bar bar3;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private DevExpress.XtraBars.BarButtonItem btnAddCategory;
		private DevExpress.XtraBars.BarButtonItem btnUpdateCategory;
		private DevExpress.XtraBars.BarButtonItem btnDeleteCategory;
		private DevExpress.XtraBars.PopupMenu popupMenuCategories;
		private DevExpress.XtraBars.BarButtonItem btnRefreshData;
		private DevExpress.XtraGrid.Columns.GridColumn colTotalBooks;
		private DevExpress.XtraGrid.Columns.GridColumn colTotalAvailableBooks;
		private DevExpress.XtraGrid.Columns.GridColumn colTotalNotAvailableBooks;
		private DevExpress.XtraBars.BarButtonItem btnGetCategoryHasBooks;
	}
}