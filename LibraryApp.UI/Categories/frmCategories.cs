using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using LibraryApp.Business.Abstracts;
using LibraryApp.Business.Concretes;
using LibraryApp.Entities.Concretes;
using LibraryApp.Entities.Dtos;
using LibraryApp.UI.Books;
using LibraryApp.UI.Categories;
using LibraryApp.UI.Category;
using LibraryApp.UI.Students;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp.UI.frmAuthor
{
	public partial class frmCategories : DevExpress.XtraEditors.XtraForm
	{
		private readonly ICategoryService _categoryService;
		public frmCategories(ICategoryService categoryService)
		{
			InitializeComponent();
			_categoryService = categoryService;
			gridViewCategories.MouseUp += gridViewCategories_MouseUp;
			btnAddCategory.ItemClick += btnAddCategory_ItemClick;
			btnUpdateCategory.ItemClick += btnUpdateCategory_ItemClick;
			btnDeleteCategory.ItemClick += btnDeleteCategory_ItemClick;
			btnRefreshData.ItemClick += btnRefreshData_ItemClick;
			btnGetCategoryHasBooks.ItemClick += btnGetCategoriesHasBooks_ItemClick;
			LoadCategories();

		}
		private void LoadCategories()
		{
			var categories = _categoryService.GetAllCategories();
			gridControlCategories.DataSource = categories;
			gridViewCategories.BestFitColumns();
		}

		private void OpenUpdateOrAddCategoryForm()
		{
			if (gridViewCategories.GetFocusedRow() is CategoryDto selectedCategory)
			{
				int categoryId = selectedCategory.Id;
				AddCategoryForm addCategoryForm = new AddCategoryForm(_categoryService, categoryId);
				addCategoryForm.ShowDialog();
			}
			else
			{
				XtraMessageBox.Show("Lütfen güncellemek istediğiniz kategoriyi seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		private void gridViewCategories_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
				var hitInfo = view.CalcHitInfo(e.Location);
				if (hitInfo.InRow || hitInfo.InRowCell)
				{
					view.FocusedRowHandle = hitInfo.RowHandle;
					popupMenuCategories.ShowPopup(Control.MousePosition);
				}
			}
		}
		private void btnAddCategory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			var frm = new AddCategoryForm(_categoryService);
			if (frm.ShowDialog() == DialogResult.OK)
			{
				LoadCategories();
			}
		}

		private void btnDeleteCategory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			var selectedRow = gridViewCategories.GetFocusedRow();
			if (selectedRow != null)
			{
				var category = (CategoryDto)selectedRow;
				if (XtraMessageBox.Show($"'{category.CategoryName}' kategorisini silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					_categoryService.DeleteCategory(category.Id);
					LoadCategories();
				}
			}
			else
			{
				XtraMessageBox.Show("Lütfen silmek istediğiniz kategoriyi seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void gridControlCategories_KeyDown(object sender, KeyEventArgs e)
		{

			if (e.KeyCode == Keys.F5)
			{
				LoadCategories();
				MessageBox.Show("Categories refreshed successfully.");
			}
		}
		private void btnRefreshData_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			LoadCategories();
			MessageBox.Show("Categories refreshed successfully.");
		}
		private void btnGetCategoriesHasBooks_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			try
			{
				if (gridViewCategories.GetFocusedRow() is CategoryDto selectedCategory)
				{
					int categoryId = selectedCategory.Id;
					var categoriesHasBooks = _categoryService.GetCategoriesHasBooks(categoryId);
					if (categoriesHasBooks != null && categoriesHasBooks.Count != 0)
					{
						frmCategoryHasBooks categoryHasBooksForm = new frmCategoryHasBooks(_categoryService, categoryId);
						categoryHasBooksForm.ShowDialog();
					}
					else
					{
						MessageBox.Show("there are no books for this category");
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private void gridControlCategories_DoubleClick(object sender, EventArgs e)
		{
			OpenUpdateOrAddCategoryForm();

		}
		private void btnUpdateCategory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			OpenUpdateOrAddCategoryForm();
		}
		


	}

}