namespace LibraryApp.UI.Category
{
	partial class AddCategoryForm
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			txtCategoryName = new DevExpress.XtraEditors.TextEdit();
			btnSaveCategory = new DevExpress.XtraEditors.SimpleButton();
			Root = new DevExpress.XtraLayout.LayoutControlGroup();
			emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
			lycCategoryName = new DevExpress.XtraLayout.LayoutControlItem();
			emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
			layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
			layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)txtCategoryName.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)Root).BeginInit();
			((System.ComponentModel.ISupportInitialize)emptySpaceItem2).BeginInit();
			((System.ComponentModel.ISupportInitialize)lycCategoryName).BeginInit();
			((System.ComponentModel.ISupportInitialize)emptySpaceItem3).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
			SuspendLayout();
			// 
			// layoutControl1
			// 
			layoutControl1.Controls.Add(txtCategoryName);
			layoutControl1.Controls.Add(btnSaveCategory);
			layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			layoutControl1.Location = new System.Drawing.Point(0, 0);
			layoutControl1.Margin = new System.Windows.Forms.Padding(4);
			layoutControl1.Name = "layoutControl1";
			layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(361, 0, 812, 500);
			layoutControl1.Root = Root;
			layoutControl1.Size = new System.Drawing.Size(332, 267);
			layoutControl1.TabIndex = 0;
			layoutControl1.Text = "layoutControl1";
			// 
			// txtCategoryName
			// 
			txtCategoryName.Location = new System.Drawing.Point(112, 12);
			txtCategoryName.Margin = new System.Windows.Forms.Padding(4);
			txtCategoryName.Name = "txtCategoryName";
			txtCategoryName.Size = new System.Drawing.Size(208, 22);
			txtCategoryName.StyleController = layoutControl1;
			txtCategoryName.TabIndex = 0;
			// 
			// btnSaveCategory
			// 
			btnSaveCategory.Location = new System.Drawing.Point(123, 228);
			btnSaveCategory.Margin = new System.Windows.Forms.Padding(4);
			btnSaveCategory.Name = "btnSaveCategory";
			btnSaveCategory.Size = new System.Drawing.Size(197, 27);
			btnSaveCategory.StyleController = layoutControl1;
			btnSaveCategory.TabIndex = 2;
			btnSaveCategory.Text = "Save Category";
			btnSaveCategory.Click += btnSaveCategory_Click;
			// 
			// Root
			// 
			Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			Root.GroupBordersVisible = false;
			Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { emptySpaceItem2, lycCategoryName, emptySpaceItem3, layoutControlItem1 });
			Root.Name = "Root";
			Root.Size = new System.Drawing.Size(332, 267);
			Root.TextVisible = false;
			// 
			// emptySpaceItem2
			// 
			emptySpaceItem2.Location = new System.Drawing.Point(0, 26);
			emptySpaceItem2.Name = "emptySpaceItem2";
			emptySpaceItem2.Size = new System.Drawing.Size(111, 221);
			// 
			// lycCategoryName
			// 
			lycCategoryName.Control = txtCategoryName;
			lycCategoryName.Location = new System.Drawing.Point(0, 0);
			lycCategoryName.Name = "lycCategoryName";
			lycCategoryName.Size = new System.Drawing.Size(312, 26);
			lycCategoryName.Text = "Category Name";
			lycCategoryName.TextSize = new System.Drawing.Size(88, 16);
			// 
			// emptySpaceItem3
			// 
			emptySpaceItem3.Location = new System.Drawing.Point(111, 26);
			emptySpaceItem3.Name = "emptySpaceItem3";
			emptySpaceItem3.Size = new System.Drawing.Size(201, 190);
			// 
			// layoutControlItem1
			// 
			layoutControlItem1.Control = btnSaveCategory;
			layoutControlItem1.Location = new System.Drawing.Point(111, 216);
			layoutControlItem1.Name = "layoutControlItem1";
			layoutControlItem1.Size = new System.Drawing.Size(201, 31);
			layoutControlItem1.TextVisible = false;
			// 
			// AddCategoryForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(332, 267);
			Controls.Add(layoutControl1);
			Margin = new System.Windows.Forms.Padding(4);
			Name = "AddCategoryForm";
			StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Save Category";
			((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
			layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)txtCategoryName.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)Root).EndInit();
			((System.ComponentModel.ISupportInitialize)emptySpaceItem2).EndInit();
			((System.ComponentModel.ISupportInitialize)lycCategoryName).EndInit();
			((System.ComponentModel.ISupportInitialize)emptySpaceItem3).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraEditors.TextEdit txtCategoryName;
		private DevExpress.XtraEditors.SimpleButton btnSaveCategory;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
		private DevExpress.XtraLayout.LayoutControlItem lycCategoryName;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
	}
}
