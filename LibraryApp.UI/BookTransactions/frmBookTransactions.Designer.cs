namespace LibraryApp.UI.frmBookTransaction
{
	partial class frmBookTransactions
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
			gridControlBookTransferOperations = new DevExpress.XtraGrid.GridControl();
			gridViewBookTransferOperations = new DevExpress.XtraGrid.Views.Grid.GridView();
			colId = new DevExpress.XtraGrid.Columns.GridColumn();
			colStudentName = new DevExpress.XtraGrid.Columns.GridColumn();
			colBookName = new DevExpress.XtraGrid.Columns.GridColumn();
			colBorrowedDate = new DevExpress.XtraGrid.Columns.GridColumn();
			colReturnDate = new DevExpress.XtraGrid.Columns.GridColumn();
			barManagerBookTransactions = new DevExpress.XtraBars.BarManager(components);
			barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			btnUpdateBookTransaction = new DevExpress.XtraBars.BarButtonItem();
			btnGiveBookToStudent = new DevExpress.XtraBars.BarButtonItem();
			btnDeleteBookTransaction = new DevExpress.XtraBars.BarButtonItem();
			btnRefreshData = new DevExpress.XtraBars.BarButtonItem();
			btnReturnBook = new DevExpress.XtraBars.BarButtonItem();
			popupMenuBookTransactions = new DevExpress.XtraBars.PopupMenu(components);
			colAuthorName = new DevExpress.XtraGrid.Columns.GridColumn();
			colBarcode = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)gridControlBookTransferOperations).BeginInit();
			((System.ComponentModel.ISupportInitialize)gridViewBookTransferOperations).BeginInit();
			((System.ComponentModel.ISupportInitialize)barManagerBookTransactions).BeginInit();
			((System.ComponentModel.ISupportInitialize)popupMenuBookTransactions).BeginInit();
			SuspendLayout();
			// 
			// gridControlBookTransferOperations
			// 
			gridControlBookTransferOperations.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
			gridControlBookTransferOperations.Location = new System.Drawing.Point(13, 13);
			gridControlBookTransferOperations.MainView = gridViewBookTransferOperations;
			gridControlBookTransferOperations.Margin = new System.Windows.Forms.Padding(4);
			gridControlBookTransferOperations.Name = "gridControlBookTransferOperations";
			gridControlBookTransferOperations.Size = new System.Drawing.Size(1035, 452);
			gridControlBookTransferOperations.TabIndex = 24;
			gridControlBookTransferOperations.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewBookTransferOperations });
			gridControlBookTransferOperations.KeyDown += gridControlBookTransferOperations_KeyDown;
			// 
			// gridViewBookTransferOperations
			// 
			gridViewBookTransferOperations.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colId, colStudentName, colBookName, colBorrowedDate, colReturnDate, colAuthorName, colBarcode });
			gridViewBookTransferOperations.DetailHeight = 431;
			gridViewBookTransferOperations.GridControl = gridControlBookTransferOperations;
			gridViewBookTransferOperations.Name = "gridViewBookTransferOperations";
			gridViewBookTransferOperations.OptionsBehavior.Editable = false;
			gridViewBookTransferOperations.OptionsEditForm.PopupEditFormWidth = 933;
			// 
			// colId
			// 
			colId.AccessibleName = "colId";
			colId.Caption = "Id";
			colId.FieldName = "Id";
			colId.MinWidth = 25;
			colId.Name = "colId";
			colId.OptionsColumn.AllowEdit = false;
			colId.Visible = true;
			colId.VisibleIndex = 0;
			colId.Width = 94;
			// 
			// colStudentName
			// 
			colStudentName.AccessibleName = "colStudentName";
			colStudentName.Caption = "Student Name";
			colStudentName.FieldName = "StudentName";
			colStudentName.MinWidth = 25;
			colStudentName.Name = "colStudentName";
			colStudentName.OptionsColumn.AllowEdit = false;
			colStudentName.Visible = true;
			colStudentName.VisibleIndex = 1;
			colStudentName.Width = 94;
			// 
			// colBookName
			// 
			colBookName.AccessibleName = "colBookName";
			colBookName.Caption = "Book Name";
			colBookName.FieldName = "BookName";
			colBookName.MinWidth = 25;
			colBookName.Name = "colBookName";
			colBookName.OptionsColumn.AllowEdit = false;
			colBookName.Visible = true;
			colBookName.VisibleIndex = 2;
			colBookName.Width = 94;
			// 
			// colBorrowedDate
			// 
			colBorrowedDate.AccessibleName = "colBorrowedDate";
			colBorrowedDate.Caption = "Borrowed Time";
			colBorrowedDate.FieldName = "BorrowedDate";
			colBorrowedDate.MinWidth = 25;
			colBorrowedDate.Name = "colBorrowedDate";
			colBorrowedDate.OptionsColumn.AllowEdit = false;
			colBorrowedDate.Visible = true;
			colBorrowedDate.VisibleIndex = 3;
			colBorrowedDate.Width = 94;
			// 
			// colReturnDate
			// 
			colReturnDate.AccessibleName = "colReturnDate";
			colReturnDate.Caption = "Returned Date";
			colReturnDate.FieldName = "ReturnDate";
			colReturnDate.MinWidth = 25;
			colReturnDate.Name = "colReturnDate";
			colReturnDate.OptionsColumn.AllowEdit = false;
			colReturnDate.Visible = true;
			colReturnDate.VisibleIndex = 4;
			colReturnDate.Width = 94;
			// 
			// barManagerBookTransactions
			// 
			barManagerBookTransactions.DockControls.Add(barDockControlTop);
			barManagerBookTransactions.DockControls.Add(barDockControlBottom);
			barManagerBookTransactions.DockControls.Add(barDockControlLeft);
			barManagerBookTransactions.DockControls.Add(barDockControlRight);
			barManagerBookTransactions.Form = this;
			barManagerBookTransactions.Items.AddRange(new DevExpress.XtraBars.BarItem[] { btnUpdateBookTransaction, btnGiveBookToStudent, btnDeleteBookTransaction, btnRefreshData, btnReturnBook });
			barManagerBookTransactions.MaxItemId = 5;
			// 
			// barDockControlTop
			// 
			barDockControlTop.CausesValidation = false;
			barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			barDockControlTop.Location = new System.Drawing.Point(0, 0);
			barDockControlTop.Manager = barManagerBookTransactions;
			barDockControlTop.Size = new System.Drawing.Size(1053, 0);
			// 
			// barDockControlBottom
			// 
			barDockControlBottom.CausesValidation = false;
			barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			barDockControlBottom.Location = new System.Drawing.Point(0, 622);
			barDockControlBottom.Manager = barManagerBookTransactions;
			barDockControlBottom.Size = new System.Drawing.Size(1053, 0);
			// 
			// barDockControlLeft
			// 
			barDockControlLeft.CausesValidation = false;
			barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			barDockControlLeft.Location = new System.Drawing.Point(0, 0);
			barDockControlLeft.Manager = barManagerBookTransactions;
			barDockControlLeft.Size = new System.Drawing.Size(0, 622);
			// 
			// barDockControlRight
			// 
			barDockControlRight.CausesValidation = false;
			barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			barDockControlRight.Location = new System.Drawing.Point(1053, 0);
			barDockControlRight.Manager = barManagerBookTransactions;
			barDockControlRight.Size = new System.Drawing.Size(0, 622);
			// 
			// btnUpdateBookTransaction
			// 
			btnUpdateBookTransaction.AccessibleName = "btnUpdateBookTransaction";
			btnUpdateBookTransaction.Caption = "🔄 Update Book Transaction";
			btnUpdateBookTransaction.Id = 0;
			btnUpdateBookTransaction.Name = "btnUpdateBookTransaction";
			// 
			// btnGiveBookToStudent
			// 
			btnGiveBookToStudent.AccessibleName = "btnGiveBookToStudent";
			btnGiveBookToStudent.Caption = "➕   Give Book To Student";
			btnGiveBookToStudent.Id = 1;
			btnGiveBookToStudent.Name = "btnGiveBookToStudent";
			// 
			// btnDeleteBookTransaction
			// 
			btnDeleteBookTransaction.AccessibleName = "btnDeleteBookTransaction";
			btnDeleteBookTransaction.Caption = "❌   Delete Book Transaction";
			btnDeleteBookTransaction.Id = 2;
			btnDeleteBookTransaction.Name = "btnDeleteBookTransaction";
			// 
			// btnRefreshData
			// 
			btnRefreshData.AccessibleName = "btnRefreshData";
			btnRefreshData.Caption = "🔄 Yenile";
			btnRefreshData.Id = 3;
			btnRefreshData.Name = "btnRefreshData";
			// 
			// btnReturnBook
			// 
			btnReturnBook.AccessibleName = "btnReturnBook";
			btnReturnBook.Caption = "🔙 Return Book";
			btnReturnBook.Id = 4;
			btnReturnBook.Name = "btnReturnBook";
			// 
			// popupMenuBookTransactions
			// 
			popupMenuBookTransactions.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(btnUpdateBookTransaction), new DevExpress.XtraBars.LinkPersistInfo(btnGiveBookToStudent), new DevExpress.XtraBars.LinkPersistInfo(btnDeleteBookTransaction), new DevExpress.XtraBars.LinkPersistInfo(btnRefreshData), new DevExpress.XtraBars.LinkPersistInfo(btnReturnBook) });
			popupMenuBookTransactions.Manager = barManagerBookTransactions;
			popupMenuBookTransactions.Name = "popupMenuBookTransactions";
			// 
			// colAuthorName
			// 
			colAuthorName.AccessibleName = "colAuthorName";
			colAuthorName.Caption = "Author Name";
			colAuthorName.FieldName = "AuthorName";
			colAuthorName.MinWidth = 25;
			colAuthorName.Name = "colAuthorName";
			colAuthorName.Visible = true;
			colAuthorName.VisibleIndex = 5;
			colAuthorName.Width = 94;
			// 
			// colBarcode
			// 
			colBarcode.AccessibleName = "colBarcode";
			colBarcode.Caption = "Barcode";
			colBarcode.FieldName = "Barcode";
			colBarcode.MinWidth = 25;
			colBarcode.Name = "colBarcode";
			colBarcode.Visible = true;
			colBarcode.VisibleIndex = 6;
			colBarcode.Width = 94;
			// 
			// frmBookTransactions
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(1053, 622);
			Controls.Add(gridControlBookTransferOperations);
			Controls.Add(barDockControlLeft);
			Controls.Add(barDockControlRight);
			Controls.Add(barDockControlBottom);
			Controls.Add(barDockControlTop);
			Name = "frmBookTransactions";
			Text = "frmBookTransactions";
			DoubleClick += frmBookTransactions_DoubleClick;
			((System.ComponentModel.ISupportInitialize)gridControlBookTransferOperations).EndInit();
			((System.ComponentModel.ISupportInitialize)gridViewBookTransferOperations).EndInit();
			((System.ComponentModel.ISupportInitialize)barManagerBookTransactions).EndInit();
			((System.ComponentModel.ISupportInitialize)popupMenuBookTransactions).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private DevExpress.XtraGrid.GridControl gridControlBookTransferOperations;
		private DevExpress.XtraGrid.Views.Grid.GridView gridViewBookTransferOperations;
		private DevExpress.XtraGrid.Columns.GridColumn colId;
		private DevExpress.XtraGrid.Columns.GridColumn colStudentName;
		private DevExpress.XtraGrid.Columns.GridColumn colBookName;
		private DevExpress.XtraGrid.Columns.GridColumn colBorrowedDate;
		private DevExpress.XtraGrid.Columns.GridColumn colReturnDate;
		private DevExpress.XtraBars.BarManager barManagerBookTransactions;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private DevExpress.XtraBars.PopupMenu popupMenuBookTransactions;
		private DevExpress.XtraBars.BarButtonItem btnUpdateBookTransaction;
		private DevExpress.XtraBars.BarButtonItem btnGiveBookToStudent;
		private DevExpress.XtraBars.BarButtonItem btnDeleteBookTransaction;
		private DevExpress.XtraBars.BarButtonItem btnRefreshData;
		private DevExpress.XtraBars.BarButtonItem btnReturnBook;
		private DevExpress.XtraGrid.Columns.GridColumn colAuthorName;
		private DevExpress.XtraGrid.Columns.GridColumn colBarcode;
	}
}