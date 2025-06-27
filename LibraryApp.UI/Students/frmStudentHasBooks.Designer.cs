namespace LibraryApp.UI.Students
{
	partial class frmStudentHasBooks
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
			gridControlStudentsHasBooks = new DevExpress.XtraGrid.GridControl();
			gridViewStudentsHasBooks = new DevExpress.XtraGrid.Views.Grid.GridView();
			colStudentName = new DevExpress.XtraGrid.Columns.GridColumn();
			colBookName = new DevExpress.XtraGrid.Columns.GridColumn();
			colBorrowDate = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)gridControlStudentsHasBooks).BeginInit();
			((System.ComponentModel.ISupportInitialize)gridViewStudentsHasBooks).BeginInit();
			SuspendLayout();
			// 
			// gridControlStudentsHasBooks
			// 
			gridControlStudentsHasBooks.Dock = System.Windows.Forms.DockStyle.Fill;
			gridControlStudentsHasBooks.Location = new System.Drawing.Point(0, 0);
			gridControlStudentsHasBooks.MainView = gridViewStudentsHasBooks;
			gridControlStudentsHasBooks.Name = "gridControlStudentsHasBooks";
			gridControlStudentsHasBooks.Size = new System.Drawing.Size(805, 508);
			gridControlStudentsHasBooks.TabIndex = 0;
			gridControlStudentsHasBooks.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewStudentsHasBooks });
			// 
			// gridViewStudentsHasBooks
			// 
			gridViewStudentsHasBooks.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colStudentName, colBookName, colBorrowDate });
			gridViewStudentsHasBooks.GridControl = gridControlStudentsHasBooks;
			gridViewStudentsHasBooks.Name = "gridViewStudentsHasBooks";
			// 
			// colStudentName
			// 
			colStudentName.Caption = "Student Name";
			colStudentName.FieldName = "StudentName";
			colStudentName.MinWidth = 25;
			colStudentName.Name = "colStudentName";
			colStudentName.Visible = true;
			colStudentName.VisibleIndex = 0;
			colStudentName.Width = 94;
			// 
			// colBookName
			// 
			colBookName.Caption = "Book Name";
			colBookName.FieldName = "BookName";
			colBookName.MinWidth = 25;
			colBookName.Name = "colBookName";
			colBookName.Visible = true;
			colBookName.VisibleIndex = 1;
			colBookName.Width = 94;
			// 
			// colBorrowDate
			// 
			colBorrowDate.Caption = "BorrowDate";
			colBorrowDate.FieldName = "BorrowDate";
			colBorrowDate.MinWidth = 25;
			colBorrowDate.Name = "colBorrowDate";
			colBorrowDate.Visible = true;
			colBorrowDate.VisibleIndex = 2;
			colBorrowDate.Width = 94;
			// 
			// frmStudentHasBooks
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(805, 508);
			Controls.Add(gridControlStudentsHasBooks);
			Name = "frmStudentHasBooks";
			StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "frmStudentHasBooks";
			((System.ComponentModel.ISupportInitialize)gridControlStudentsHasBooks).EndInit();
			((System.ComponentModel.ISupportInitialize)gridViewStudentsHasBooks).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridControlStudentsHasBooks;
		private DevExpress.XtraGrid.Views.Grid.GridView gridViewStudentsHasBooks;
		private DevExpress.XtraGrid.Columns.GridColumn colStudentName;
		private DevExpress.XtraGrid.Columns.GridColumn colBookName;
		private DevExpress.XtraGrid.Columns.GridColumn colBorrowDate;
	}
}