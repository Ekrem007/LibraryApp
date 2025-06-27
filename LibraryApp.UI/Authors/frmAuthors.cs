using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using LibraryApp.Business.Abstracts;
using LibraryApp.Business.Concretes;
using LibraryApp.Entities.Dtos;
using LibraryApp.UI.Author;
using LibraryApp.UI.Books;
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
	public partial class frmAuthors : DevExpress.XtraEditors.XtraForm
	{
		private readonly IAuthorService _authorService;
		public frmAuthors(IAuthorService authorService)
		{
			InitializeComponent();
			_authorService = authorService;
			LoadAuthors();
			btnUpdateAuthor.ItemClick += btnUpdateAuthor_ItemClick;
			btnDeleteAuthor.ItemClick += btnDeleteAuthor_ItemClick;
			btnAddAuthor.ItemClick += btnAddAuthor_ItemClick;
			gridViewAuthors.MouseUp += gridViewAuthors_MouseUp;
			btnRefreshData.ItemClick += btnRefreshData_ItemClick;
		}

		private void LoadAuthors()
		{
			var authors = _authorService.GetAllAuthors();
			gridControlAuthors.DataSource = authors;
			gridViewAuthors.BestFitColumns();
		}
		private void OpenUpdateOrSaveAuthorForm()
		{
			if (gridViewAuthors.GetFocusedRow() is AuthorDto selectedAuthor)
			{
				int authorId = selectedAuthor.Id;
				if (selectedAuthor != null)
				{
					AddAuthorForm updateAuthorForm = new AddAuthorForm(_authorService, authorId);
					updateAuthorForm.ShowDialog();
					LoadAuthors();
				}
			}
			else
			{
				XtraMessageBox.Show("Lütfen güncellemek istediğiniz yazarı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		private void gridViewAuthors_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
				var hitInfo = view.CalcHitInfo(e.Location);
				if (hitInfo.InRow || hitInfo.InRowCell)
				{
					view.FocusedRowHandle = hitInfo.RowHandle;
					popupMenuAuthors.ShowPopup(Control.MousePosition);
				}
			}
		}
		private void btnAddAuthor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			AddAuthorForm addAuthorForm = new AddAuthorForm(_authorService);
			addAuthorForm.ShowDialog();
			LoadAuthors();
		}
		private void btnDeleteAuthor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (gridViewAuthors.FocusedRowHandle >= 0)
			{
				var selectedAuthor = gridViewAuthors.GetFocusedRow() as AuthorDto;
				if (selectedAuthor != null)
				{
					var confirmResult = XtraMessageBox.Show("Yazarı silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (confirmResult == DialogResult.Yes)
					{
						_authorService.DeleteAuthor(selectedAuthor.Id);
						LoadAuthors();
					}
				}
			}
			else
			{
				XtraMessageBox.Show("Lütfen silmek istediğiniz yazarı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		private void btnRefreshData_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			LoadAuthors();
			MessageBox.Show("Authors refreshed successfully.");
		}

		private void gridControlAuthors_KeyDown(object sender, KeyEventArgs e)
		{

			if (e.KeyCode == Keys.F5)
			{
				LoadAuthors();
				MessageBox.Show("Authors refreshed successfully.");
			}
		}

		private void gridControlAuthors_DoubleClick(object sender, EventArgs e)
		{

			OpenUpdateOrSaveAuthorForm();
		}
		private void btnUpdateAuthor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			OpenUpdateOrSaveAuthorForm();
		}
	}
}