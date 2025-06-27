namespace LibraryApp.UI.Categories
{
	partial class frmCategoryHasBooks
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
			gridControlCategoryHasBooks = new DevExpress.XtraGrid.GridControl();
			gridViewCategoryHasBooks = new DevExpress.XtraGrid.Views.Grid.GridView();
			colCategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
			colBookName = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)gridControlCategoryHasBooks).BeginInit();
			((System.ComponentModel.ISupportInitialize)gridViewCategoryHasBooks).BeginInit();
			SuspendLayout();
			// 
			// gridControlCategoryHasBooks
			// 
			gridControlCategoryHasBooks.AccessibleName = "gridControlCategoryHasBooks";
			gridControlCategoryHasBooks.Dock = System.Windows.Forms.DockStyle.Fill;
			gridControlCategoryHasBooks.Location = new System.Drawing.Point(0, 0);
			gridControlCategoryHasBooks.MainView = gridViewCategoryHasBooks;
			gridControlCategoryHasBooks.Name = "gridControlCategoryHasBooks";
			gridControlCategoryHasBooks.Size = new System.Drawing.Size(901, 501);
			gridControlCategoryHasBooks.TabIndex = 0;
			gridControlCategoryHasBooks.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewCategoryHasBooks });
			// 
			// gridViewCategoryHasBooks
			// 
			gridViewCategoryHasBooks.AccessibleName = "CategoryHasBooks";
			gridViewCategoryHasBooks.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colCategoryName, colBookName });
			gridViewCategoryHasBooks.GridControl = gridControlCategoryHasBooks;
			gridViewCategoryHasBooks.Name = "gridViewCategoryHasBooks";
			// 
			// colCategoryName
			// 
			colCategoryName.AccessibleName = "colCategoryName";
			colCategoryName.Caption = "Category Name";
			colCategoryName.FieldName = "CategoryName";
			colCategoryName.MinWidth = 25;
			colCategoryName.Name = "colCategoryName";
			colCategoryName.Visible = true;
			colCategoryName.VisibleIndex = 0;
			colCategoryName.Width = 94;
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
			// frmCategoryHasBooks
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(901, 501);
			Controls.Add(gridControlCategoryHasBooks);
			Name = "frmCategoryHasBooks";
			StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "frmCategoryHasBooks";
			((System.ComponentModel.ISupportInitialize)gridControlCategoryHasBooks).EndInit();
			((System.ComponentModel.ISupportInitialize)gridViewCategoryHasBooks).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridControlCategoryHasBooks;
		private DevExpress.XtraGrid.Views.Grid.GridView gridViewCategoryHasBooks;
		private DevExpress.XtraGrid.Columns.GridColumn colCategoryName;
		private DevExpress.XtraGrid.Columns.GridColumn colBookName;
	}
}