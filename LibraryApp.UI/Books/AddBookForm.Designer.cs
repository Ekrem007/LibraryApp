namespace LibraryApp.UI.Books
{
	partial class AddBookForm
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
			btnSave = new DevExpress.XtraEditors.SimpleButton();
			lblBookName = new System.Windows.Forms.Label();
			lblCategoryName = new System.Windows.Forms.Label();
			lblAuthorName = new System.Windows.Forms.Label();
			txtBookName = new DevExpress.XtraEditors.TextEdit();
			luCategoryName = new DevExpress.XtraEditors.LookUpEdit();
			luAuthorName = new DevExpress.XtraEditors.LookUpEdit();
			((System.ComponentModel.ISupportInitialize)txtBookName.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)luCategoryName.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)luAuthorName.Properties).BeginInit();
			SuspendLayout();
			// 
			// btnSave
			// 
			btnSave.Location = new System.Drawing.Point(189, 170);
			btnSave.Margin = new System.Windows.Forms.Padding(4);
			btnSave.Name = "btnSave";
			btnSave.Size = new System.Drawing.Size(88, 28);
			btnSave.TabIndex = 0;
			btnSave.Text = "Save Book";
			btnSave.Click += btnSave_Click;
			// 
			// lblBookName
			// 
			lblBookName.AutoSize = true;
			lblBookName.Location = new System.Drawing.Point(77, 54);
			lblBookName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			lblBookName.Name = "lblBookName";
			lblBookName.Size = new System.Drawing.Size(71, 16);
			lblBookName.TabIndex = 1;
			lblBookName.Text = "Book Name";
			// 
			// lblCategoryName
			// 
			lblCategoryName.AutoSize = true;
			lblCategoryName.Location = new System.Drawing.Point(77, 92);
			lblCategoryName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			lblCategoryName.Name = "lblCategoryName";
			lblCategoryName.Size = new System.Drawing.Size(95, 16);
			lblCategoryName.TabIndex = 2;
			lblCategoryName.Text = "Category Name";
			// 
			// lblAuthorName
			// 
			lblAuthorName.AutoSize = true;
			lblAuthorName.Location = new System.Drawing.Point(77, 128);
			lblAuthorName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			lblAuthorName.Name = "lblAuthorName";
			lblAuthorName.Size = new System.Drawing.Size(82, 16);
			lblAuthorName.TabIndex = 3;
			lblAuthorName.Text = "Author Name";
			// 
			// txtBookName
			// 
			txtBookName.Location = new System.Drawing.Point(177, 50);
			txtBookName.Margin = new System.Windows.Forms.Padding(4);
			txtBookName.Name = "txtBookName";
			txtBookName.Size = new System.Drawing.Size(117, 22);
			txtBookName.TabIndex = 4;
			// 
			// luCategoryName
			// 
			luCategoryName.Location = new System.Drawing.Point(177, 89);
			luCategoryName.Name = "luCategoryName";
			luCategoryName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
			luCategoryName.Properties.DisplayMember = "CategoryName";
			luCategoryName.Properties.NullText = "Select Category";
			luCategoryName.Properties.ValueMember = "Id";
			luCategoryName.Size = new System.Drawing.Size(156, 22);
			luCategoryName.TabIndex = 5;
			// 
			// luAuthorName
			// 
			luAuthorName.Location = new System.Drawing.Point(177, 125);
			luAuthorName.Name = "luAuthorName";
			luAuthorName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
			luAuthorName.Properties.DisplayMember = "Name";
			luAuthorName.Properties.NullText = "Select Author";
			luAuthorName.Properties.ValueMember = "Id";
			luAuthorName.Size = new System.Drawing.Size(156, 22);
			luAuthorName.TabIndex = 6;
			// 
			// AddBookForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(383, 281);
			Controls.Add(luAuthorName);
			Controls.Add(luCategoryName);
			Controls.Add(txtBookName);
			Controls.Add(lblAuthorName);
			Controls.Add(lblCategoryName);
			Controls.Add(lblBookName);
			Controls.Add(btnSave);
			Margin = new System.Windows.Forms.Padding(4);
			Name = "AddBookForm";
			StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Save Book";
			((System.ComponentModel.ISupportInitialize)txtBookName.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)luCategoryName.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)luAuthorName.Properties).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DevExpress.XtraEditors.SimpleButton btnSave;
		private System.Windows.Forms.Label lblBookName;
		private System.Windows.Forms.Label lblCategoryName;
		private System.Windows.Forms.Label lblAuthorName;
		private DevExpress.XtraEditors.TextEdit txtBookName;
		private DevExpress.XtraEditors.LookUpEdit luCategoryName;
		private DevExpress.XtraEditors.LookUpEdit luAuthorName;
	}
}