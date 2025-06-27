namespace LibraryApp.UI.BookTransactions
{
	partial class frmAddBookTransaction
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
			layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			dateEditReturnedTime = new DevExpress.XtraEditors.DateEdit();
			dateEditBorrowedTime = new DevExpress.XtraEditors.DateEdit();
			layoutControl3 = new DevExpress.XtraLayout.LayoutControl();
			btnSaveBookOperation = new DevExpress.XtraEditors.SimpleButton();
			layoutControl4 = new DevExpress.XtraLayout.LayoutControl();
			layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
			layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
			layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
			layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
			luBookName = new DevExpress.XtraEditors.GridLookUpEdit();
			gridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
			luStudentName = new DevExpress.XtraEditors.GridLookUpEdit();
			gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
			layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
			layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			Root = new DevExpress.XtraLayout.LayoutControlGroup();
			layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			StudentName = new DevExpress.XtraLayout.LayoutControlItem();
			BookName = new DevExpress.XtraLayout.LayoutControlItem();
			layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
			layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dateEditReturnedTime.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)dateEditReturnedTime.Properties.CalendarTimeProperties).BeginInit();
			((System.ComponentModel.ISupportInitialize)dateEditBorrowedTime.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)dateEditBorrowedTime.Properties.CalendarTimeProperties).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControl3).BeginInit();
			layoutControl3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)layoutControl4).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlGroup3).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlGroup2).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem6).BeginInit();
			((System.ComponentModel.ISupportInitialize)luBookName.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)gridLookUpEdit2View).BeginInit();
			((System.ComponentModel.ISupportInitialize)luStudentName.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)gridLookUpEdit1View).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControl2).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlGroup1).BeginInit();
			((System.ComponentModel.ISupportInitialize)Root).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
			((System.ComponentModel.ISupportInitialize)StudentName).BeginInit();
			((System.ComponentModel.ISupportInitialize)BookName).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
			SuspendLayout();
			// 
			// layoutControl1
			// 
			layoutControl1.Controls.Add(dateEditReturnedTime);
			layoutControl1.Controls.Add(dateEditBorrowedTime);
			layoutControl1.Controls.Add(layoutControl3);
			layoutControl1.Controls.Add(luBookName);
			layoutControl1.Controls.Add(luStudentName);
			layoutControl1.Controls.Add(layoutControl2);
			layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			layoutControl1.Location = new System.Drawing.Point(0, 0);
			layoutControl1.Name = "layoutControl1";
			layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(327, 0, 812, 500);
			layoutControl1.Root = Root;
			layoutControl1.Size = new System.Drawing.Size(336, 323);
			layoutControl1.TabIndex = 0;
			layoutControl1.Text = "layoutControl1";
			// 
			// dateEditReturnedTime
			// 
			dateEditReturnedTime.EditValue = null;
			dateEditReturnedTime.Location = new System.Drawing.Point(112, 90);
			dateEditReturnedTime.Name = "dateEditReturnedTime";
			dateEditReturnedTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
			dateEditReturnedTime.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
			dateEditReturnedTime.Size = new System.Drawing.Size(212, 22);
			dateEditReturnedTime.StyleController = layoutControl1;
			dateEditReturnedTime.TabIndex = 9;
			// 
			// dateEditBorrowedTime
			// 
			dateEditBorrowedTime.EditValue = null;
			dateEditBorrowedTime.Location = new System.Drawing.Point(112, 64);
			dateEditBorrowedTime.Name = "dateEditBorrowedTime";
			dateEditBorrowedTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
			dateEditBorrowedTime.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
			dateEditBorrowedTime.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
			dateEditBorrowedTime.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
			dateEditBorrowedTime.Size = new System.Drawing.Size(212, 22);
			dateEditBorrowedTime.StyleController = layoutControl1;
			dateEditBorrowedTime.TabIndex = 8;
			// 
			// layoutControl3
			// 
			layoutControl3.Controls.Add(btnSaveBookOperation);
			layoutControl3.Controls.Add(layoutControl4);
			layoutControl3.Location = new System.Drawing.Point(12, 260);
			layoutControl3.Name = "layoutControl3";
			layoutControl3.Root = layoutControlGroup2;
			layoutControl3.Size = new System.Drawing.Size(312, 51);
			layoutControl3.TabIndex = 7;
			layoutControl3.Text = "layoutControl3";
			// 
			// btnSaveBookOperation
			// 
			btnSaveBookOperation.AccessibleName = "btnSaveBookOperation";
			btnSaveBookOperation.Location = new System.Drawing.Point(180, 12);
			btnSaveBookOperation.Name = "btnSaveBookOperation";
			btnSaveBookOperation.Size = new System.Drawing.Size(120, 27);
			btnSaveBookOperation.StyleController = layoutControl3;
			btnSaveBookOperation.TabIndex = 5;
			btnSaveBookOperation.Text = "Save";
			// 
			// layoutControl4
			// 
			layoutControl4.Location = new System.Drawing.Point(12, 12);
			layoutControl4.Name = "layoutControl4";
			layoutControl4.Root = layoutControlGroup3;
			layoutControl4.Size = new System.Drawing.Size(164, 27);
			layoutControl4.TabIndex = 4;
			layoutControl4.Text = "layoutControl4";
			// 
			// layoutControlGroup3
			// 
			layoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			layoutControlGroup3.GroupBordersVisible = false;
			layoutControlGroup3.Name = "layoutControlGroup3";
			layoutControlGroup3.Size = new System.Drawing.Size(164, 27);
			layoutControlGroup3.TextVisible = false;
			// 
			// layoutControlGroup2
			// 
			layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			layoutControlGroup2.GroupBordersVisible = false;
			layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem5, layoutControlItem6 });
			layoutControlGroup2.Name = "layoutControlGroup2";
			layoutControlGroup2.Size = new System.Drawing.Size(312, 51);
			layoutControlGroup2.TextVisible = false;
			// 
			// layoutControlItem5
			// 
			layoutControlItem5.Control = layoutControl4;
			layoutControlItem5.Location = new System.Drawing.Point(0, 0);
			layoutControlItem5.Name = "layoutControlItem5";
			layoutControlItem5.Size = new System.Drawing.Size(168, 31);
			layoutControlItem5.TextVisible = false;
			// 
			// layoutControlItem6
			// 
			layoutControlItem6.Control = btnSaveBookOperation;
			layoutControlItem6.Location = new System.Drawing.Point(168, 0);
			layoutControlItem6.Name = "layoutControlItem6";
			layoutControlItem6.Size = new System.Drawing.Size(124, 31);
			layoutControlItem6.TextVisible = false;
			// 
			// luBookName
			// 
			luBookName.Location = new System.Drawing.Point(112, 38);
			luBookName.Name = "luBookName";
			luBookName.Properties.AccessibleName = "luBookName";
			luBookName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
			luBookName.Properties.DisplayMember = "BookName";
			luBookName.Properties.NullText = "Choose Book";
			luBookName.Properties.PopupView = gridLookUpEdit2View;
			luBookName.Properties.ValueMember = "Id";
			luBookName.Size = new System.Drawing.Size(212, 22);
			luBookName.StyleController = layoutControl1;
			luBookName.TabIndex = 6;
			// 
			// gridLookUpEdit2View
			// 
			gridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			gridLookUpEdit2View.Name = "gridLookUpEdit2View";
			gridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
			gridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
			// 
			// luStudentName
			// 
			luStudentName.Location = new System.Drawing.Point(112, 12);
			luStudentName.Name = "luStudentName";
			luStudentName.Properties.AccessibleName = "luStudentName";
			luStudentName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
			luStudentName.Properties.DisplayMember = "Name";
			luStudentName.Properties.NullText = "Choose Student";
			luStudentName.Properties.PopupView = gridLookUpEdit1View;
			luStudentName.Properties.ValueMember = "Id";
			luStudentName.Size = new System.Drawing.Size(212, 22);
			luStudentName.StyleController = layoutControl1;
			luStudentName.TabIndex = 5;
			// 
			// gridLookUpEdit1View
			// 
			gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			gridLookUpEdit1View.Name = "gridLookUpEdit1View";
			gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
			gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
			// 
			// layoutControl2
			// 
			layoutControl2.Location = new System.Drawing.Point(12, 116);
			layoutControl2.Name = "layoutControl2";
			layoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(322, 0, 812, 500);
			layoutControl2.Root = layoutControlGroup1;
			layoutControl2.Size = new System.Drawing.Size(312, 140);
			layoutControl2.TabIndex = 4;
			layoutControl2.Text = "layoutControl2";
			// 
			// layoutControlGroup1
			// 
			layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			layoutControlGroup1.GroupBordersVisible = false;
			layoutControlGroup1.Name = "Root";
			layoutControlGroup1.Size = new System.Drawing.Size(312, 140);
			layoutControlGroup1.TextVisible = false;
			// 
			// Root
			// 
			Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			Root.GroupBordersVisible = false;
			Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, StudentName, BookName, layoutControlItem4, layoutControlItem2, layoutControlItem3 });
			Root.Name = "Root";
			Root.Size = new System.Drawing.Size(336, 323);
			Root.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			layoutControlItem1.Control = layoutControl2;
			layoutControlItem1.Location = new System.Drawing.Point(0, 104);
			layoutControlItem1.Name = "layoutControlItem1";
			layoutControlItem1.Size = new System.Drawing.Size(316, 144);
			layoutControlItem1.TextVisible = false;
			// 
			// StudentName
			// 
			StudentName.Control = luStudentName;
			StudentName.Location = new System.Drawing.Point(0, 0);
			StudentName.Name = "StudentName";
			StudentName.Size = new System.Drawing.Size(316, 26);
			StudentName.Text = "Student Name";
			StudentName.TextSize = new System.Drawing.Size(88, 16);
			// 
			// BookName
			// 
			BookName.Control = luBookName;
			BookName.Location = new System.Drawing.Point(0, 26);
			BookName.Name = "BookName";
			BookName.Size = new System.Drawing.Size(316, 26);
			BookName.Text = "Book Name";
			BookName.TextSize = new System.Drawing.Size(88, 16);
			// 
			// layoutControlItem4
			// 
			layoutControlItem4.Control = layoutControl3;
			layoutControlItem4.Location = new System.Drawing.Point(0, 248);
			layoutControlItem4.Name = "layoutControlItem4";
			layoutControlItem4.Size = new System.Drawing.Size(316, 55);
			layoutControlItem4.TextVisible = false;
			// 
			// layoutControlItem2
			// 
			layoutControlItem2.Control = dateEditBorrowedTime;
			layoutControlItem2.Location = new System.Drawing.Point(0, 52);
			layoutControlItem2.Name = "layoutControlItem2";
			layoutControlItem2.Size = new System.Drawing.Size(316, 26);
			layoutControlItem2.Text = "Borrowed Time";
			layoutControlItem2.TextSize = new System.Drawing.Size(88, 16);
			// 
			// layoutControlItem3
			// 
			layoutControlItem3.Control = dateEditReturnedTime;
			layoutControlItem3.Location = new System.Drawing.Point(0, 78);
			layoutControlItem3.Name = "layoutControlItem3";
			layoutControlItem3.Size = new System.Drawing.Size(316, 26);
			layoutControlItem3.Text = "Returned Time";
			layoutControlItem3.TextSize = new System.Drawing.Size(88, 16);
			// 
			// frmAddBookTransaction
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(336, 323);
			Controls.Add(layoutControl1);
			Name = "frmAddBookTransaction";
			StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "frmAddBookTransaction";
			((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
			layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dateEditReturnedTime.Properties.CalendarTimeProperties).EndInit();
			((System.ComponentModel.ISupportInitialize)dateEditReturnedTime.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)dateEditBorrowedTime.Properties.CalendarTimeProperties).EndInit();
			((System.ComponentModel.ISupportInitialize)dateEditBorrowedTime.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControl3).EndInit();
			layoutControl3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)layoutControl4).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlGroup3).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlGroup2).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem6).EndInit();
			((System.ComponentModel.ISupportInitialize)luBookName.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)gridLookUpEdit2View).EndInit();
			((System.ComponentModel.ISupportInitialize)luStudentName.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)gridLookUpEdit1View).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControl2).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlGroup1).EndInit();
			((System.ComponentModel.ISupportInitialize)Root).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
			((System.ComponentModel.ISupportInitialize)StudentName).EndInit();
			((System.ComponentModel.ISupportInitialize)BookName).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraLayout.LayoutControl layoutControl3;
		private DevExpress.XtraEditors.SimpleButton btnSaveBookOperation;
		private DevExpress.XtraLayout.LayoutControl layoutControl4;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
		private DevExpress.XtraEditors.GridLookUpEdit luBookName;
		private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit2View;
		private DevExpress.XtraEditors.GridLookUpEdit luStudentName;
		private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
		private DevExpress.XtraLayout.LayoutControl layoutControl2;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.LayoutControlItem StudentName;
		private DevExpress.XtraLayout.LayoutControlItem BookName;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
		private DevExpress.XtraEditors.DateEdit dateEditBorrowedTime;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraEditors.DateEdit dateEditReturnedTime;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
	}
}