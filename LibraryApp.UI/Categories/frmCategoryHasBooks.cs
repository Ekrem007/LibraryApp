using DevExpress.XtraEditors;
using LibraryApp.Business.Abstracts;
using LibraryApp.Business.Concretes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp.UI.Categories
{
	public partial class frmCategoryHasBooks : DevExpress.XtraEditors.XtraForm
	{
		private readonly ICategoryService _categoryService;
		private readonly int _categoryId;
		public frmCategoryHasBooks(ICategoryService categoryService, int categoryId)
		{
			InitializeComponent();
			_categoryService = categoryService;
			_categoryId = categoryId;
			LoadCategoryHasBooks(_categoryId);

		}
		private void LoadCategoryHasBooks(int categoryId)
		{
			var studentHasBooks = _categoryService.GetCategoriesHasBooks(_categoryId);

			gridControlCategoryHasBooks.DataSource = studentHasBooks;
			gridViewCategoryHasBooks.BestFitColumns();
		}
	}
}