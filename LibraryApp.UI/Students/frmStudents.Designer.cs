namespace LibraryApp.UI.frmStudents
{
	partial class frmStudents
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
			gridControlStudents = new DevExpress.XtraGrid.GridControl();
			gridViewStudents = new DevExpress.XtraGrid.Views.Grid.GridView();
			colId = new DevExpress.XtraGrid.Columns.GridColumn();
			clmName = new DevExpress.XtraGrid.Columns.GridColumn();
			clmPhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
			colStudentNumber = new DevExpress.XtraGrid.Columns.GridColumn();
			colLastBorrowedBook = new DevExpress.XtraGrid.Columns.GridColumn();
			colTotalBorrowedBookCount = new DevExpress.XtraGrid.Columns.GridColumn();
			colFavoriteCategory = new DevExpress.XtraGrid.Columns.GridColumn();
			colAverageReturnedBookTime = new DevExpress.XtraGrid.Columns.GridColumn();
			barManagerStudents = new DevExpress.XtraBars.BarManager(components);
			bar1 = new DevExpress.XtraBars.Bar();
			bar2 = new DevExpress.XtraBars.Bar();
			bar3 = new DevExpress.XtraBars.Bar();
			barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			btnAddStudent = new DevExpress.XtraBars.BarButtonItem();
			btnUpdateStudent = new DevExpress.XtraBars.BarButtonItem();
			btnDeleteStudent = new DevExpress.XtraBars.BarButtonItem();
			btnRefresh = new DevExpress.XtraBars.BarButtonItem();
			btnGetStudentHasBooks = new DevExpress.XtraBars.BarButtonItem();
			popupMenuStudents = new DevExpress.XtraBars.PopupMenu(components);
			((System.ComponentModel.ISupportInitialize)gridControlStudents).BeginInit();
			((System.ComponentModel.ISupportInitialize)gridViewStudents).BeginInit();
			((System.ComponentModel.ISupportInitialize)barManagerStudents).BeginInit();
			((System.ComponentModel.ISupportInitialize)popupMenuStudents).BeginInit();
			SuspendLayout();
			// 
			// gridControlStudents
			// 
			gridControlStudents.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
			gridControlStudents.Location = new System.Drawing.Point(15, 13);
			gridControlStudents.MainView = gridViewStudents;
			gridControlStudents.Margin = new System.Windows.Forms.Padding(4);
			gridControlStudents.Name = "gridControlStudents";
			gridControlStudents.Size = new System.Drawing.Size(1046, 504);
			gridControlStudents.TabIndex = 14;
			gridControlStudents.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewStudents });
			gridControlStudents.DoubleClick += gridControlStudents_DoubleClick;
			// 
			// gridViewStudents
			// 
			gridViewStudents.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colId, clmName, clmPhoneNumber, colStudentNumber, colLastBorrowedBook, colTotalBorrowedBookCount, colFavoriteCategory, colAverageReturnedBookTime });
			gridViewStudents.DetailHeight = 431;
			gridViewStudents.GridControl = gridControlStudents;
			gridViewStudents.Name = "gridViewStudents";
			gridViewStudents.OptionsEditForm.PopupEditFormWidth = 933;
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
			// clmName
			// 
			clmName.AccessibleName = "clmName";
			clmName.Caption = "Name";
			clmName.FieldName = "Name";
			clmName.MinWidth = 25;
			clmName.Name = "clmName";
			clmName.OptionsColumn.AllowEdit = false;
			clmName.Visible = true;
			clmName.VisibleIndex = 1;
			clmName.Width = 94;
			// 
			// clmPhoneNumber
			// 
			clmPhoneNumber.AccessibleName = "clmPhoneNumber";
			clmPhoneNumber.Caption = "Phone Number";
			clmPhoneNumber.FieldName = "PhoneNumber";
			clmPhoneNumber.MinWidth = 25;
			clmPhoneNumber.Name = "clmPhoneNumber";
			clmPhoneNumber.OptionsColumn.AllowEdit = false;
			clmPhoneNumber.Visible = true;
			clmPhoneNumber.VisibleIndex = 2;
			clmPhoneNumber.Width = 94;
			// 
			// colStudentNumber
			// 
			colStudentNumber.AccessibleName = "colStudentNumber";
			colStudentNumber.Caption = "Student Number";
			colStudentNumber.FieldName = "StudentNumber";
			colStudentNumber.MinWidth = 25;
			colStudentNumber.Name = "colStudentNumber";
			colStudentNumber.Visible = true;
			colStudentNumber.VisibleIndex = 3;
			colStudentNumber.Width = 94;
			// 
			// colLastBorrowedBook
			// 
			colLastBorrowedBook.AccessibleName = "colLastBorrowedBook";
			colLastBorrowedBook.Caption = "Last Borrowed Book";
			colLastBorrowedBook.FieldName = "LastBorrowedBookName";
			colLastBorrowedBook.MinWidth = 25;
			colLastBorrowedBook.Name = "colLastBorrowedBook";
			colLastBorrowedBook.OptionsColumn.AllowEdit = false;
			colLastBorrowedBook.Visible = true;
			colLastBorrowedBook.VisibleIndex = 4;
			colLastBorrowedBook.Width = 94;
			// 
			// colTotalBorrowedBookCount
			// 
			colTotalBorrowedBookCount.AccessibleName = "colTotalBorrowedBookCount";
			colTotalBorrowedBookCount.AppearanceCell.Options.UseTextOptions = true;
			colTotalBorrowedBookCount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
			colTotalBorrowedBookCount.Caption = "Total Borrowed Books";
			colTotalBorrowedBookCount.FieldName = "TotalBorrowedBookCount";
			colTotalBorrowedBookCount.MinWidth = 25;
			colTotalBorrowedBookCount.Name = "colTotalBorrowedBookCount";
			colTotalBorrowedBookCount.OptionsColumn.AllowEdit = false;
			colTotalBorrowedBookCount.Visible = true;
			colTotalBorrowedBookCount.VisibleIndex = 5;
			colTotalBorrowedBookCount.Width = 94;
			// 
			// colFavoriteCategory
			// 
			colFavoriteCategory.AccessibleName = "colFavoriteCategory";
			colFavoriteCategory.Caption = "Favorite Category";
			colFavoriteCategory.FieldName = "FavoriteCategory";
			colFavoriteCategory.MinWidth = 25;
			colFavoriteCategory.Name = "colFavoriteCategory";
			colFavoriteCategory.Visible = true;
			colFavoriteCategory.VisibleIndex = 6;
			colFavoriteCategory.Width = 94;
			// 
			// colAverageReturnedBookTime
			// 
			colAverageReturnedBookTime.AccessibleName = "colAverageReturnedBookTime";
			colAverageReturnedBookTime.AppearanceCell.Options.UseTextOptions = true;
			colAverageReturnedBookTime.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
			colAverageReturnedBookTime.Caption = "Avarage Returned Book  Time";
			colAverageReturnedBookTime.DisplayFormat.FormatString = "N1";
			colAverageReturnedBookTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			colAverageReturnedBookTime.FieldName = "AverageReadingDays";
			colAverageReturnedBookTime.MinWidth = 25;
			colAverageReturnedBookTime.Name = "colAverageReturnedBookTime";
			colAverageReturnedBookTime.OptionsColumn.AllowEdit = false;
			colAverageReturnedBookTime.Visible = true;
			colAverageReturnedBookTime.VisibleIndex = 7;
			colAverageReturnedBookTime.Width = 94;
			// 
			// barManagerStudents
			// 
			barManagerStudents.Bars.AddRange(new DevExpress.XtraBars.Bar[] { bar1, bar2, bar3 });
			barManagerStudents.DockControls.Add(barDockControlTop);
			barManagerStudents.DockControls.Add(barDockControlBottom);
			barManagerStudents.DockControls.Add(barDockControlLeft);
			barManagerStudents.DockControls.Add(barDockControlRight);
			barManagerStudents.Form = this;
			barManagerStudents.Items.AddRange(new DevExpress.XtraBars.BarItem[] { btnAddStudent, btnUpdateStudent, btnDeleteStudent, btnRefresh, btnGetStudentHasBooks });
			barManagerStudents.MainMenu = bar2;
			barManagerStudents.MaxItemId = 5;
			barManagerStudents.StatusBar = bar3;
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
			barDockControlTop.Manager = barManagerStudents;
			barDockControlTop.Size = new System.Drawing.Size(1074, 41);
			// 
			// barDockControlBottom
			// 
			barDockControlBottom.CausesValidation = false;
			barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			barDockControlBottom.Location = new System.Drawing.Point(0, 608);
			barDockControlBottom.Manager = barManagerStudents;
			barDockControlBottom.Size = new System.Drawing.Size(1074, 20);
			// 
			// barDockControlLeft
			// 
			barDockControlLeft.CausesValidation = false;
			barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			barDockControlLeft.Location = new System.Drawing.Point(0, 41);
			barDockControlLeft.Manager = barManagerStudents;
			barDockControlLeft.Size = new System.Drawing.Size(0, 567);
			// 
			// barDockControlRight
			// 
			barDockControlRight.CausesValidation = false;
			barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			barDockControlRight.Location = new System.Drawing.Point(1074, 41);
			barDockControlRight.Manager = barManagerStudents;
			barDockControlRight.Size = new System.Drawing.Size(0, 567);
			// 
			// btnAddStudent
			// 
			btnAddStudent.AccessibleName = "btnAddStudent";
			btnAddStudent.Caption = "➕   Add Student";
			btnAddStudent.Id = 0;
			btnAddStudent.Name = "btnAddStudent";
			// 
			// btnUpdateStudent
			// 
			btnUpdateStudent.AccessibleName = "btnUpdateStudent";
			btnUpdateStudent.Caption = "🔄 Update Student";
			btnUpdateStudent.Id = 1;
			btnUpdateStudent.Name = "btnUpdateStudent";
			// 
			// btnDeleteStudent
			// 
			btnDeleteStudent.AccessibleName = "btnDeleteStudent";
			btnDeleteStudent.Caption = "❌   Delete Student";
			btnDeleteStudent.Id = 2;
			btnDeleteStudent.Name = "btnDeleteStudent";
			// 
			// btnRefresh
			// 
			btnRefresh.AccessibleName = "btnRefresh";
			btnRefresh.Caption = "🔄 Refresh";
			btnRefresh.Id = 3;
			btnRefresh.Name = "btnRefresh";
			// 
			// btnGetStudentHasBooks
			// 
			btnGetStudentHasBooks.AccessibleName = "btnGetStudentHasBooks";
			btnGetStudentHasBooks.Caption = "Get Student Has Books";
			btnGetStudentHasBooks.Id = 4;
			btnGetStudentHasBooks.Name = "btnGetStudentHasBooks";
			// 
			// popupMenuStudents
			// 
			popupMenuStudents.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(btnAddStudent), new DevExpress.XtraBars.LinkPersistInfo(btnUpdateStudent), new DevExpress.XtraBars.LinkPersistInfo(btnDeleteStudent), new DevExpress.XtraBars.LinkPersistInfo(btnRefresh), new DevExpress.XtraBars.LinkPersistInfo(btnGetStudentHasBooks) });
			popupMenuStudents.Manager = barManagerStudents;
			popupMenuStudents.Name = "popupMenuStudents";
			// 
			// frmStudents
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(1074, 628);
			Controls.Add(gridControlStudents);
			Controls.Add(barDockControlLeft);
			Controls.Add(barDockControlRight);
			Controls.Add(barDockControlBottom);
			Controls.Add(barDockControlTop);
			Name = "frmStudents";
			Text = "frmStudents";
			KeyDown += frmStudents_KeyDown;
			((System.ComponentModel.ISupportInitialize)gridControlStudents).EndInit();
			((System.ComponentModel.ISupportInitialize)gridViewStudents).EndInit();
			((System.ComponentModel.ISupportInitialize)barManagerStudents).EndInit();
			((System.ComponentModel.ISupportInitialize)popupMenuStudents).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridControlStudents;
		private DevExpress.XtraGrid.Views.Grid.GridView gridViewStudents;
		private DevExpress.XtraGrid.Columns.GridColumn colId;
		private DevExpress.XtraGrid.Columns.GridColumn clmName;
		private DevExpress.XtraGrid.Columns.GridColumn clmPhoneNumber;
		private DevExpress.XtraBars.BarManager barManagerStudents;
		private DevExpress.XtraBars.Bar bar1;
		private DevExpress.XtraBars.Bar bar2;
		private DevExpress.XtraBars.Bar bar3;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private DevExpress.XtraBars.BarButtonItem btnAddStudent;
		private DevExpress.XtraBars.BarButtonItem btnUpdateStudent;
		private DevExpress.XtraBars.BarButtonItem btnDeleteStudent;
		private DevExpress.XtraBars.BarButtonItem btnRefresh;
		private DevExpress.XtraBars.PopupMenu popupMenuStudents;
		private DevExpress.XtraBars.BarButtonItem btnGetStudentHasBooks;
		private DevExpress.XtraGrid.Columns.GridColumn colStudentNumber;
		private DevExpress.XtraGrid.Columns.GridColumn colLastBorrowedBook;
		private DevExpress.XtraGrid.Columns.GridColumn colTotalBorrowedBookCount;
		private DevExpress.XtraGrid.Columns.GridColumn colFavoriteCategory;
		private DevExpress.XtraGrid.Columns.GridColumn colAverageReturnedBookTime;
	}
}