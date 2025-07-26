namespace LibraryApp.UI
{
	partial class frmBooks
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			gridControlBooks = new DevExpress.XtraGrid.GridControl();
			gridViewBooks = new DevExpress.XtraGrid.Views.Grid.GridView();
			colId = new DevExpress.XtraGrid.Columns.GridColumn();
			colBookName = new DevExpress.XtraGrid.Columns.GridColumn();
			colAuthorName = new DevExpress.XtraGrid.Columns.GridColumn();
			colCategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
			colBookStock = new DevExpress.XtraGrid.Columns.GridColumn();
			colAvailableStock = new DevExpress.XtraGrid.Columns.GridColumn();
			colIsPassive = new DevExpress.XtraGrid.Columns.GridColumn();
			barManagerBooks = new DevExpress.XtraBars.BarManager(components);
			barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			btnAdBook = new DevExpress.XtraBars.BarButtonItem();
			btnUpdateBook = new DevExpress.XtraBars.BarButtonItem();
			btnDeleteBook = new DevExpress.XtraBars.BarButtonItem();
			btnRefreshData = new DevExpress.XtraBars.BarButtonItem();
			btnGiveBookToStudent = new DevExpress.XtraBars.BarButtonItem();
			popupMenuBooks = new DevExpress.XtraBars.PopupMenu(components);
			((System.ComponentModel.ISupportInitialize)gridControlBooks).BeginInit();
			((System.ComponentModel.ISupportInitialize)gridViewBooks).BeginInit();
			((System.ComponentModel.ISupportInitialize)barManagerBooks).BeginInit();
			((System.ComponentModel.ISupportInitialize)popupMenuBooks).BeginInit();
			SuspendLayout();
			// 
			// gridControlBooks
			// 
			gridControlBooks.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
			gridControlBooks.Location = new System.Drawing.Point(13, 13);
			gridControlBooks.MainView = gridViewBooks;
			gridControlBooks.Margin = new System.Windows.Forms.Padding(4);
			gridControlBooks.Name = "gridControlBooks";
			gridControlBooks.Size = new System.Drawing.Size(1041, 473);
			gridControlBooks.TabIndex = 14;
			gridControlBooks.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewBooks });
			gridControlBooks.DoubleClick += gridControlBooks_DoubleClick;
			gridControlBooks.KeyDown += gridControlBooks_KeyDown;
			// 
			// gridViewBooks
			// 
			gridViewBooks.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colId, colBookName, colAuthorName, colCategoryName, colBookStock, colAvailableStock, colIsPassive });
			gridViewBooks.DetailHeight = 431;
			gridViewBooks.GridControl = gridControlBooks;
			gridViewBooks.Name = "gridViewBooks";
			gridViewBooks.OptionsEditForm.PopupEditFormWidth = 933;
			// 
			// colId
			// 
			colId.Caption = "Id";
			colId.FieldName = "Id";
			colId.MinWidth = 25;
			colId.Name = "colId";
			colId.OptionsColumn.AllowEdit = false;
			colId.Visible = true;
			colId.VisibleIndex = 0;
			colId.Width = 94;
			// 
			// colBookName
			// 
			colBookName.Caption = "Book Name";
			colBookName.FieldName = "BookName";
			colBookName.MinWidth = 25;
			colBookName.Name = "colBookName";
			colBookName.OptionsColumn.AllowEdit = false;
			colBookName.Visible = true;
			colBookName.VisibleIndex = 1;
			colBookName.Width = 94;
			// 
			// colAuthorName
			// 
			colAuthorName.Caption = "Author Name";
			colAuthorName.FieldName = "AuthorName";
			colAuthorName.MinWidth = 25;
			colAuthorName.Name = "colAuthorName";
			colAuthorName.OptionsColumn.AllowEdit = false;
			colAuthorName.Visible = true;
			colAuthorName.VisibleIndex = 2;
			colAuthorName.Width = 94;
			// 
			// colCategoryName
			// 
			colCategoryName.Caption = "Category Name";
			colCategoryName.FieldName = "CategoryName";
			colCategoryName.MinWidth = 25;
			colCategoryName.Name = "colCategoryName";
			colCategoryName.OptionsColumn.AllowEdit = false;
			colCategoryName.Visible = true;
			colCategoryName.VisibleIndex = 3;
			colCategoryName.Width = 94;
			// 
			// colBookStock
			// 
			colBookStock.AccessibleName = "colBookStock";
			colBookStock.Caption = "Total Books at Stock";
			colBookStock.FieldName = "BookStock";
			colBookStock.MinWidth = 25;
			colBookStock.Name = "colBookStock";
			colBookStock.Visible = true;
			colBookStock.VisibleIndex = 4;
			colBookStock.Width = 94;
			// 
			// colAvailableStock
			// 
			colAvailableStock.AccessibleName = "colAvailableStock";
			colAvailableStock.Caption = "Available Stock";
			colAvailableStock.FieldName = "AvailableStock";
			colAvailableStock.MinWidth = 25;
			colAvailableStock.Name = "colAvailableStock";
			colAvailableStock.Visible = true;
			colAvailableStock.VisibleIndex = 5;
			colAvailableStock.Width = 94;
			// 
			// colIsPassive
			// 
			colIsPassive.AccessibleName = "colIsPassive";
			colIsPassive.Caption = "Passive Status";
			colIsPassive.FieldName = "IsPassive";
			colIsPassive.MinWidth = 25;
			colIsPassive.Name = "colIsPassive";
			colIsPassive.Visible = true;
			colIsPassive.VisibleIndex = 6;
			colIsPassive.Width = 94;
			// 
			// barManagerBooks
			// 
			barManagerBooks.DockControls.Add(barDockControlTop);
			barManagerBooks.DockControls.Add(barDockControlBottom);
			barManagerBooks.DockControls.Add(barDockControlLeft);
			barManagerBooks.DockControls.Add(barDockControlRight);
			barManagerBooks.Form = this;
			barManagerBooks.Items.AddRange(new DevExpress.XtraBars.BarItem[] { btnAdBook, btnUpdateBook, btnDeleteBook, btnRefreshData, btnGiveBookToStudent });
			barManagerBooks.MaxItemId = 5;
			// 
			// barDockControlTop
			// 
			barDockControlTop.CausesValidation = false;
			barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			barDockControlTop.Location = new System.Drawing.Point(0, 0);
			barDockControlTop.Manager = barManagerBooks;
			barDockControlTop.Size = new System.Drawing.Size(1234, 0);
			// 
			// barDockControlBottom
			// 
			barDockControlBottom.CausesValidation = false;
			barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			barDockControlBottom.Location = new System.Drawing.Point(0, 683);
			barDockControlBottom.Manager = barManagerBooks;
			barDockControlBottom.Size = new System.Drawing.Size(1234, 0);
			// 
			// barDockControlLeft
			// 
			barDockControlLeft.CausesValidation = false;
			barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			barDockControlLeft.Location = new System.Drawing.Point(0, 0);
			barDockControlLeft.Manager = barManagerBooks;
			barDockControlLeft.Size = new System.Drawing.Size(0, 683);
			// 
			// barDockControlRight
			// 
			barDockControlRight.CausesValidation = false;
			barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			barDockControlRight.Location = new System.Drawing.Point(1234, 0);
			barDockControlRight.Manager = barManagerBooks;
			barDockControlRight.Size = new System.Drawing.Size(0, 683);
			// 
			// btnAdBook
			// 
			btnAdBook.AccessibleName = "btnAddBook";
			btnAdBook.Caption = "➕   Add Book";
			btnAdBook.Id = 0;
			btnAdBook.Name = "btnAdBook";
			// 
			// btnUpdateBook
			// 
			btnUpdateBook.AccessibleName = "btnUpdateBook";
			btnUpdateBook.Caption = "🔄 Update Book";
			btnUpdateBook.Id = 1;
			btnUpdateBook.Name = "btnUpdateBook";
			// 
			// btnDeleteBook
			// 
			btnDeleteBook.AccessibleName = "btnDeleteBook";
			btnDeleteBook.Caption = "❌   Delete Book";
			btnDeleteBook.Id = 2;
			btnDeleteBook.Name = "btnDeleteBook";
			// 
			// btnRefreshData
			// 
			btnRefreshData.AccessibleName = "btnRefreshData";
			btnRefreshData.Caption = "🔄  Yenile";
			btnRefreshData.Id = 3;
			btnRefreshData.Name = "btnRefreshData";
			// 
			// btnGiveBookToStudent
			// 
			btnGiveBookToStudent.AccessibleName = "btnGiveBookToStudent";
			btnGiveBookToStudent.Caption = "Give Book to Student";
			btnGiveBookToStudent.Id = 4;
			btnGiveBookToStudent.Name = "btnGiveBookToStudent";
			// 
			// popupMenuBooks
			// 
			popupMenuBooks.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(btnAdBook), new DevExpress.XtraBars.LinkPersistInfo(btnUpdateBook), new DevExpress.XtraBars.LinkPersistInfo(btnDeleteBook), new DevExpress.XtraBars.LinkPersistInfo(btnRefreshData), new DevExpress.XtraBars.LinkPersistInfo(btnGiveBookToStudent) });
			popupMenuBooks.Manager = barManagerBooks;
			popupMenuBooks.Name = "popupMenuBooks";
			// 
			// frmBooks
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(1234, 683);
			Controls.Add(gridControlBooks);
			Controls.Add(barDockControlLeft);
			Controls.Add(barDockControlRight);
			Controls.Add(barDockControlBottom);
			Controls.Add(barDockControlTop);
			Location = new System.Drawing.Point(150, 0);
			Margin = new System.Windows.Forms.Padding(4);
			Name = "frmBooks";
			Text = "Books Management";
			((System.ComponentModel.ISupportInitialize)gridControlBooks).EndInit();
			((System.ComponentModel.ISupportInitialize)gridViewBooks).EndInit();
			((System.ComponentModel.ISupportInitialize)barManagerBooks).EndInit();
			((System.ComponentModel.ISupportInitialize)popupMenuBooks).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private DevExpress.XtraGrid.GridControl gridControlBooks;
		private DevExpress.XtraGrid.Views.Grid.GridView gridViewBooks;
		private DevExpress.XtraGrid.Columns.GridColumn colId;
		private DevExpress.XtraGrid.Columns.GridColumn colBookName;
		private DevExpress.XtraGrid.Columns.GridColumn colAuthorName;
		private DevExpress.XtraGrid.Columns.GridColumn colCategoryName;
		private DevExpress.XtraBars.BarManager barManagerBooks;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private DevExpress.XtraBars.PopupMenu popupMenuBooks;
		private DevExpress.XtraBars.BarButtonItem btnAdBook;
		private DevExpress.XtraBars.BarButtonItem btnUpdateBook;
		private DevExpress.XtraBars.BarButtonItem btnDeleteBook;
		private DevExpress.XtraBars.BarButtonItem btnRefreshData;
		private DevExpress.XtraBars.BarButtonItem btnGiveBookToStudent;
		private DevExpress.XtraGrid.Columns.GridColumn colBookStock;
		private DevExpress.XtraGrid.Columns.GridColumn colAvailableStock;
		private DevExpress.XtraGrid.Columns.GridColumn colIsPassive;
	}
}