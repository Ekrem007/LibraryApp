namespace LibraryApp.UI.frmAuthor
{
	partial class frmAuthors
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
			gridControlAuthors = new DevExpress.XtraGrid.GridControl();
			gridViewAuthors = new DevExpress.XtraGrid.Views.Grid.GridView();
			Id = new DevExpress.XtraGrid.Columns.GridColumn();
			collAuthorName = new DevExpress.XtraGrid.Columns.GridColumn();
			barManagerAuthors = new DevExpress.XtraBars.BarManager(components);
			bar1 = new DevExpress.XtraBars.Bar();
			bar2 = new DevExpress.XtraBars.Bar();
			bar3 = new DevExpress.XtraBars.Bar();
			barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			btnAddAuthor = new DevExpress.XtraBars.BarButtonItem();
			btnUpdateAuthor = new DevExpress.XtraBars.BarButtonItem();
			btnDeleteAuthor = new DevExpress.XtraBars.BarButtonItem();
			btnRefreshData = new DevExpress.XtraBars.BarButtonItem();
			popupMenuAuthors = new DevExpress.XtraBars.PopupMenu(components);
			colTotalBooks = new DevExpress.XtraGrid.Columns.GridColumn();
			colTotalAvailableBooks = new DevExpress.XtraGrid.Columns.GridColumn();
			colTotalNotAvailableBooks = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)gridControlAuthors).BeginInit();
			((System.ComponentModel.ISupportInitialize)gridViewAuthors).BeginInit();
			((System.ComponentModel.ISupportInitialize)barManagerAuthors).BeginInit();
			((System.ComponentModel.ISupportInitialize)popupMenuAuthors).BeginInit();
			SuspendLayout();
			// 
			// gridControlAuthors
			// 
			gridControlAuthors.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
			gridControlAuthors.Location = new System.Drawing.Point(13, 4);
			gridControlAuthors.MainView = gridViewAuthors;
			gridControlAuthors.Margin = new System.Windows.Forms.Padding(4);
			gridControlAuthors.Name = "gridControlAuthors";
			gridControlAuthors.Size = new System.Drawing.Size(1038, 500);
			gridControlAuthors.TabIndex = 1;
			gridControlAuthors.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewAuthors });
			gridControlAuthors.DoubleClick += gridControlAuthors_DoubleClick;
			gridControlAuthors.KeyDown += gridControlAuthors_KeyDown;
			// 
			// gridViewAuthors
			// 
			gridViewAuthors.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { Id, collAuthorName, colTotalBooks, colTotalAvailableBooks, colTotalNotAvailableBooks });
			gridViewAuthors.DetailHeight = 431;
			gridViewAuthors.GridControl = gridControlAuthors;
			gridViewAuthors.Name = "gridViewAuthors";
			gridViewAuthors.OptionsEditForm.PopupEditFormWidth = 933;
			// 
			// Id
			// 
			Id.Caption = "Id";
			Id.FieldName = "Id";
			Id.MinWidth = 25;
			Id.Name = "Id";
			Id.OptionsColumn.AllowEdit = false;
			Id.Visible = true;
			Id.VisibleIndex = 0;
			Id.Width = 94;
			// 
			// collAuthorName
			// 
			collAuthorName.Caption = "Author Name";
			collAuthorName.FieldName = "Name";
			collAuthorName.MinWidth = 25;
			collAuthorName.Name = "collAuthorName";
			collAuthorName.OptionsColumn.AllowEdit = false;
			collAuthorName.Visible = true;
			collAuthorName.VisibleIndex = 1;
			collAuthorName.Width = 94;
			// 
			// barManagerAuthors
			// 
			barManagerAuthors.Bars.AddRange(new DevExpress.XtraBars.Bar[] { bar1, bar2, bar3 });
			barManagerAuthors.DockControls.Add(barDockControlTop);
			barManagerAuthors.DockControls.Add(barDockControlBottom);
			barManagerAuthors.DockControls.Add(barDockControlLeft);
			barManagerAuthors.DockControls.Add(barDockControlRight);
			barManagerAuthors.Form = this;
			barManagerAuthors.Items.AddRange(new DevExpress.XtraBars.BarItem[] { btnAddAuthor, btnUpdateAuthor, btnDeleteAuthor, btnRefreshData });
			barManagerAuthors.MainMenu = bar2;
			barManagerAuthors.MaxItemId = 4;
			barManagerAuthors.StatusBar = bar3;
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
			barDockControlTop.Manager = barManagerAuthors;
			barDockControlTop.Size = new System.Drawing.Size(1095, 41);
			// 
			// barDockControlBottom
			// 
			barDockControlBottom.CausesValidation = false;
			barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			barDockControlBottom.Location = new System.Drawing.Point(0, 691);
			barDockControlBottom.Manager = barManagerAuthors;
			barDockControlBottom.Size = new System.Drawing.Size(1095, 20);
			// 
			// barDockControlLeft
			// 
			barDockControlLeft.CausesValidation = false;
			barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			barDockControlLeft.Location = new System.Drawing.Point(0, 41);
			barDockControlLeft.Manager = barManagerAuthors;
			barDockControlLeft.Size = new System.Drawing.Size(0, 650);
			// 
			// barDockControlRight
			// 
			barDockControlRight.CausesValidation = false;
			barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			barDockControlRight.Location = new System.Drawing.Point(1095, 41);
			barDockControlRight.Manager = barManagerAuthors;
			barDockControlRight.Size = new System.Drawing.Size(0, 650);
			// 
			// btnAddAuthor
			// 
			btnAddAuthor.AccessibleName = "btnAddAuthor";
			btnAddAuthor.Caption = "➕   Add Author";
			btnAddAuthor.Id = 0;
			btnAddAuthor.Name = "btnAddAuthor";
			// 
			// btnUpdateAuthor
			// 
			btnUpdateAuthor.AccessibleName = "btnUpdateAuthor";
			btnUpdateAuthor.Caption = "🔄 Update Author";
			btnUpdateAuthor.Id = 1;
			btnUpdateAuthor.Name = "btnUpdateAuthor";
			// 
			// btnDeleteAuthor
			// 
			btnDeleteAuthor.AccessibleName = "btnDeleteAuthor";
			btnDeleteAuthor.Caption = "❌   Delete Author";
			btnDeleteAuthor.Id = 2;
			btnDeleteAuthor.Name = "btnDeleteAuthor";
			// 
			// btnRefreshData
			// 
			btnRefreshData.AccessibleName = "btnRefreshData";
			btnRefreshData.Caption = "🔄 Yenile";
			btnRefreshData.Id = 3;
			btnRefreshData.Name = "btnRefreshData";
			// 
			// popupMenuAuthors
			// 
			popupMenuAuthors.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(btnAddAuthor), new DevExpress.XtraBars.LinkPersistInfo(btnUpdateAuthor), new DevExpress.XtraBars.LinkPersistInfo(btnDeleteAuthor), new DevExpress.XtraBars.LinkPersistInfo(btnRefreshData) });
			popupMenuAuthors.Manager = barManagerAuthors;
			popupMenuAuthors.Name = "popupMenuAuthors";
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
			colTotalNotAvailableBooks.AccessibleName = "colTotalAvailableBooks";
			colTotalNotAvailableBooks.Caption = "Total Not Available Books";
			colTotalNotAvailableBooks.FieldName = "TotalNotAvailableBooks";
			colTotalNotAvailableBooks.MinWidth = 25;
			colTotalNotAvailableBooks.Name = "colTotalNotAvailableBooks";
			colTotalNotAvailableBooks.Visible = true;
			colTotalNotAvailableBooks.VisibleIndex = 4;
			colTotalNotAvailableBooks.Width = 94;
			// 
			// frmAuthors
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(1095, 711);
			Controls.Add(gridControlAuthors);
			Controls.Add(barDockControlLeft);
			Controls.Add(barDockControlRight);
			Controls.Add(barDockControlBottom);
			Controls.Add(barDockControlTop);
			Name = "frmAuthors";
			Text = "frmAuthors";
			((System.ComponentModel.ISupportInitialize)gridControlAuthors).EndInit();
			((System.ComponentModel.ISupportInitialize)gridViewAuthors).EndInit();
			((System.ComponentModel.ISupportInitialize)barManagerAuthors).EndInit();
			((System.ComponentModel.ISupportInitialize)popupMenuAuthors).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridControlAuthors;
		private DevExpress.XtraGrid.Views.Grid.GridView gridViewAuthors;
		private DevExpress.XtraGrid.Columns.GridColumn Id;
		private DevExpress.XtraGrid.Columns.GridColumn collAuthorName;
		private DevExpress.XtraBars.BarManager barManagerAuthors;
		private DevExpress.XtraBars.Bar bar1;
		private DevExpress.XtraBars.Bar bar2;
		private DevExpress.XtraBars.Bar bar3;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private DevExpress.XtraBars.BarButtonItem btnAddAuthor;
		private DevExpress.XtraBars.BarButtonItem btnUpdateAuthor;
		private DevExpress.XtraBars.BarButtonItem btnDeleteAuthor;
		private DevExpress.XtraBars.PopupMenu popupMenuAuthors;
		private DevExpress.XtraBars.BarButtonItem btnRefreshData;
		private DevExpress.XtraGrid.Columns.GridColumn colTotalBooks;
		private DevExpress.XtraGrid.Columns.GridColumn colTotalAvailableBooks;
		private DevExpress.XtraGrid.Columns.GridColumn colTotalNotAvailableBooks;
	}
}