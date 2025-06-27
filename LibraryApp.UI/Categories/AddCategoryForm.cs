using DevExpress.XtraEditors;
using LibraryApp.Business.Abstracts;
using LibraryApp.Entities.Concretes;
using LibraryApp.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp.UI.Category
{
	public partial class AddCategoryForm : DevExpress.XtraEditors.XtraForm
	{
		private readonly ICategoryService _categoryService;
		private readonly CategoryDto _categoryToUpdate;
		private readonly int _categoryId;
		public AddCategoryForm(ICategoryService categoryService, int categoryId =0)
		{
			InitializeComponent();
			_categoryService = categoryService;
			_categoryId = categoryId;
			if (_categoryId > 0)
			{
				var category = _categoryService.GetCategoryById(_categoryId);
				if (category != null)
				{
					txtCategoryName.Text = category.CategoryName;
					btnSaveCategory.Text = "Update Category";
				}
			}
			else
			{
				_categoryToUpdate = null;
				btnSaveCategory.Text = "Add Category";
			}

		}

		private void btnSaveCategory_Click(object sender, EventArgs e)
		{
			
			var category = new Entities.Concretes.Category
			{
				Id = _categoryId,
				CategoryName = txtCategoryName.Text
			};
			try
			{
				if (_categoryId > 0)
				{
					_categoryService.UpdateCategory(category);
					MessageBox.Show("Category updated successfully.");
				}
				else
				{
					_categoryService.AddCategory(category);
					MessageBox.Show("Category added successfully.");
				}
				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An error occurred: {ex.Message}");
			}


		}


	
	}
}
