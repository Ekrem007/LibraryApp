namespace LibraryApp.UI
{
	partial class MainForm
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
			navigationPane1 = new DevExpress.XtraBars.Navigation.NavigationPane();
			nvpBooks = new DevExpress.XtraBars.Navigation.NavigationPage();
			btnGiveBooksToStudent = new DevExpress.XtraEditors.SimpleButton();
			btnAddBook = new DevExpress.XtraEditors.SimpleButton();
			gridControlBooks = new DevExpress.XtraGrid.GridControl();
			gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			colId = new DevExpress.XtraGrid.Columns.GridColumn();
			colBookName = new DevExpress.XtraGrid.Columns.GridColumn();
			colAuthorName = new DevExpress.XtraGrid.Columns.GridColumn();
			colCategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
			nvpAuthors = new DevExpress.XtraBars.Navigation.NavigationPage();
			gridControlAuthors = new DevExpress.XtraGrid.GridControl();
			gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
			Id = new DevExpress.XtraGrid.Columns.GridColumn();
			collAuthorName = new DevExpress.XtraGrid.Columns.GridColumn();
			nvpCategories = new DevExpress.XtraBars.Navigation.NavigationPage();
			gridControlCategories = new DevExpress.XtraGrid.GridControl();
			gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
			colCategoryId = new DevExpress.XtraGrid.Columns.GridColumn();
			colCategorryName = new DevExpress.XtraGrid.Columns.GridColumn();
			nvpMainPage = new DevExpress.XtraBars.Navigation.NavigationPage();
			nvpStudents = new DevExpress.XtraBars.Navigation.NavigationPage();
			btnDeleteStudent = new DevExpress.XtraEditors.SimpleButton();
			btnUpdateStudent = new DevExpress.XtraEditors.SimpleButton();
			btnAddStudent = new DevExpress.XtraEditors.SimpleButton();
			gridControlStudents = new DevExpress.XtraGrid.GridControl();
			gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
			nvpBookOperations = new DevExpress.XtraBars.Navigation.NavigationPage();
			btnUpdateTransferRecord = new DevExpress.XtraEditors.SimpleButton();
			btnDeleteOperation = new DevExpress.XtraEditors.SimpleButton();
			gridControlBookTransferOperations = new DevExpress.XtraGrid.GridControl();
			gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
			stackPanel1 = new DevExpress.Utils.Layout.StackPanel();
			popupMenuBooks = new DevExpress.XtraBars.PopupMenu(components);
			btnPopUpAddBook = new DevExpress.XtraBars.BarButtonItem();
			btnPopUpDeleteBook = new DevExpress.XtraBars.BarButtonItem();
			btnPopUpUpdateBook = new DevExpress.XtraBars.BarButtonItem();
			barManagerBooks = new DevExpress.XtraBars.BarManager(components);
			barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			btnPopUpDeleteAuthor = new DevExpress.XtraBars.BarButtonItem();
			barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
			btnPopUpAddAuthor = new DevExpress.XtraBars.BarButtonItem();
			btnPopUpAddCategory = new DevExpress.XtraBars.BarButtonItem();
			btnPopUpDeleteCategory = new DevExpress.XtraBars.BarButtonItem();
			btnPopUpUpdateCategory = new DevExpress.XtraBars.BarButtonItem();
			bar1 = new DevExpress.XtraBars.Bar();
			popupMenuAuthors = new DevExpress.XtraBars.PopupMenu(components);
			popupMenuCategories = new DevExpress.XtraBars.PopupMenu(components);
			((System.ComponentModel.ISupportInitialize)navigationPane1).BeginInit();
			navigationPane1.SuspendLayout();
			nvpBooks.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)gridControlBooks).BeginInit();
			((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
			nvpAuthors.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)gridControlAuthors).BeginInit();
			((System.ComponentModel.ISupportInitialize)gridView2).BeginInit();
			nvpCategories.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)gridControlCategories).BeginInit();
			((System.ComponentModel.ISupportInitialize)gridView3).BeginInit();
			nvpStudents.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)gridControlStudents).BeginInit();
			((System.ComponentModel.ISupportInitialize)gridView4).BeginInit();
			nvpBookOperations.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)gridControlBookTransferOperations).BeginInit();
			((System.ComponentModel.ISupportInitialize)gridView5).BeginInit();
			((System.ComponentModel.ISupportInitialize)stackPanel1).BeginInit();
			((System.ComponentModel.ISupportInitialize)popupMenuBooks).BeginInit();
			((System.ComponentModel.ISupportInitialize)barManagerBooks).BeginInit();
			((System.ComponentModel.ISupportInitialize)popupMenuAuthors).BeginInit();
			((System.ComponentModel.ISupportInitialize)popupMenuCategories).BeginInit();
			SuspendLayout();
			// 
			// navigationPane1
			// 
			navigationPane1.Controls.Add(nvpBooks);
			navigationPane1.Controls.Add(nvpAuthors);
			navigationPane1.Controls.Add(nvpCategories);
			navigationPane1.Controls.Add(nvpMainPage);
			navigationPane1.Controls.Add(nvpStudents);
			navigationPane1.Controls.Add(nvpBookOperations);
			navigationPane1.Dock = System.Windows.Forms.DockStyle.Fill;
			navigationPane1.Location = new System.Drawing.Point(0, 0);
			navigationPane1.Margin = new System.Windows.Forms.Padding(4);
			navigationPane1.Name = "navigationPane1";
			navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] { nvpMainPage, nvpBooks, nvpAuthors, nvpCategories, nvpStudents, nvpBookOperations });
			navigationPane1.RegularSize = new System.Drawing.Size(1203, 695);
			navigationPane1.SelectedPage = nvpMainPage;
			navigationPane1.Size = new System.Drawing.Size(1203, 695);
			navigationPane1.TabIndex = 0;
			navigationPane1.Text = "navigationPane1";
			// 
			// nvpBooks
			// 
			nvpBooks.Caption = "Books";
			nvpBooks.Controls.Add(btnGiveBooksToStudent);
			nvpBooks.Controls.Add(btnAddBook);
			nvpBooks.Controls.Add(gridControlBooks);
			nvpBooks.Margin = new System.Windows.Forms.Padding(4);
			nvpBooks.Name = "nvpBooks";
			nvpBooks.Size = new System.Drawing.Size(1043, 605);
			// 
			// btnGiveBooksToStudent
			// 
			btnGiveBooksToStudent.Location = new System.Drawing.Point(18, 485);
			btnGiveBooksToStudent.Margin = new System.Windows.Forms.Padding(4);
			btnGiveBooksToStudent.Name = "btnGiveBooksToStudent";
			btnGiveBooksToStudent.Size = new System.Drawing.Size(159, 51);
			btnGiveBooksToStudent.TabIndex = 11;
			btnGiveBooksToStudent.Text = "Give Book To Student";
			// 
			// btnAddBook
			// 
			btnAddBook.Location = new System.Drawing.Point(18, 544);
			btnAddBook.Margin = new System.Windows.Forms.Padding(4);
			btnAddBook.Name = "btnAddBook";
			btnAddBook.Size = new System.Drawing.Size(159, 51);
			btnAddBook.TabIndex = 1;
			btnAddBook.Text = "Add Book";
			btnAddBook.Click += btnAddBook_Click;
			// 
			// gridControlBooks
			// 
			gridControlBooks.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
			gridControlBooks.Location = new System.Drawing.Point(0, 4);
			gridControlBooks.MainView = gridView1;
			gridControlBooks.Margin = new System.Windows.Forms.Padding(4);
			gridControlBooks.Name = "gridControlBooks";
			gridControlBooks.Size = new System.Drawing.Size(1041, 473);
			gridControlBooks.TabIndex = 0;
			gridControlBooks.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
			gridControlBooks.KeyDown += gridControlBooks_KeyDown;
			gridControlBooks.MouseUp += gridControlBooks_MouseUp;
			// 
			// gridView1
			// 
			gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colId, colBookName, colAuthorName, colCategoryName });
			gridView1.DetailHeight = 431;
			gridView1.GridControl = gridControlBooks;
			gridView1.Name = "gridView1";
			gridView1.OptionsEditForm.PopupEditFormWidth = 933;
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
			colCategoryName.Visible = true;
			colCategoryName.VisibleIndex = 3;
			colCategoryName.Width = 94;
			// 
			// nvpAuthors
			// 
			nvpAuthors.Caption = "Authors";
			nvpAuthors.Controls.Add(gridControlAuthors);
			nvpAuthors.Margin = new System.Windows.Forms.Padding(4);
			nvpAuthors.Name = "nvpAuthors";
			nvpAuthors.Size = new System.Drawing.Size(1043, 605);
			// 
			// gridControlAuthors
			// 
			gridControlAuthors.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
			gridControlAuthors.Location = new System.Drawing.Point(4, 4);
			gridControlAuthors.MainView = gridView2;
			gridControlAuthors.Margin = new System.Windows.Forms.Padding(4);
			gridControlAuthors.Name = "gridControlAuthors";
			gridControlAuthors.Size = new System.Drawing.Size(1038, 500);
			gridControlAuthors.TabIndex = 0;
			gridControlAuthors.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView2 });
			gridControlAuthors.KeyDown += gridControlAuthors_KeyDown;
			gridControlAuthors.MouseUp += gridControlAuthors_MouseUp;
			// 
			// gridView2
			// 
			gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { Id, collAuthorName });
			gridView2.DetailHeight = 431;
			gridView2.GridControl = gridControlAuthors;
			gridView2.Name = "gridView2";
			gridView2.OptionsEditForm.PopupEditFormWidth = 933;
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
			collAuthorName.Visible = true;
			collAuthorName.VisibleIndex = 1;
			collAuthorName.Width = 94;
			// 
			// nvpCategories
			// 
			nvpCategories.Caption = "Categories";
			nvpCategories.Controls.Add(gridControlCategories);
			nvpCategories.Margin = new System.Windows.Forms.Padding(4);
			nvpCategories.Name = "nvpCategories";
			nvpCategories.Size = new System.Drawing.Size(1043, 605);
			// 
			// gridControlCategories
			// 
			gridControlCategories.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
			gridControlCategories.Location = new System.Drawing.Point(0, 4);
			gridControlCategories.MainView = gridView3;
			gridControlCategories.Margin = new System.Windows.Forms.Padding(4);
			gridControlCategories.Name = "gridControlCategories";
			gridControlCategories.Size = new System.Drawing.Size(1059, 465);
			gridControlCategories.TabIndex = 1;
			gridControlCategories.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView3 });
			gridControlCategories.KeyDown += gridControlCategories_KeyDown;
			gridControlCategories.MouseUp += gridControlCategories_MouseUp;
			// 
			// gridView3
			// 
			gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colCategoryId, colCategorryName });
			gridView3.DetailHeight = 431;
			gridView3.GridControl = gridControlCategories;
			gridView3.Name = "gridView3";
			gridView3.OptionsEditForm.PopupEditFormWidth = 933;
			// 
			// colCategoryId
			// 
			colCategoryId.Caption = "Id";
			colCategoryId.FieldName = "Id";
			colCategoryId.MinWidth = 25;
			colCategoryId.Name = "colCategoryId";
			colCategoryId.OptionsColumn.AllowEdit = false;
			colCategoryId.Visible = true;
			colCategoryId.VisibleIndex = 0;
			colCategoryId.Width = 94;
			// 
			// colCategorryName
			// 
			colCategorryName.Caption = "Category Name";
			colCategorryName.FieldName = "CategoryName";
			colCategorryName.MinWidth = 25;
			colCategorryName.Name = "colCategorryName";
			colCategorryName.OptionsColumn.AllowEdit = false;
			colCategorryName.Visible = true;
			colCategorryName.VisibleIndex = 1;
			colCategorryName.Width = 94;
			// 
			// nvpMainPage
			// 
			nvpMainPage.Caption = "MainPage";
			nvpMainPage.Margin = new System.Windows.Forms.Padding(4);
			nvpMainPage.Name = "nvpMainPage";
			nvpMainPage.Size = new System.Drawing.Size(1043, 559);
			// 
			// nvpStudents
			// 
			nvpStudents.Caption = "Students";
			nvpStudents.Controls.Add(btnDeleteStudent);
			nvpStudents.Controls.Add(btnUpdateStudent);
			nvpStudents.Controls.Add(btnAddStudent);
			nvpStudents.Controls.Add(gridControlStudents);
			nvpStudents.Name = "nvpStudents";
			nvpStudents.Size = new System.Drawing.Size(1043, 605);
			// 
			// btnDeleteStudent
			// 
			btnDeleteStudent.Appearance.ForeColor = System.Drawing.Color.Black;
			btnDeleteStudent.Appearance.Options.UseForeColor = true;
			btnDeleteStudent.AppearanceHovered.BackColor = System.Drawing.Color.OrangeRed;
			btnDeleteStudent.AppearanceHovered.Options.UseBackColor = true;
			btnDeleteStudent.Location = new System.Drawing.Point(1142, 571);
			btnDeleteStudent.Margin = new System.Windows.Forms.Padding(4);
			btnDeleteStudent.Name = "btnDeleteStudent";
			btnDeleteStudent.Size = new System.Drawing.Size(159, 43);
			btnDeleteStudent.TabIndex = 16;
			btnDeleteStudent.Text = "Delete Student";
			// 
			// btnUpdateStudent
			// 
			btnUpdateStudent.Location = new System.Drawing.Point(1142, 520);
			btnUpdateStudent.Margin = new System.Windows.Forms.Padding(4);
			btnUpdateStudent.Name = "btnUpdateStudent";
			btnUpdateStudent.Size = new System.Drawing.Size(159, 43);
			btnUpdateStudent.TabIndex = 15;
			btnUpdateStudent.Text = "Update Student";
			// 
			// btnAddStudent
			// 
			btnAddStudent.Location = new System.Drawing.Point(1142, 469);
			btnAddStudent.Margin = new System.Windows.Forms.Padding(4);
			btnAddStudent.Name = "btnAddStudent";
			btnAddStudent.Size = new System.Drawing.Size(161, 43);
			btnAddStudent.TabIndex = 14;
			btnAddStudent.Text = "Add Student";
			// 
			// gridControlStudents
			// 
			gridControlStudents.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
			gridControlStudents.Location = new System.Drawing.Point(0, 0);
			gridControlStudents.MainView = gridView4;
			gridControlStudents.Margin = new System.Windows.Forms.Padding(4);
			gridControlStudents.Name = "gridControlStudents";
			gridControlStudents.Size = new System.Drawing.Size(1046, 504);
			gridControlStudents.TabIndex = 13;
			gridControlStudents.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView4 });
			// 
			// gridView4
			// 
			gridView4.DetailHeight = 431;
			gridView4.GridControl = gridControlStudents;
			gridView4.Name = "gridView4";
			gridView4.OptionsEditForm.PopupEditFormWidth = 933;
			// 
			// nvpBookOperations
			// 
			nvpBookOperations.Caption = "Book Operations";
			nvpBookOperations.Controls.Add(btnUpdateTransferRecord);
			nvpBookOperations.Controls.Add(btnDeleteOperation);
			nvpBookOperations.Controls.Add(gridControlBookTransferOperations);
			nvpBookOperations.Name = "nvpBookOperations";
			nvpBookOperations.Size = new System.Drawing.Size(1043, 605);
			// 
			// btnUpdateTransferRecord
			// 
			btnUpdateTransferRecord.Location = new System.Drawing.Point(4, 511);
			btnUpdateTransferRecord.Margin = new System.Windows.Forms.Padding(4);
			btnUpdateTransferRecord.Name = "btnUpdateTransferRecord";
			btnUpdateTransferRecord.Size = new System.Drawing.Size(178, 43);
			btnUpdateTransferRecord.TabIndex = 21;
			btnUpdateTransferRecord.Text = "Update Book Transfer Record";
			// 
			// btnDeleteOperation
			// 
			btnDeleteOperation.Appearance.ForeColor = System.Drawing.Color.Black;
			btnDeleteOperation.Appearance.Options.UseForeColor = true;
			btnDeleteOperation.AppearanceHovered.BackColor = System.Drawing.Color.OrangeRed;
			btnDeleteOperation.AppearanceHovered.Options.UseBackColor = true;
			btnDeleteOperation.Location = new System.Drawing.Point(4, 460);
			btnDeleteOperation.Margin = new System.Windows.Forms.Padding(4);
			btnDeleteOperation.Name = "btnDeleteOperation";
			btnDeleteOperation.Size = new System.Drawing.Size(176, 43);
			btnDeleteOperation.TabIndex = 20;
			btnDeleteOperation.Text = "Delete Book Transfer Record";
			// 
			// gridControlBookTransferOperations
			// 
			gridControlBookTransferOperations.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
			gridControlBookTransferOperations.Location = new System.Drawing.Point(4, 0);
			gridControlBookTransferOperations.MainView = gridView5;
			gridControlBookTransferOperations.Margin = new System.Windows.Forms.Padding(4);
			gridControlBookTransferOperations.Name = "gridControlBookTransferOperations";
			gridControlBookTransferOperations.Size = new System.Drawing.Size(1035, 452);
			gridControlBookTransferOperations.TabIndex = 17;
			gridControlBookTransferOperations.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView5 });
			// 
			// gridView5
			// 
			gridView5.DetailHeight = 431;
			gridView5.GridControl = gridControlBookTransferOperations;
			gridView5.Name = "gridView5";
			gridView5.OptionsEditForm.PopupEditFormWidth = 933;
			// 
			// stackPanel1
			// 
			stackPanel1.Location = new System.Drawing.Point(70, 0);
			stackPanel1.Margin = new System.Windows.Forms.Padding(4);
			stackPanel1.Name = "stackPanel1";
			stackPanel1.Size = new System.Drawing.Size(9, 10);
			stackPanel1.TabIndex = 1;
			stackPanel1.UseSkinIndents = true;
			// 
			// popupMenuBooks
			// 
			popupMenuBooks.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(btnPopUpAddBook), new DevExpress.XtraBars.LinkPersistInfo(btnPopUpDeleteBook), new DevExpress.XtraBars.LinkPersistInfo(btnPopUpUpdateBook) });
			popupMenuBooks.Manager = barManagerBooks;
			popupMenuBooks.Name = "popupMenuBooks";
			// 
			// btnPopUpAddBook
			// 
			btnPopUpAddBook.AccessibleName = "btnPopUpAddBook";
			btnPopUpAddBook.Caption = "➕   Add Book";
			btnPopUpAddBook.Id = 0;
			btnPopUpAddBook.Name = "btnPopUpAddBook";
			btnPopUpAddBook.Tag = "btnPopUpAddBook";
			// 
			// btnPopUpDeleteBook
			// 
			btnPopUpDeleteBook.AccessibleName = "btnPopUpDeleteBook";
			btnPopUpDeleteBook.Caption = "❌   Delete Book";
			btnPopUpDeleteBook.Id = 2;
			btnPopUpDeleteBook.Name = "btnPopUpDeleteBook";
			// 
			// btnPopUpUpdateBook
			// 
			btnPopUpUpdateBook.AccessibleName = "btnPopUpUpdateBook";
			btnPopUpUpdateBook.Caption = "🔄 Update Book";
			btnPopUpUpdateBook.Id = 1;
			btnPopUpUpdateBook.Name = "btnPopUpUpdateBook";
			btnPopUpUpdateBook.Tag = "btnPopUpUpdateBook";
			// 
			// barManagerBooks
			// 
			barManagerBooks.DockControls.Add(barDockControlTop);
			barManagerBooks.DockControls.Add(barDockControlBottom);
			barManagerBooks.DockControls.Add(barDockControlLeft);
			barManagerBooks.DockControls.Add(barDockControlRight);
			barManagerBooks.Form = this;
			barManagerBooks.Items.AddRange(new DevExpress.XtraBars.BarItem[] { btnPopUpAddBook, btnPopUpUpdateBook, btnPopUpDeleteBook, btnPopUpDeleteAuthor, barButtonItem3, btnPopUpAddAuthor, btnPopUpAddCategory, btnPopUpDeleteCategory, btnPopUpUpdateCategory });
			barManagerBooks.MaxItemId = 9;
			// 
			// barDockControlTop
			// 
			barDockControlTop.CausesValidation = false;
			barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			barDockControlTop.Location = new System.Drawing.Point(0, 0);
			barDockControlTop.Manager = barManagerBooks;
			barDockControlTop.Size = new System.Drawing.Size(1203, 0);
			// 
			// barDockControlBottom
			// 
			barDockControlBottom.CausesValidation = false;
			barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			barDockControlBottom.Location = new System.Drawing.Point(0, 695);
			barDockControlBottom.Manager = barManagerBooks;
			barDockControlBottom.Size = new System.Drawing.Size(1203, 0);
			// 
			// barDockControlLeft
			// 
			barDockControlLeft.CausesValidation = false;
			barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			barDockControlLeft.Location = new System.Drawing.Point(0, 0);
			barDockControlLeft.Manager = barManagerBooks;
			barDockControlLeft.Size = new System.Drawing.Size(0, 695);
			// 
			// barDockControlRight
			// 
			barDockControlRight.CausesValidation = false;
			barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			barDockControlRight.Location = new System.Drawing.Point(1203, 0);
			barDockControlRight.Manager = barManagerBooks;
			barDockControlRight.Size = new System.Drawing.Size(0, 695);
			// 
			// btnPopUpDeleteAuthor
			// 
			btnPopUpDeleteAuthor.AccessibleName = "btnPopUpDeleteAuthor";
			btnPopUpDeleteAuthor.Caption = "❌   Delete Author";
			btnPopUpDeleteAuthor.Id = 3;
			btnPopUpDeleteAuthor.Name = "btnPopUpDeleteAuthor";
			btnPopUpDeleteAuthor.Tag = "btnPopUpDeleteAuthor";
			// 
			// barButtonItem3
			// 
			barButtonItem3.Caption = "🔄 Update Author";
			barButtonItem3.Id = 4;
			barButtonItem3.Name = "barButtonItem3";
			// 
			// btnPopUpAddAuthor
			// 
			btnPopUpAddAuthor.AccessibleName = "btnPopUpAddAuthor";
			btnPopUpAddAuthor.Caption = "➕   Add Author";
			btnPopUpAddAuthor.Id = 5;
			btnPopUpAddAuthor.Name = "btnPopUpAddAuthor";
			btnPopUpAddAuthor.Tag = "btnPopUpAddAuthor";
			// 
			// btnPopUpAddCategory
			// 
			btnPopUpAddCategory.AccessibleName = "btnPopUpAddCategory";
			btnPopUpAddCategory.Caption = "➕   Add Category";
			btnPopUpAddCategory.Id = 6;
			btnPopUpAddCategory.Name = "btnPopUpAddCategory";
			btnPopUpAddCategory.Tag = "btnPopUpAddCategory";
			// 
			// btnPopUpDeleteCategory
			// 
			btnPopUpDeleteCategory.AccessibleName = "btnPopUpDeleteCategory";
			btnPopUpDeleteCategory.Caption = "❌   Delete Category";
			btnPopUpDeleteCategory.Id = 7;
			btnPopUpDeleteCategory.Name = "btnPopUpDeleteCategory";
			btnPopUpDeleteCategory.Tag = "btnPopUpDeleteCategory";
			// 
			// btnPopUpUpdateCategory
			// 
			btnPopUpUpdateCategory.AccessibleName = "btnPopUpUpdateCategory";
			btnPopUpUpdateCategory.Caption = "🔄 Update Category";
			btnPopUpUpdateCategory.Id = 8;
			btnPopUpUpdateCategory.Name = "btnPopUpUpdateCategory";
			btnPopUpUpdateCategory.Tag = "btnPopUpUpdateCategory";
			// 
			// bar1
			// 
			bar1.BarName = "Custom 2";
			bar1.DockCol = 0;
			bar1.DockRow = 0;
			bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			bar1.Text = "Custom 2";
			// 
			// popupMenuAuthors
			// 
			popupMenuAuthors.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(btnPopUpAddAuthor), new DevExpress.XtraBars.LinkPersistInfo(btnPopUpDeleteAuthor), new DevExpress.XtraBars.LinkPersistInfo(barButtonItem3) });
			popupMenuAuthors.Manager = barManagerBooks;
			popupMenuAuthors.Name = "popupMenuAuthors";
			// 
			// popupMenuCategories
			// 
			popupMenuCategories.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(btnPopUpAddCategory), new DevExpress.XtraBars.LinkPersistInfo(btnPopUpDeleteCategory), new DevExpress.XtraBars.LinkPersistInfo(btnPopUpUpdateCategory) });
			popupMenuCategories.Manager = barManagerBooks;
			popupMenuCategories.Name = "popupMenuCategories";
			// 
			// MainForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(1203, 695);
			Controls.Add(stackPanel1);
			Controls.Add(navigationPane1);
			Controls.Add(barDockControlLeft);
			Controls.Add(barDockControlRight);
			Controls.Add(barDockControlBottom);
			Controls.Add(barDockControlTop);
			Margin = new System.Windows.Forms.Padding(4);
			Name = "MainForm";
			Text = "MainForm";
			((System.ComponentModel.ISupportInitialize)navigationPane1).EndInit();
			navigationPane1.ResumeLayout(false);
			nvpBooks.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)gridControlBooks).EndInit();
			((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
			nvpAuthors.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)gridControlAuthors).EndInit();
			((System.ComponentModel.ISupportInitialize)gridView2).EndInit();
			nvpCategories.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)gridControlCategories).EndInit();
			((System.ComponentModel.ISupportInitialize)gridView3).EndInit();
			nvpStudents.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)gridControlStudents).EndInit();
			((System.ComponentModel.ISupportInitialize)gridView4).EndInit();
			nvpBookOperations.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)gridControlBookTransferOperations).EndInit();
			((System.ComponentModel.ISupportInitialize)gridView5).EndInit();
			((System.ComponentModel.ISupportInitialize)stackPanel1).EndInit();
			((System.ComponentModel.ISupportInitialize)popupMenuBooks).EndInit();
			((System.ComponentModel.ISupportInitialize)barManagerBooks).EndInit();
			((System.ComponentModel.ISupportInitialize)popupMenuAuthors).EndInit();
			((System.ComponentModel.ISupportInitialize)popupMenuCategories).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DevExpress.XtraBars.Navigation.NavigationPane navigationPane1;
		private DevExpress.XtraBars.Navigation.NavigationPage nvpBooks;
		private DevExpress.XtraBars.Navigation.NavigationPage nvpAuthors;
		private DevExpress.XtraGrid.GridControl gridControlBooks;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraBars.Navigation.NavigationPage nvpCategories;
		private DevExpress.XtraEditors.SimpleButton btnAddBook;
		private DevExpress.XtraGrid.GridControl gridControlAuthors;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
		private DevExpress.XtraGrid.GridControl gridControlCategories;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
		private DevExpress.Utils.Layout.StackPanel stackPanel1;
		private DevExpress.XtraBars.Navigation.NavigationPage nvpMainPage;
		private DevExpress.XtraBars.Navigation.NavigationPage nvpStudents;
		private DevExpress.XtraEditors.SimpleButton btnDeleteStudent;
		private DevExpress.XtraEditors.SimpleButton btnUpdateStudent;
		private DevExpress.XtraEditors.SimpleButton btnAddStudent;
		private DevExpress.XtraGrid.GridControl gridControlStudents;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
		private DevExpress.XtraGrid.Columns.GridColumn colId;
		private DevExpress.XtraGrid.Columns.GridColumn colBookName;
		private DevExpress.XtraGrid.Columns.GridColumn colAuthorName;
		private DevExpress.XtraGrid.Columns.GridColumn colCategoryName;
		private DevExpress.XtraGrid.Columns.GridColumn colCategoryId;
		private DevExpress.XtraGrid.Columns.GridColumn colCategorryName;
		private DevExpress.XtraGrid.Columns.GridColumn Id;
		private DevExpress.XtraGrid.Columns.GridColumn collAuthorName;
		private DevExpress.XtraBars.Navigation.NavigationPage nvpBookOperations;
		private DevExpress.XtraEditors.SimpleButton btnDeleteOperation;
		private DevExpress.XtraEditors.SimpleButton btnChangeBookAvailability;
		private DevExpress.XtraGrid.GridControl gridControlBookTransferOperations;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
		private DevExpress.XtraEditors.SimpleButton btnUpdateTransferRecord;
		private DevExpress.XtraEditors.SimpleButton btnGiveBooksToStudent;
		private DevExpress.XtraBars.PopupMenu popupMenuBooks;
		private DevExpress.XtraBars.BarButtonItem btnPopUpAddBook;
		private DevExpress.XtraBars.BarButtonItem btnPopUpUpdateBook;
		private DevExpress.XtraBars.BarButtonItem btnPopUpDeleteBook;
		private DevExpress.XtraBars.BarManager barManagerBooks;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private DevExpress.XtraBars.Bar bar1;
		private DevExpress.XtraBars.PopupMenu popupMenuAuthors;
		private DevExpress.XtraBars.BarButtonItem btnPopUpDeleteAuthor;
		private DevExpress.XtraBars.BarButtonItem barButtonItem3;
		private DevExpress.XtraBars.BarButtonItem btnPopUpAddAuthor;
		private DevExpress.XtraBars.BarButtonItem btnPopUpAddCategory;
		private DevExpress.XtraBars.BarButtonItem btnPopUpDeleteCategory;
		private DevExpress.XtraBars.BarButtonItem btnPopUpUpdateCategory;
		private DevExpress.XtraBars.PopupMenu popupMenuCategories;
	}
}