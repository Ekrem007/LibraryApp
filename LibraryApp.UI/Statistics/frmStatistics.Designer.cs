namespace LibraryApp.UI.Statistics
{
	partial class frmStatistics
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
			gridControlStatistics1 = new DevExpress.XtraGrid.GridControl();
			gridViewStatistics1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			colMostPopularBook = new DevExpress.XtraGrid.Columns.GridColumn();
			colMostPopularAuthor = new DevExpress.XtraGrid.Columns.GridColumn();
			colMostPopularCategory = new DevExpress.XtraGrid.Columns.GridColumn();
			colTotalAuthors = new DevExpress.XtraGrid.Columns.GridColumn();
			colTotalCategories = new DevExpress.XtraGrid.Columns.GridColumn();
			colTotalStudents = new DevExpress.XtraGrid.Columns.GridColumn();
			gridControlStatistic2 = new DevExpress.XtraGrid.GridControl();
			gridViewStatistics2 = new DevExpress.XtraGrid.Views.Grid.GridView();
			colTotalBooks = new DevExpress.XtraGrid.Columns.GridColumn();
			colTotalBooksStock = new DevExpress.XtraGrid.Columns.GridColumn();
			gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
			gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
			colTotalAvailableBooks = new DevExpress.XtraGrid.Columns.GridColumn();
			colDamagedLostBooks = new DevExpress.XtraGrid.Columns.GridColumn();
			colTotalNotAvailableBooks = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)gridControlStatistics1).BeginInit();
			((System.ComponentModel.ISupportInitialize)gridViewStatistics1).BeginInit();
			((System.ComponentModel.ISupportInitialize)gridControlStatistic2).BeginInit();
			((System.ComponentModel.ISupportInitialize)gridViewStatistics2).BeginInit();
			SuspendLayout();
			// 
			// gridControlStatistics1
			// 
			gridControlStatistics1.Dock = System.Windows.Forms.DockStyle.Top;
			gridControlStatistics1.Location = new System.Drawing.Point(0, 0);
			gridControlStatistics1.MainView = gridViewStatistics1;
			gridControlStatistics1.Name = "gridControlStatistics1";
			gridControlStatistics1.Size = new System.Drawing.Size(1279, 211);
			gridControlStatistics1.TabIndex = 0;
			gridControlStatistics1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewStatistics1 });
			// 
			// gridViewStatistics1
			// 
			gridViewStatistics1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colMostPopularBook, colMostPopularAuthor, colMostPopularCategory, colTotalAuthors, colTotalCategories, colTotalStudents });
			gridViewStatistics1.GridControl = gridControlStatistics1;
			gridViewStatistics1.Name = "gridViewStatistics1";
			gridViewStatistics1.OptionsView.ShowGroupPanel = false;
			// 
			// colMostPopularBook
			// 
			colMostPopularBook.AccessibleName = "colMostPopularBook";
			colMostPopularBook.Caption = "Most Popular Book";
			colMostPopularBook.FieldName = "MostPopularBook";
			colMostPopularBook.MinWidth = 25;
			colMostPopularBook.Name = "colMostPopularBook";
			colMostPopularBook.Visible = true;
			colMostPopularBook.VisibleIndex = 0;
			colMostPopularBook.Width = 157;
			// 
			// colMostPopularAuthor
			// 
			colMostPopularAuthor.AccessibleName = "colMostPopularAuthor";
			colMostPopularAuthor.Caption = "Most Popular Author";
			colMostPopularAuthor.FieldName = "MostPopularAuthor";
			colMostPopularAuthor.MinWidth = 25;
			colMostPopularAuthor.Name = "colMostPopularAuthor";
			colMostPopularAuthor.Visible = true;
			colMostPopularAuthor.VisibleIndex = 1;
			colMostPopularAuthor.Width = 163;
			// 
			// colMostPopularCategory
			// 
			colMostPopularCategory.AccessibleName = "colMostPopularCategory";
			colMostPopularCategory.Caption = "Most Popular Category";
			colMostPopularCategory.FieldName = "MostPopularCategory";
			colMostPopularCategory.MinWidth = 25;
			colMostPopularCategory.Name = "colMostPopularCategory";
			colMostPopularCategory.Visible = true;
			colMostPopularCategory.VisibleIndex = 2;
			colMostPopularCategory.Width = 167;
			// 
			// colTotalAuthors
			// 
			colTotalAuthors.AccessibleName = "colTotalAuthors";
			colTotalAuthors.Caption = "Total Authors";
			colTotalAuthors.FieldName = "TotalAuthors";
			colTotalAuthors.MinWidth = 25;
			colTotalAuthors.Name = "colTotalAuthors";
			colTotalAuthors.Visible = true;
			colTotalAuthors.VisibleIndex = 3;
			colTotalAuthors.Width = 122;
			// 
			// colTotalCategories
			// 
			colTotalCategories.AccessibleName = "colTotalCategories";
			colTotalCategories.Caption = "Total Categories";
			colTotalCategories.FieldName = "TotalCategories";
			colTotalCategories.MinWidth = 25;
			colTotalCategories.Name = "colTotalCategories";
			colTotalCategories.Visible = true;
			colTotalCategories.VisibleIndex = 4;
			colTotalCategories.Width = 129;
			// 
			// colTotalStudents
			// 
			colTotalStudents.AccessibleName = "colTotalStudents";
			colTotalStudents.Caption = "Total Students";
			colTotalStudents.FieldName = "TotalStudents";
			colTotalStudents.MinWidth = 25;
			colTotalStudents.Name = "colTotalStudents";
			colTotalStudents.Visible = true;
			colTotalStudents.VisibleIndex = 5;
			colTotalStudents.Width = 125;
			// 
			// gridControlStatistic2
			// 
			gridControlStatistic2.Dock = System.Windows.Forms.DockStyle.Top;
			gridControlStatistic2.Location = new System.Drawing.Point(0, 211);
			gridControlStatistic2.MainView = gridViewStatistics2;
			gridControlStatistic2.Name = "gridControlStatistic2";
			gridControlStatistic2.Size = new System.Drawing.Size(1279, 277);
			gridControlStatistic2.TabIndex = 1;
			gridControlStatistic2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewStatistics2 });
			// 
			// gridViewStatistics2
			// 
			gridViewStatistics2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colTotalBooks, colTotalBooksStock, gridColumn8, gridColumn9, colTotalAvailableBooks, colDamagedLostBooks, colTotalNotAvailableBooks });
			gridViewStatistics2.GridControl = gridControlStatistic2;
			gridViewStatistics2.Name = "gridViewStatistics2";
			gridViewStatistics2.OptionsView.ShowGroupPanel = false;
			// 
			// colTotalBooks
			// 
			colTotalBooks.AccessibleName = "colTotalBooks";
			colTotalBooks.Caption = "Total Books";
			colTotalBooks.FieldName = "TotalBooks";
			colTotalBooks.MinWidth = 25;
			colTotalBooks.Name = "colTotalBooks";
			colTotalBooks.Visible = true;
			colTotalBooks.VisibleIndex = 0;
			colTotalBooks.Width = 100;
			// 
			// colTotalBooksStock
			// 
			colTotalBooksStock.AccessibleName = "colTotalBooksStock";
			colTotalBooksStock.Caption = "Total Books At Stocks";
			colTotalBooksStock.FieldName = "TotalBookStocks";
			colTotalBooksStock.MinWidth = 25;
			colTotalBooksStock.Name = "colTotalBooksStock";
			colTotalBooksStock.Visible = true;
			colTotalBooksStock.VisibleIndex = 1;
			colTotalBooksStock.Width = 94;
			// 
			// gridColumn8
			// 
			gridColumn8.AccessibleName = "colTotalBorrowedBooks";
			gridColumn8.Caption = "Tota Borrowed Books";
			gridColumn8.FieldName = "TotalBorrowedBooks";
			gridColumn8.MinWidth = 25;
			gridColumn8.Name = "gridColumn8";
			gridColumn8.Visible = true;
			gridColumn8.VisibleIndex = 3;
			gridColumn8.Width = 142;
			// 
			// gridColumn9
			// 
			gridColumn9.AccessibleName = "colTotalReturnedBooks";
			gridColumn9.Caption = "Total Returned Books";
			gridColumn9.FieldName = "TotalReturnedBooks";
			gridColumn9.MinWidth = 25;
			gridColumn9.Name = "gridColumn9";
			gridColumn9.Visible = true;
			gridColumn9.VisibleIndex = 4;
			gridColumn9.Width = 144;
			// 
			// colTotalAvailableBooks
			// 
			colTotalAvailableBooks.AccessibleName = "colTotalAvailableBooks";
			colTotalAvailableBooks.Caption = "Available Books";
			colTotalAvailableBooks.FieldName = "TotalAvailableBookStocks";
			colTotalAvailableBooks.MinWidth = 25;
			colTotalAvailableBooks.Name = "colTotalAvailableBooks";
			colTotalAvailableBooks.Visible = true;
			colTotalAvailableBooks.VisibleIndex = 2;
			colTotalAvailableBooks.Width = 94;
			// 
			// colDamagedLostBooks
			// 
			colDamagedLostBooks.AccessibleName = "colDamagedLostBooks";
			colDamagedLostBooks.Caption = "Damaged/Lost Books";
			colDamagedLostBooks.FieldName = "TotalDamagedLostBooksStock";
			colDamagedLostBooks.MinWidth = 25;
			colDamagedLostBooks.Name = "colDamagedLostBooks";
			colDamagedLostBooks.Visible = true;
			colDamagedLostBooks.VisibleIndex = 5;
			colDamagedLostBooks.Width = 94;
			// 
			// colTotalNotAvailableBooks
			// 
			colTotalNotAvailableBooks.AccessibleName = "colTotalNotAvailableBooks";
			colTotalNotAvailableBooks.Caption = " Borrowed Books";
			colTotalNotAvailableBooks.FieldName = "TotalNotAvailableBooks";
			colTotalNotAvailableBooks.MinWidth = 25;
			colTotalNotAvailableBooks.Name = "colTotalNotAvailableBooks";
			colTotalNotAvailableBooks.Visible = true;
			colTotalNotAvailableBooks.VisibleIndex = 6;
			colTotalNotAvailableBooks.Width = 94;
			// 
			// frmStatistics
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(1279, 488);
			Controls.Add(gridControlStatistic2);
			Controls.Add(gridControlStatistics1);
			Name = "frmStatistics";
			Text = "frmStatistics";
			((System.ComponentModel.ISupportInitialize)gridControlStatistics1).EndInit();
			((System.ComponentModel.ISupportInitialize)gridViewStatistics1).EndInit();
			((System.ComponentModel.ISupportInitialize)gridControlStatistic2).EndInit();
			((System.ComponentModel.ISupportInitialize)gridViewStatistics2).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridControlStatistics1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridViewStatistics1;
		private DevExpress.XtraGrid.Columns.GridColumn colMostPopularBook;
		private DevExpress.XtraGrid.Columns.GridColumn colMostPopularAuthor;
		private DevExpress.XtraGrid.Columns.GridColumn colMostPopularCategory;
		private DevExpress.XtraGrid.Columns.GridColumn colTotalAuthors;
		private DevExpress.XtraGrid.Columns.GridColumn colTotalCategories;
		private DevExpress.XtraGrid.Columns.GridColumn colTotalStudents;
		private DevExpress.XtraGrid.GridControl gridControlStatistic2;
		private DevExpress.XtraGrid.Views.Grid.GridView gridViewStatistics2;
		private DevExpress.XtraGrid.Columns.GridColumn colTotalBooks;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
		private DevExpress.XtraGrid.Columns.GridColumn colTotalBooksStock;
		private DevExpress.XtraGrid.Columns.GridColumn colTotalAvailableBooks;
		private DevExpress.XtraGrid.Columns.GridColumn colDamagedLostBooks;
		private DevExpress.XtraGrid.Columns.GridColumn colTotalNotAvailableBooks;
	}
}