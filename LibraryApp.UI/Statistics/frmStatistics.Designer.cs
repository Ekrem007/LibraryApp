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
			gridControlStatistics = new DevExpress.XtraGrid.GridControl();
			gridViewStatistics = new DevExpress.XtraGrid.Views.Grid.GridView();
			colMostPopularBook = new DevExpress.XtraGrid.Columns.GridColumn();
			colMostPopularAuthor = new DevExpress.XtraGrid.Columns.GridColumn();
			colMostPopularCategory = new DevExpress.XtraGrid.Columns.GridColumn();
			colTotalBooks = new DevExpress.XtraGrid.Columns.GridColumn();
			colTotalAuthors = new DevExpress.XtraGrid.Columns.GridColumn();
			colTotalCategories = new DevExpress.XtraGrid.Columns.GridColumn();
			colTotalStudents = new DevExpress.XtraGrid.Columns.GridColumn();
			colTotalBorrowedBooks = new DevExpress.XtraGrid.Columns.GridColumn();
			colTotalReturnedBooks = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)gridControlStatistics).BeginInit();
			((System.ComponentModel.ISupportInitialize)gridViewStatistics).BeginInit();
			SuspendLayout();
			// 
			// gridControlStatistics
			// 
			gridControlStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
			gridControlStatistics.Location = new System.Drawing.Point(0, 0);
			gridControlStatistics.MainView = gridViewStatistics;
			gridControlStatistics.Name = "gridControlStatistics";
			gridControlStatistics.Size = new System.Drawing.Size(1279, 488);
			gridControlStatistics.TabIndex = 0;
			gridControlStatistics.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewStatistics });
			// 
			// gridViewStatistics
			// 
			gridViewStatistics.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colMostPopularBook, colMostPopularAuthor, colMostPopularCategory, colTotalBooks, colTotalAuthors, colTotalCategories, colTotalStudents, colTotalBorrowedBooks, colTotalReturnedBooks });
			gridViewStatistics.GridControl = gridControlStatistics;
			gridViewStatistics.Name = "gridViewStatistics";
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
			// colTotalBooks
			// 
			colTotalBooks.AccessibleName = "colTotalBooks";
			colTotalBooks.Caption = "Total Books";
			colTotalBooks.FieldName = "TotalBooks";
			colTotalBooks.MinWidth = 25;
			colTotalBooks.Name = "colTotalBooks";
			colTotalBooks.Visible = true;
			colTotalBooks.VisibleIndex = 3;
			colTotalBooks.Width = 100;
			// 
			// colTotalAuthors
			// 
			colTotalAuthors.AccessibleName = "colTotalAuthors";
			colTotalAuthors.Caption = "Total Authors";
			colTotalAuthors.FieldName = "TotalAuthors";
			colTotalAuthors.MinWidth = 25;
			colTotalAuthors.Name = "colTotalAuthors";
			colTotalAuthors.Visible = true;
			colTotalAuthors.VisibleIndex = 4;
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
			colTotalCategories.VisibleIndex = 5;
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
			colTotalStudents.VisibleIndex = 6;
			colTotalStudents.Width = 125;
			// 
			// colTotalBorrowedBooks
			// 
			colTotalBorrowedBooks.AccessibleName = "colTotalBorrowedBooks";
			colTotalBorrowedBooks.Caption = "Tota Borrowed Books";
			colTotalBorrowedBooks.FieldName = "TotalBorrowedBooks";
			colTotalBorrowedBooks.MinWidth = 25;
			colTotalBorrowedBooks.Name = "colTotalBorrowedBooks";
			colTotalBorrowedBooks.Visible = true;
			colTotalBorrowedBooks.VisibleIndex = 7;
			colTotalBorrowedBooks.Width = 142;
			// 
			// colTotalReturnedBooks
			// 
			colTotalReturnedBooks.AccessibleName = "colTotalReturnedBooks";
			colTotalReturnedBooks.Caption = "Total Returned Books";
			colTotalReturnedBooks.FieldName = "TotalReturnedBooks";
			colTotalReturnedBooks.MinWidth = 25;
			colTotalReturnedBooks.Name = "colTotalReturnedBooks";
			colTotalReturnedBooks.Visible = true;
			colTotalReturnedBooks.VisibleIndex = 8;
			colTotalReturnedBooks.Width = 144;
			// 
			// frmStatistics
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(1279, 488);
			Controls.Add(gridControlStatistics);
			Name = "frmStatistics";
			Text = "frmStatistics";
			((System.ComponentModel.ISupportInitialize)gridControlStatistics).EndInit();
			((System.ComponentModel.ISupportInitialize)gridViewStatistics).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridControlStatistics;
		private DevExpress.XtraGrid.Views.Grid.GridView gridViewStatistics;
		private DevExpress.XtraGrid.Columns.GridColumn colMostPopularBook;
		private DevExpress.XtraGrid.Columns.GridColumn colMostPopularAuthor;
		private DevExpress.XtraGrid.Columns.GridColumn colMostPopularCategory;
		private DevExpress.XtraGrid.Columns.GridColumn colTotalBooks;
		private DevExpress.XtraGrid.Columns.GridColumn colTotalAuthors;
		private DevExpress.XtraGrid.Columns.GridColumn colTotalCategories;
		private DevExpress.XtraGrid.Columns.GridColumn colTotalStudents;
		private DevExpress.XtraGrid.Columns.GridColumn colTotalBorrowedBooks;
		private DevExpress.XtraGrid.Columns.GridColumn colTotalReturnedBooks;
	}
}