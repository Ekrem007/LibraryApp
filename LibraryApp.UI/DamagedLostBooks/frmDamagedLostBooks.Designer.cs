namespace LibraryApp.UI.DamagedLostBooks
{
	partial class frmDamagedLostBooks
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
			gridControlDamagedLostBooks = new DevExpress.XtraGrid.GridControl();
			gridViewDamagedLostBooks = new DevExpress.XtraGrid.Views.Grid.GridView();
			colBarcode = new DevExpress.XtraGrid.Columns.GridColumn();
			colBookName = new DevExpress.XtraGrid.Columns.GridColumn();
			colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
			barManagerDamagedLostBooks = new DevExpress.XtraBars.BarManager(components);
			bar1 = new DevExpress.XtraBars.Bar();
			bar2 = new DevExpress.XtraBars.Bar();
			bar3 = new DevExpress.XtraBars.Bar();
			barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			btnDamaged = new DevExpress.XtraBars.BarButtonItem();
			btnLost = new DevExpress.XtraBars.BarButtonItem();
			btnNormal = new DevExpress.XtraBars.BarButtonItem();
			popupMenuDamagedLostBooks = new DevExpress.XtraBars.PopupMenu(components);
			colAuthorName = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)gridControlDamagedLostBooks).BeginInit();
			((System.ComponentModel.ISupportInitialize)gridViewDamagedLostBooks).BeginInit();
			((System.ComponentModel.ISupportInitialize)barManagerDamagedLostBooks).BeginInit();
			((System.ComponentModel.ISupportInitialize)popupMenuDamagedLostBooks).BeginInit();
			SuspendLayout();
			// 
			// gridControlDamagedLostBooks
			// 
			gridControlDamagedLostBooks.Dock = System.Windows.Forms.DockStyle.Fill;
			gridControlDamagedLostBooks.Location = new System.Drawing.Point(0, 41);
			gridControlDamagedLostBooks.MainView = gridViewDamagedLostBooks;
			gridControlDamagedLostBooks.Name = "gridControlDamagedLostBooks";
			gridControlDamagedLostBooks.Size = new System.Drawing.Size(1203, 580);
			gridControlDamagedLostBooks.TabIndex = 0;
			gridControlDamagedLostBooks.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewDamagedLostBooks });
			// 
			// gridViewDamagedLostBooks
			// 
			gridViewDamagedLostBooks.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colBarcode, colBookName, colStatus, colAuthorName });
			gridViewDamagedLostBooks.GridControl = gridControlDamagedLostBooks;
			gridViewDamagedLostBooks.Name = "gridViewDamagedLostBooks";
			// 
			// colBarcode
			// 
			colBarcode.AccessibleName = "colBarcode";
			colBarcode.Caption = "Barcode";
			colBarcode.FieldName = "Barcode";
			colBarcode.MinWidth = 25;
			colBarcode.Name = "colBarcode";
			colBarcode.Visible = true;
			colBarcode.VisibleIndex = 0;
			colBarcode.Width = 94;
			// 
			// colBookName
			// 
			colBookName.AccessibleName = "colBookName";
			colBookName.Caption = "Book Name";
			colBookName.FieldName = "BookName";
			colBookName.MinWidth = 25;
			colBookName.Name = "colBookName";
			colBookName.Visible = true;
			colBookName.VisibleIndex = 1;
			colBookName.Width = 94;
			// 
			// colStatus
			// 
			colStatus.AccessibleName = "colStatus";
			colStatus.Caption = "Status";
			colStatus.FieldName = "Status";
			colStatus.MinWidth = 25;
			colStatus.Name = "colStatus";
			colStatus.Visible = true;
			colStatus.VisibleIndex = 2;
			colStatus.Width = 94;
			// 
			// barManagerDamagedLostBooks
			// 
			barManagerDamagedLostBooks.Bars.AddRange(new DevExpress.XtraBars.Bar[] { bar1, bar2, bar3 });
			barManagerDamagedLostBooks.DockControls.Add(barDockControlTop);
			barManagerDamagedLostBooks.DockControls.Add(barDockControlBottom);
			barManagerDamagedLostBooks.DockControls.Add(barDockControlLeft);
			barManagerDamagedLostBooks.DockControls.Add(barDockControlRight);
			barManagerDamagedLostBooks.Form = this;
			barManagerDamagedLostBooks.Items.AddRange(new DevExpress.XtraBars.BarItem[] { btnDamaged, btnLost, btnNormal });
			barManagerDamagedLostBooks.MainMenu = bar2;
			barManagerDamagedLostBooks.MaxItemId = 3;
			barManagerDamagedLostBooks.StatusBar = bar3;
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
			barDockControlTop.Manager = barManagerDamagedLostBooks;
			barDockControlTop.Size = new System.Drawing.Size(1203, 41);
			// 
			// barDockControlBottom
			// 
			barDockControlBottom.CausesValidation = false;
			barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			barDockControlBottom.Location = new System.Drawing.Point(0, 621);
			barDockControlBottom.Manager = barManagerDamagedLostBooks;
			barDockControlBottom.Size = new System.Drawing.Size(1203, 20);
			// 
			// barDockControlLeft
			// 
			barDockControlLeft.CausesValidation = false;
			barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			barDockControlLeft.Location = new System.Drawing.Point(0, 41);
			barDockControlLeft.Manager = barManagerDamagedLostBooks;
			barDockControlLeft.Size = new System.Drawing.Size(0, 580);
			// 
			// barDockControlRight
			// 
			barDockControlRight.CausesValidation = false;
			barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			barDockControlRight.Location = new System.Drawing.Point(1203, 41);
			barDockControlRight.Manager = barManagerDamagedLostBooks;
			barDockControlRight.Size = new System.Drawing.Size(0, 580);
			// 
			// btnDamaged
			// 
			btnDamaged.AccessibleName = "btnDamaged";
			btnDamaged.Caption = "Damaged";
			btnDamaged.Id = 0;
			btnDamaged.Name = "btnDamaged";
			// 
			// btnLost
			// 
			btnLost.AccessibleName = "btnLost";
			btnLost.Caption = "Lost";
			btnLost.Id = 1;
			btnLost.Name = "btnLost";
			// 
			// btnNormal
			// 
			btnNormal.AccessibleName = "btnNormal";
			btnNormal.Caption = "Normal";
			btnNormal.Id = 2;
			btnNormal.Name = "btnNormal";
			// 
			// popupMenuDamagedLostBooks
			// 
			popupMenuDamagedLostBooks.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(btnDamaged), new DevExpress.XtraBars.LinkPersistInfo(btnLost), new DevExpress.XtraBars.LinkPersistInfo(btnNormal) });
			popupMenuDamagedLostBooks.Manager = barManagerDamagedLostBooks;
			popupMenuDamagedLostBooks.Name = "popupMenuDamagedLostBooks";
			// 
			// colAuthorName
			// 
			colAuthorName.AccessibleName = "colAuthorName";
			colAuthorName.Caption = "Author Name";
			colAuthorName.FieldName = "AuthorName";
			colAuthorName.MinWidth = 25;
			colAuthorName.Name = "colAuthorName";
			colAuthorName.Visible = true;
			colAuthorName.VisibleIndex = 3;
			colAuthorName.Width = 94;
			// 
			// frmDamagedLostBooks
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(1203, 641);
			Controls.Add(gridControlDamagedLostBooks);
			Controls.Add(barDockControlLeft);
			Controls.Add(barDockControlRight);
			Controls.Add(barDockControlBottom);
			Controls.Add(barDockControlTop);
			Name = "frmDamagedLostBooks";
			Text = "frmDamagedLostBooks";
			((System.ComponentModel.ISupportInitialize)gridControlDamagedLostBooks).EndInit();
			((System.ComponentModel.ISupportInitialize)gridViewDamagedLostBooks).EndInit();
			((System.ComponentModel.ISupportInitialize)barManagerDamagedLostBooks).EndInit();
			((System.ComponentModel.ISupportInitialize)popupMenuDamagedLostBooks).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridControlDamagedLostBooks;
		private DevExpress.XtraGrid.Views.Grid.GridView gridViewDamagedLostBooks;
		private DevExpress.XtraGrid.Columns.GridColumn colBarcode;
		private DevExpress.XtraGrid.Columns.GridColumn colBookName;
		private DevExpress.XtraGrid.Columns.GridColumn colStatus;
		private DevExpress.XtraBars.BarManager barManagerDamagedLostBooks;
		private DevExpress.XtraBars.Bar bar1;
		private DevExpress.XtraBars.Bar bar2;
		private DevExpress.XtraBars.Bar bar3;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private DevExpress.XtraBars.PopupMenu popupMenuDamagedLostBooks;
		private DevExpress.XtraBars.BarButtonItem btnDamaged;
		private DevExpress.XtraBars.BarButtonItem btnLost;
		private DevExpress.XtraBars.BarButtonItem btnNormal;
		private DevExpress.XtraGrid.Columns.GridColumn colAuthorName;
	}
}