namespace LibraryApp.UI.Students
{
	partial class frmAddStudent
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
			txtStudentNumber = new DevExpress.XtraEditors.TextEdit();
			txtStudentName = new DevExpress.XtraEditors.TextEdit();
			txtPhoneNumber = new DevExpress.XtraEditors.TextEdit();
			layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
			btnSaveStudent = new DevExpress.XtraEditors.SimpleButton();
			layoutControl3 = new DevExpress.XtraLayout.LayoutControl();
			layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
			layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
			layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			Root = new DevExpress.XtraLayout.LayoutControlGroup();
			emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
			layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
			StudentName = new DevExpress.XtraLayout.LayoutControlItem();
			StudentNumber = new DevExpress.XtraLayout.LayoutControlItem();
			layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
			((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
			layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)txtStudentNumber.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)txtStudentName.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)txtPhoneNumber.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControl2).BeginInit();
			layoutControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)layoutControl3).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlGroup2).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlGroup1).BeginInit();
			((System.ComponentModel.ISupportInitialize)emptySpaceItem3).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
			((System.ComponentModel.ISupportInitialize)Root).BeginInit();
			((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
			((System.ComponentModel.ISupportInitialize)StudentName).BeginInit();
			((System.ComponentModel.ISupportInitialize)StudentNumber).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
			((System.ComponentModel.ISupportInitialize)emptySpaceItem2).BeginInit();
			SuspendLayout();
			// 
			// layoutControl1
			// 
			layoutControl1.Controls.Add(txtStudentNumber);
			layoutControl1.Controls.Add(txtStudentName);
			layoutControl1.Controls.Add(txtPhoneNumber);
			layoutControl1.Controls.Add(layoutControl2);
			layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			layoutControl1.Location = new System.Drawing.Point(0, 0);
			layoutControl1.Name = "layoutControl1";
			layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(327, 0, 812, 500);
			layoutControl1.Root = Root;
			layoutControl1.Size = new System.Drawing.Size(298, 260);
			layoutControl1.TabIndex = 0;
			layoutControl1.Text = "layoutControl1";
			// 
			// txtStudentNumber
			// 
			txtStudentNumber.Location = new System.Drawing.Point(117, 64);
			txtStudentNumber.Name = "txtStudentNumber";
			txtStudentNumber.Size = new System.Drawing.Size(169, 22);
			txtStudentNumber.StyleController = layoutControl1;
			txtStudentNumber.TabIndex = 4;
			// 
			// txtStudentName
			// 
			txtStudentName.Location = new System.Drawing.Point(117, 12);
			txtStudentName.Name = "txtStudentName";
			txtStudentName.Size = new System.Drawing.Size(169, 22);
			txtStudentName.StyleController = layoutControl1;
			txtStudentName.TabIndex = 3;
			// 
			// txtPhoneNumber
			// 
			txtPhoneNumber.Location = new System.Drawing.Point(117, 38);
			txtPhoneNumber.Name = "txtPhoneNumber";
			txtPhoneNumber.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
			txtPhoneNumber.Properties.MaskSettings.Set("MaskManagerSignature", "ignoreMaskBlank=True");
			txtPhoneNumber.Properties.MaskSettings.Set("mask", "(00) 000 000 00 00");
			txtPhoneNumber.Size = new System.Drawing.Size(169, 22);
			txtPhoneNumber.StyleController = layoutControl1;
			txtPhoneNumber.TabIndex = 2;
			// 
			// layoutControl2
			// 
			layoutControl2.Controls.Add(btnSaveStudent);
			layoutControl2.Controls.Add(layoutControl3);
			layoutControl2.Location = new System.Drawing.Point(12, 146);
			layoutControl2.Name = "layoutControl2";
			layoutControl2.Root = layoutControlGroup1;
			layoutControl2.Size = new System.Drawing.Size(274, 102);
			layoutControl2.TabIndex = 1;
			layoutControl2.Text = "layoutControl2";
			// 
			// btnSaveStudent
			// 
			btnSaveStudent.AccessibleName = "btnSaveButton";
			btnSaveStudent.Location = new System.Drawing.Point(139, 63);
			btnSaveStudent.Name = "btnSaveStudent";
			btnSaveStudent.Size = new System.Drawing.Size(123, 27);
			btnSaveStudent.StyleController = layoutControl2;
			btnSaveStudent.TabIndex = 5;
			btnSaveStudent.Text = "Save";
			btnSaveStudent.Click += btnSaveStudent_Click;
			// 
			// layoutControl3
			// 
			layoutControl3.Location = new System.Drawing.Point(12, 12);
			layoutControl3.Name = "layoutControl3";
			layoutControl3.Root = layoutControlGroup2;
			layoutControl3.Size = new System.Drawing.Size(123, 78);
			layoutControl3.TabIndex = 4;
			layoutControl3.Text = "layoutControl3";
			// 
			// layoutControlGroup2
			// 
			layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			layoutControlGroup2.GroupBordersVisible = false;
			layoutControlGroup2.Name = "layoutControlGroup2";
			layoutControlGroup2.Size = new System.Drawing.Size(123, 78);
			layoutControlGroup2.TextVisible = false;
			// 
			// layoutControlGroup1
			// 
			layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			layoutControlGroup1.GroupBordersVisible = false;
			layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { emptySpaceItem3, layoutControlItem3, layoutControlItem4 });
			layoutControlGroup1.Name = "layoutControlGroup1";
			layoutControlGroup1.Size = new System.Drawing.Size(274, 102);
			layoutControlGroup1.TextVisible = false;
			// 
			// emptySpaceItem3
			// 
			emptySpaceItem3.Location = new System.Drawing.Point(127, 0);
			emptySpaceItem3.Name = "emptySpaceItem3";
			emptySpaceItem3.Size = new System.Drawing.Size(127, 51);
			// 
			// layoutControlItem3
			// 
			layoutControlItem3.Control = layoutControl3;
			layoutControlItem3.Location = new System.Drawing.Point(0, 0);
			layoutControlItem3.Name = "layoutControlItem3";
			layoutControlItem3.Size = new System.Drawing.Size(127, 82);
			layoutControlItem3.TextVisible = false;
			// 
			// layoutControlItem4
			// 
			layoutControlItem4.Control = btnSaveStudent;
			layoutControlItem4.Location = new System.Drawing.Point(127, 51);
			layoutControlItem4.Name = "layoutControlItem4";
			layoutControlItem4.Size = new System.Drawing.Size(127, 31);
			layoutControlItem4.TextVisible = false;
			// 
			// Root
			// 
			Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			Root.GroupBordersVisible = false;
			Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { emptySpaceItem1, layoutControlItem5, StudentName, StudentNumber });
			Root.Name = "Root";
			Root.Size = new System.Drawing.Size(298, 260);
			Root.TextVisible = false;
			// 
			// emptySpaceItem1
			// 
			emptySpaceItem1.Location = new System.Drawing.Point(0, 78);
			emptySpaceItem1.Name = "emptySpaceItem1";
			emptySpaceItem1.Size = new System.Drawing.Size(278, 162);
			// 
			// layoutControlItem5
			// 
			layoutControlItem5.Control = txtPhoneNumber;
			layoutControlItem5.Location = new System.Drawing.Point(0, 26);
			layoutControlItem5.Name = "layoutControlItem5";
			layoutControlItem5.Size = new System.Drawing.Size(278, 26);
			layoutControlItem5.Text = "Phone Number";
			layoutControlItem5.TextSize = new System.Drawing.Size(93, 16);
			// 
			// StudentName
			// 
			StudentName.AccessibleName = "txtStudentName";
			StudentName.Control = txtStudentName;
			StudentName.Location = new System.Drawing.Point(0, 0);
			StudentName.Name = "StudentName";
			StudentName.Size = new System.Drawing.Size(278, 26);
			StudentName.Text = "Student Name";
			StudentName.TextSize = new System.Drawing.Size(93, 16);
			// 
			// StudentNumber
			// 
			StudentNumber.Control = txtStudentNumber;
			StudentNumber.Location = new System.Drawing.Point(0, 52);
			StudentNumber.Name = "StudentNumber";
			StudentNumber.Size = new System.Drawing.Size(278, 26);
			StudentNumber.Text = "Student Number";
			StudentNumber.TextSize = new System.Drawing.Size(93, 16);
			// 
			// layoutControlItem2
			// 
			layoutControlItem2.Control = layoutControl2;
			layoutControlItem2.Location = new System.Drawing.Point(0, 134);
			layoutControlItem2.Name = "layoutControlItem2";
			layoutControlItem2.Size = new System.Drawing.Size(278, 106);
			layoutControlItem2.TextVisible = false;
			// 
			// emptySpaceItem2
			// 
			emptySpaceItem2.Location = new System.Drawing.Point(0, 0);
			emptySpaceItem2.Name = "emptySpaceItem2";
			// 
			// frmAddStudent
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(298, 260);
			Controls.Add(layoutControl1);
			Name = "frmAddStudent";
			StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "frmAddStudent";
			((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
			layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)txtStudentNumber.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)txtStudentName.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)txtPhoneNumber.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControl2).EndInit();
			layoutControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)layoutControl3).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlGroup2).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlGroup1).EndInit();
			((System.ComponentModel.ISupportInitialize)emptySpaceItem3).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
			((System.ComponentModel.ISupportInitialize)Root).EndInit();
			((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
			((System.ComponentModel.ISupportInitialize)StudentName).EndInit();
			((System.ComponentModel.ISupportInitialize)StudentNumber).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
			((System.ComponentModel.ISupportInitialize)emptySpaceItem2).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
		private DevExpress.XtraLayout.LayoutControl layoutControl2;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
		private DevExpress.XtraEditors.TextEdit txtPhoneNumber;
		private DevExpress.XtraEditors.SimpleButton btnSaveStudent;
		private DevExpress.XtraLayout.LayoutControl layoutControl3;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
		private DevExpress.XtraEditors.TextEdit txtStudentName;
		private DevExpress.XtraLayout.LayoutControlItem StudentName;
		private DevExpress.XtraEditors.TextEdit txtStudentNumber;
		private DevExpress.XtraLayout.LayoutControlItem StudentNumber;
	}
}