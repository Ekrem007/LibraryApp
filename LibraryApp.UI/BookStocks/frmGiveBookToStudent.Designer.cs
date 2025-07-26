namespace LibraryApp.UI.BookStocks
{
	partial class frmGiveBookToStudent
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
			txtBarcode = new DevExpress.XtraEditors.TextEdit();
			txtBookName = new DevExpress.XtraEditors.TextEdit();
			luStudentName = new DevExpress.XtraEditors.GridLookUpEdit();
			gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
			layoutControl3 = new DevExpress.XtraLayout.LayoutControl();
			layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
			btnSave = new DevExpress.XtraEditors.SimpleButton();
			layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
			layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			Root = new DevExpress.XtraLayout.LayoutControlGroup();
			layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			BookName = new DevExpress.XtraLayout.LayoutControlItem();
			layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
			layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
			layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
			layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dateEditReturnedTime.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)dateEditReturnedTime.Properties.CalendarTimeProperties).BeginInit();
			((System.ComponentModel.ISupportInitialize)dateEditBorrowedTime.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)dateEditBorrowedTime.Properties.CalendarTimeProperties).BeginInit();
			((System.ComponentModel.ISupportInitialize)txtBarcode.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)txtBookName.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)luStudentName.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)gridLookUpEdit1View).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControl3).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlGroup2).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControl2).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlGroup1).BeginInit();
			((System.ComponentModel.ISupportInitialize)Root).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
			((System.ComponentModel.ISupportInitialize)BookName).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem6).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem7).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem8).BeginInit();
			SuspendLayout();
			// 
			// layoutControl1
			// 
			layoutControl1.Controls.Add(dateEditReturnedTime);
			layoutControl1.Controls.Add(dateEditBorrowedTime);
			layoutControl1.Controls.Add(txtBarcode);
			layoutControl1.Controls.Add(txtBookName);
			layoutControl1.Controls.Add(luStudentName);
			layoutControl1.Controls.Add(layoutControl3);
			layoutControl1.Controls.Add(btnSave);
			layoutControl1.Controls.Add(layoutControl2);
			layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			layoutControl1.Location = new System.Drawing.Point(0, 0);
			layoutControl1.Name = "layoutControl1";
			layoutControl1.Root = Root;
			layoutControl1.Size = new System.Drawing.Size(298, 260);
			layoutControl1.TabIndex = 0;
			layoutControl1.Text = "layoutControl1";
			// 
			// dateEditReturnedTime
			// 
			dateEditReturnedTime.EditValue = null;
			dateEditReturnedTime.Location = new System.Drawing.Point(112, 116);
			dateEditReturnedTime.Name = "dateEditReturnedTime";
			dateEditReturnedTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
			dateEditReturnedTime.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
			dateEditReturnedTime.Size = new System.Drawing.Size(174, 22);
			dateEditReturnedTime.StyleController = layoutControl1;
			dateEditReturnedTime.TabIndex = 11;
			// 
			// dateEditBorrowedTime
			// 
			dateEditBorrowedTime.EditValue = null;
			dateEditBorrowedTime.Location = new System.Drawing.Point(112, 90);
			dateEditBorrowedTime.Name = "dateEditBorrowedTime";
			dateEditBorrowedTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
			dateEditBorrowedTime.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
			dateEditBorrowedTime.Size = new System.Drawing.Size(174, 22);
			dateEditBorrowedTime.StyleController = layoutControl1;
			dateEditBorrowedTime.TabIndex = 10;
			// 
			// txtBarcode
			// 
			txtBarcode.Location = new System.Drawing.Point(112, 64);
			txtBarcode.Name = "txtBarcode";
			txtBarcode.Properties.ReadOnly = true;
			txtBarcode.Size = new System.Drawing.Size(174, 22);
			txtBarcode.StyleController = layoutControl1;
			txtBarcode.TabIndex = 9;
			// 
			// txtBookName
			// 
			txtBookName.Location = new System.Drawing.Point(112, 38);
			txtBookName.Name = "txtBookName";
			txtBookName.Properties.ReadOnly = true;
			txtBookName.Size = new System.Drawing.Size(174, 22);
			txtBookName.StyleController = layoutControl1;
			txtBookName.TabIndex = 8;
			// 
			// luStudentName
			// 
			luStudentName.Location = new System.Drawing.Point(112, 12);
			luStudentName.Name = "luStudentName";
			luStudentName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
			luStudentName.Properties.DisplayMember = "Name";
			luStudentName.Properties.NullText = "Choose student";
			luStudentName.Properties.PopupView = gridLookUpEdit1View;
			luStudentName.Properties.ValueMember = "Id";
			luStudentName.Size = new System.Drawing.Size(174, 22);
			luStudentName.StyleController = layoutControl1;
			luStudentName.TabIndex = 7;
			// 
			// gridLookUpEdit1View
			// 
			gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			gridLookUpEdit1View.Name = "gridLookUpEdit1View";
			gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
			gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
			// 
			// layoutControl3
			// 
			layoutControl3.Location = new System.Drawing.Point(12, 221);
			layoutControl3.Name = "layoutControl3";
			layoutControl3.Root = layoutControlGroup2;
			layoutControl3.Size = new System.Drawing.Size(135, 27);
			layoutControl3.TabIndex = 6;
			layoutControl3.Text = "layoutControl3";
			// 
			// layoutControlGroup2
			// 
			layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			layoutControlGroup2.GroupBordersVisible = false;
			layoutControlGroup2.Name = "layoutControlGroup2";
			layoutControlGroup2.Size = new System.Drawing.Size(135, 27);
			layoutControlGroup2.TextVisible = false;
			// 
			// btnSave
			// 
			btnSave.Location = new System.Drawing.Point(151, 221);
			btnSave.Name = "btnSave";
			btnSave.Size = new System.Drawing.Size(135, 27);
			btnSave.StyleController = layoutControl1;
			btnSave.TabIndex = 5;
			btnSave.Text = "Save";
			// 
			// layoutControl2
			// 
			layoutControl2.Location = new System.Drawing.Point(12, 142);
			layoutControl2.Name = "layoutControl2";
			layoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(316, 0, 812, 500);
			layoutControl2.Root = layoutControlGroup1;
			layoutControl2.Size = new System.Drawing.Size(274, 75);
			layoutControl2.TabIndex = 4;
			layoutControl2.Text = "layoutControl2";
			// 
			// layoutControlGroup1
			// 
			layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			layoutControlGroup1.GroupBordersVisible = false;
			layoutControlGroup1.Name = "Root";
			layoutControlGroup1.Size = new System.Drawing.Size(274, 75);
			layoutControlGroup1.TextVisible = false;
			// 
			// Root
			// 
			Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			Root.GroupBordersVisible = false;
			Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, layoutControlItem2, layoutControlItem3, layoutControlItem4, BookName, layoutControlItem6, layoutControlItem7, layoutControlItem8 });
			Root.Name = "Root";
			Root.Size = new System.Drawing.Size(298, 260);
			Root.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			layoutControlItem1.Control = layoutControl2;
			layoutControlItem1.Location = new System.Drawing.Point(0, 130);
			layoutControlItem1.Name = "layoutControlItem1";
			layoutControlItem1.Size = new System.Drawing.Size(278, 79);
			layoutControlItem1.TextVisible = false;
			// 
			// layoutControlItem2
			// 
			layoutControlItem2.Control = btnSave;
			layoutControlItem2.Location = new System.Drawing.Point(139, 209);
			layoutControlItem2.Name = "layoutControlItem2";
			layoutControlItem2.Size = new System.Drawing.Size(139, 31);
			layoutControlItem2.TextVisible = false;
			// 
			// layoutControlItem3
			// 
			layoutControlItem3.Control = layoutControl3;
			layoutControlItem3.Location = new System.Drawing.Point(0, 209);
			layoutControlItem3.Name = "layoutControlItem3";
			layoutControlItem3.Size = new System.Drawing.Size(139, 31);
			layoutControlItem3.TextVisible = false;
			// 
			// layoutControlItem4
			// 
			layoutControlItem4.Control = luStudentName;
			layoutControlItem4.Location = new System.Drawing.Point(0, 0);
			layoutControlItem4.Name = "layoutControlItem4";
			layoutControlItem4.Size = new System.Drawing.Size(278, 26);
			layoutControlItem4.Text = "Student Name";
			layoutControlItem4.TextSize = new System.Drawing.Size(88, 16);
			// 
			// BookName
			// 
			BookName.Control = txtBookName;
			BookName.Location = new System.Drawing.Point(0, 26);
			BookName.Name = "BookName";
			BookName.Size = new System.Drawing.Size(278, 26);
			BookName.Text = "Book Name";
			BookName.TextSize = new System.Drawing.Size(88, 16);
			// 
			// layoutControlItem6
			// 
			layoutControlItem6.Control = txtBarcode;
			layoutControlItem6.Location = new System.Drawing.Point(0, 52);
			layoutControlItem6.Name = "layoutControlItem6";
			layoutControlItem6.Size = new System.Drawing.Size(278, 26);
			layoutControlItem6.Text = "Book Barcode";
			layoutControlItem6.TextSize = new System.Drawing.Size(88, 16);
			// 
			// layoutControlItem7
			// 
			layoutControlItem7.Control = dateEditBorrowedTime;
			layoutControlItem7.Location = new System.Drawing.Point(0, 78);
			layoutControlItem7.Name = "layoutControlItem7";
			layoutControlItem7.Size = new System.Drawing.Size(278, 26);
			layoutControlItem7.Text = "Borrowed Time";
			layoutControlItem7.TextSize = new System.Drawing.Size(88, 16);
			// 
			// layoutControlItem8
			// 
			layoutControlItem8.Control = dateEditReturnedTime;
			layoutControlItem8.Location = new System.Drawing.Point(0, 104);
			layoutControlItem8.Name = "layoutControlItem8";
			layoutControlItem8.Size = new System.Drawing.Size(278, 26);
			layoutControlItem8.Text = "Returned Time";
			layoutControlItem8.TextSize = new System.Drawing.Size(88, 16);
			// 
			// frmGiveBookToStudent
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(298, 260);
			Controls.Add(layoutControl1);
			Name = "frmGiveBookToStudent";
			Text = "frmGiveBookToStudent";
			((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
			layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dateEditReturnedTime.Properties.CalendarTimeProperties).EndInit();
			((System.ComponentModel.ISupportInitialize)dateEditReturnedTime.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)dateEditBorrowedTime.Properties.CalendarTimeProperties).EndInit();
			((System.ComponentModel.ISupportInitialize)dateEditBorrowedTime.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)txtBarcode.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)txtBookName.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)luStudentName.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)gridLookUpEdit1View).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControl3).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlGroup2).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControl2).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlGroup1).EndInit();
			((System.ComponentModel.ISupportInitialize)Root).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
			((System.ComponentModel.ISupportInitialize)BookName).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem6).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem7).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem8).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraEditors.TextEdit txtBarcode;
		private DevExpress.XtraEditors.TextEdit txtBookName;
		private DevExpress.XtraEditors.GridLookUpEdit luStudentName;
		private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
		private DevExpress.XtraLayout.LayoutControl layoutControl3;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
		private DevExpress.XtraEditors.SimpleButton btnSave;
		private DevExpress.XtraLayout.LayoutControl layoutControl2;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
		private DevExpress.XtraLayout.LayoutControlItem BookName;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
		private DevExpress.XtraEditors.DateEdit dateEditReturnedTime;
		private DevExpress.XtraEditors.DateEdit dateEditBorrowedTime;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
	}
}