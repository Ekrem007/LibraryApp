namespace LibraryApp.UI.Author
{
	partial class AddAuthorForm
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
			txtAuthorName = new DevExpress.XtraEditors.TextEdit();
			btnSaveAuthor = new DevExpress.XtraEditors.SimpleButton();
			Root = new DevExpress.XtraLayout.LayoutControlGroup();
			emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
			lycAuthorName = new DevExpress.XtraLayout.LayoutControlItem();
			emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
			layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
			layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)txtAuthorName.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)Root).BeginInit();
			((System.ComponentModel.ISupportInitialize)emptySpaceItem2).BeginInit();
			((System.ComponentModel.ISupportInitialize)lycAuthorName).BeginInit();
			((System.ComponentModel.ISupportInitialize)emptySpaceItem3).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
			SuspendLayout();
			// 
			// layoutControl1
			// 
			layoutControl1.Controls.Add(txtAuthorName);
			layoutControl1.Controls.Add(btnSaveAuthor);
			layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			layoutControl1.Location = new System.Drawing.Point(0, 0);
			layoutControl1.Margin = new System.Windows.Forms.Padding(5);
			layoutControl1.Name = "layoutControl1";
			layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(321, 7, 650, 400);
			layoutControl1.Root = Root;
			layoutControl1.Size = new System.Drawing.Size(348, 330);
			layoutControl1.TabIndex = 1;
			layoutControl1.Text = "layoutControl1";
			// 
			// txtAuthorName
			// 
			txtAuthorName.Location = new System.Drawing.Point(99, 12);
			txtAuthorName.Margin = new System.Windows.Forms.Padding(4);
			txtAuthorName.Name = "txtAuthorName";
			txtAuthorName.Size = new System.Drawing.Size(237, 22);
			txtAuthorName.StyleController = layoutControl1;
			txtAuthorName.TabIndex = 0;
			// 
			// btnSaveAuthor
			// 
			btnSaveAuthor.Location = new System.Drawing.Point(131, 291);
			btnSaveAuthor.Margin = new System.Windows.Forms.Padding(4);
			btnSaveAuthor.Name = "btnSaveAuthor";
			btnSaveAuthor.Size = new System.Drawing.Size(205, 27);
			btnSaveAuthor.StyleController = layoutControl1;
			btnSaveAuthor.TabIndex = 2;
			btnSaveAuthor.Text = "Save Author";
			btnSaveAuthor.Click += btnSaveAuthor_Click;
			// 
			// Root
			// 
			Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			Root.GroupBordersVisible = false;
			Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { emptySpaceItem2, lycAuthorName, emptySpaceItem3, layoutControlItem1 });
			Root.Name = "Root";
			Root.Size = new System.Drawing.Size(348, 330);
			Root.TextVisible = false;
			// 
			// emptySpaceItem2
			// 
			emptySpaceItem2.Location = new System.Drawing.Point(0, 26);
			emptySpaceItem2.Name = "emptySpaceItem2";
			emptySpaceItem2.Size = new System.Drawing.Size(119, 284);
			// 
			// lycAuthorName
			// 
			lycAuthorName.Control = txtAuthorName;
			lycAuthorName.Location = new System.Drawing.Point(0, 0);
			lycAuthorName.Name = "lycAuthorName";
			lycAuthorName.Size = new System.Drawing.Size(328, 26);
			lycAuthorName.Text = "Author Name";
			lycAuthorName.TextSize = new System.Drawing.Size(75, 16);
			// 
			// emptySpaceItem3
			// 
			emptySpaceItem3.Location = new System.Drawing.Point(119, 26);
			emptySpaceItem3.Name = "emptySpaceItem3";
			emptySpaceItem3.Size = new System.Drawing.Size(209, 253);
			// 
			// layoutControlItem1
			// 
			layoutControlItem1.Control = btnSaveAuthor;
			layoutControlItem1.Location = new System.Drawing.Point(119, 279);
			layoutControlItem1.Name = "layoutControlItem1";
			layoutControlItem1.Size = new System.Drawing.Size(209, 31);
			layoutControlItem1.TextVisible = false;
			// 
			// AddAuthorForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(348, 330);
			Controls.Add(layoutControl1);
			Margin = new System.Windows.Forms.Padding(4);
			Name = "AddAuthorForm";
			StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Save Author";
			((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
			layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)txtAuthorName.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)Root).EndInit();
			((System.ComponentModel.ISupportInitialize)emptySpaceItem2).EndInit();
			((System.ComponentModel.ISupportInitialize)lycAuthorName).EndInit();
			((System.ComponentModel.ISupportInitialize)emptySpaceItem3).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraEditors.TextEdit txtAuthorName;
		private DevExpress.XtraEditors.SimpleButton btnSaveAuthor;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
		private DevExpress.XtraLayout.LayoutControlItem lycAuthorName;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
	}
}