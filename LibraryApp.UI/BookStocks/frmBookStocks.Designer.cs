namespace LibraryApp.UI.BookStocks
{
	partial class frmBookStocks
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
			gridControlBookStocks = new DevExpress.XtraGrid.GridControl();
			gridViewBookStocks = new DevExpress.XtraGrid.Views.Grid.GridView();
			colBarcode = new DevExpress.XtraGrid.Columns.GridColumn();
			colBookName = new DevExpress.XtraGrid.Columns.GridColumn();
			colIsAvailable = new DevExpress.XtraGrid.Columns.GridColumn();
			bar3 = new DevExpress.XtraBars.Bar();
			bar2 = new DevExpress.XtraBars.Bar();
			bar1 = new DevExpress.XtraBars.Bar();
			barManagerBookStocks = new DevExpress.XtraBars.BarManager(components);
			barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			btnAddBookStock = new DevExpress.XtraBars.BarButtonItem();
			btnDeleteBook = new DevExpress.XtraBars.BarButtonItem();
			btnGiveBookToStudent = new DevExpress.XtraBars.BarButtonItem();
			popupMenuBookStocks = new DevExpress.XtraBars.PopupMenu(components);
			btnNormal = new DevExpress.XtraBars.BarButtonItem();
			btnDamaged = new DevExpress.XtraBars.BarButtonItem();
			btnLost = new DevExpress.XtraBars.BarButtonItem();
			((System.ComponentModel.ISupportInitialize)gridControlBookStocks).BeginInit();
			((System.ComponentModel.ISupportInitialize)gridViewBookStocks).BeginInit();
			((System.ComponentModel.ISupportInitialize)barManagerBookStocks).BeginInit();
			((System.ComponentModel.ISupportInitialize)popupMenuBookStocks).BeginInit();
			SuspendLayout();
			// 
			// gridControlBookStocks
			// 
			gridControlBookStocks.Dock = System.Windows.Forms.DockStyle.Fill;
			gridControlBookStocks.Location = new System.Drawing.Point(0, 0);
			gridControlBookStocks.MainView = gridViewBookStocks;
			gridControlBookStocks.Name = "gridControlBookStocks";
			gridControlBookStocks.Size = new System.Drawing.Size(1199, 630);
			gridControlBookStocks.TabIndex = 0;
			gridControlBookStocks.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewBookStocks });
			gridControlBookStocks.KeyDown += gridControlBookStocks_KeyDown;
			// 
			// gridViewBookStocks
			// 
			gridViewBookStocks.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colBarcode, colBookName, colIsAvailable });
			gridViewBookStocks.GridControl = gridControlBookStocks;
			gridViewBookStocks.Name = "gridViewBookStocks";
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
			// colIsAvailable
			// 
			colIsAvailable.AccessibleName = "colIsAvailable";
			colIsAvailable.Caption = "Is Available";
			colIsAvailable.FieldName = "IsAvailable";
			colIsAvailable.MinWidth = 25;
			colIsAvailable.Name = "colIsAvailable";
			colIsAvailable.Visible = true;
			colIsAvailable.VisibleIndex = 2;
			colIsAvailable.Width = 94;
			// 
			// bar3
			// 
			bar3.BarName = "Status bar";
			bar3.DockCol = 0;
			bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
			bar3.Text = "Status bar";
			// 
			// bar2
			// 
			bar2.BarName = "Main menu";
			bar2.DockCol = 0;
			bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			bar2.Text = "Main menu";
			// 
			// bar1
			// 
			bar1.BarName = "Tools";
			bar1.DockCol = 0;
			bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			bar1.Text = "Tools";
			// 
			// barManagerBookStocks
			// 
			barManagerBookStocks.DockControls.Add(barDockControlTop);
			barManagerBookStocks.DockControls.Add(barDockControlBottom);
			barManagerBookStocks.DockControls.Add(barDockControlLeft);
			barManagerBookStocks.DockControls.Add(barDockControlRight);
			barManagerBookStocks.Form = this;
			barManagerBookStocks.Items.AddRange(new DevExpress.XtraBars.BarItem[] { btnAddBookStock, btnDeleteBook, btnGiveBookToStudent, btnNormal, btnDamaged, btnLost });
			barManagerBookStocks.MaxItemId = 6;
			// 
			// barDockControlTop
			// 
			barDockControlTop.CausesValidation = false;
			barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			barDockControlTop.Location = new System.Drawing.Point(0, 0);
			barDockControlTop.Manager = barManagerBookStocks;
			barDockControlTop.Size = new System.Drawing.Size(1199, 0);
			// 
			// barDockControlBottom
			// 
			barDockControlBottom.CausesValidation = false;
			barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			barDockControlBottom.Location = new System.Drawing.Point(0, 630);
			barDockControlBottom.Manager = barManagerBookStocks;
			barDockControlBottom.Size = new System.Drawing.Size(1199, 0);
			// 
			// barDockControlLeft
			// 
			barDockControlLeft.CausesValidation = false;
			barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			barDockControlLeft.Location = new System.Drawing.Point(0, 0);
			barDockControlLeft.Manager = barManagerBookStocks;
			barDockControlLeft.Size = new System.Drawing.Size(0, 630);
			// 
			// barDockControlRight
			// 
			barDockControlRight.CausesValidation = false;
			barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			barDockControlRight.Location = new System.Drawing.Point(1199, 0);
			barDockControlRight.Manager = barManagerBookStocks;
			barDockControlRight.Size = new System.Drawing.Size(0, 630);
			// 
			// btnAddBookStock
			// 
			btnAddBookStock.AccessibleName = "btnAddBookStock";
			btnAddBookStock.Caption = "Add Book Stock";
			btnAddBookStock.Id = 0;
			btnAddBookStock.Name = "btnAddBookStock";
			// 
			// btnDeleteBook
			// 
			btnDeleteBook.AccessibleName = "btnDeleteBook";
			btnDeleteBook.Caption = "Delete Book";
			btnDeleteBook.Id = 1;
			btnDeleteBook.Name = "btnDeleteBook";
			// 
			// btnGiveBookToStudent
			// 
			btnGiveBookToStudent.AccessibleName = "btnGiveBookToStudent";
			btnGiveBookToStudent.Caption = "Give Book to student";
			btnGiveBookToStudent.Id = 2;
			btnGiveBookToStudent.Name = "btnGiveBookToStudent";
			// 
			// popupMenuBookStocks
			// 
			popupMenuBookStocks.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(btnAddBookStock), new DevExpress.XtraBars.LinkPersistInfo(btnDeleteBook), new DevExpress.XtraBars.LinkPersistInfo(btnGiveBookToStudent), new DevExpress.XtraBars.LinkPersistInfo(btnNormal), new DevExpress.XtraBars.LinkPersistInfo(btnDamaged), new DevExpress.XtraBars.LinkPersistInfo(btnLost) });
			popupMenuBookStocks.Manager = barManagerBookStocks;
			popupMenuBookStocks.Name = "popupMenuBookStocks";
			// 
			// btnNormal
			// 
			btnNormal.AccessibleName = "btnNormal";
			btnNormal.Caption = "Normal";
			btnNormal.Id = 3;
			btnNormal.Name = "btnNormal";
			// 
			// btnDamaged
			// 
			btnDamaged.AccessibleName = "btnDamaged";
			btnDamaged.Caption = "Damaged";
			btnDamaged.Id = 4;
			btnDamaged.Name = "btnDamaged";
			// 
			// btnLost
			// 
			btnLost.AccessibleName = "btnLost";
			btnLost.Caption = "Lost";
			btnLost.Id = 5;
			btnLost.Name = "btnLost";
			// 
			// frmBookStocks
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(1199, 630);
			Controls.Add(gridControlBookStocks);
			Controls.Add(barDockControlLeft);
			Controls.Add(barDockControlRight);
			Controls.Add(barDockControlBottom);
			Controls.Add(barDockControlTop);
			Name = "frmBookStocks";
			Text = "frmBookStocks";
			((System.ComponentModel.ISupportInitialize)gridControlBookStocks).EndInit();
			((System.ComponentModel.ISupportInitialize)gridViewBookStocks).EndInit();
			((System.ComponentModel.ISupportInitialize)barManagerBookStocks).EndInit();
			((System.ComponentModel.ISupportInitialize)popupMenuBookStocks).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridControlBookStocks;
		private DevExpress.XtraGrid.Views.Grid.GridView gridViewBookStocks;
		private DevExpress.XtraGrid.Columns.GridColumn colBarcode;
		private DevExpress.XtraGrid.Columns.GridColumn colBookName;
		private DevExpress.XtraGrid.Columns.GridColumn colIsAvailable;
		private DevExpress.XtraBars.Bar bar3;
		private DevExpress.XtraBars.Bar bar2;
		private DevExpress.XtraBars.Bar bar1;
		private DevExpress.XtraBars.BarManager barManagerBookStocks;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private DevExpress.XtraBars.PopupMenu popupMenuBookStocks;
		private DevExpress.XtraBars.BarButtonItem btnAddBookStock;
		private DevExpress.XtraBars.BarButtonItem btnDeleteBook;
		private DevExpress.XtraBars.BarButtonItem btnGiveBookToStudent;
		private DevExpress.XtraBars.BarButtonItem btnNormal;
		private DevExpress.XtraBars.BarButtonItem btnDamaged;
		private DevExpress.XtraBars.BarButtonItem btnLost;
	}
}