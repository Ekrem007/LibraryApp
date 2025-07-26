using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using LibraryApp.Business.Abstracts;
using LibraryApp.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp.UI.DamagedLostBooks
{
	public partial class frmDamagedLostBooks : DevExpress.XtraEditors.XtraForm
	{
		private readonly IBookStockService _bookStockService;
		public frmDamagedLostBooks(IBookStockService bookStockService)
		{
			InitializeComponent();
			_bookStockService = bookStockService;
			LoadDamagedLostBooks();
			gridViewDamagedLostBooks.MouseUp += gridViewBookStocks_MouseUp;
			btnDamaged.ItemClick += btnDamaged_ItemClick;
			btnLost.ItemClick += btnLost_ItemClick;
			btnNormal.ItemClick += btnNormal_ItemClick;
		}
		private void LoadDamagedLostBooks()
		{

			if (_bookStockService != null)
			{
				try
				{
					var damagedLostBooks = _bookStockService.GetDamagedLostBooks();
					gridControlDamagedLostBooks.DataSource = damagedLostBooks;
					gridViewDamagedLostBooks.BestFitColumns();
				}
				catch (Exception ex)
				{
					XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				XtraMessageBox.Show("Book stock service is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void gridViewBookStocks_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
				if (view == null) return;

				var hitInfo = view.CalcHitInfo(e.Location);
				if (hitInfo.InRow)
				{
					view.FocusedRowHandle = hitInfo.RowHandle;
					popupMenuDamagedLostBooks.ShowPopup(Control.MousePosition);
				}
			}
		}
		private void btnDamaged_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (gridViewDamagedLostBooks.FocusedRowHandle >= 0)
			{
				var bookStockId = (int)gridViewDamagedLostBooks.GetFocusedRowCellValue("BookStockId");
				try
				{
					_bookStockService.ChangeBookStockStatus(bookStockId, BookStockStatus.Damaged);
					XtraMessageBox.Show("Book stock status changed to 'Damaged'.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					LoadDamagedLostBooks();
				}
				catch (Exception ex)
				{
					XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				XtraMessageBox.Show("Please select a book stock to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		private void btnLost_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (gridViewDamagedLostBooks.FocusedRowHandle >= 0)
			{
				var bookStockId = (int)gridViewDamagedLostBooks.GetFocusedRowCellValue("BookStockId");
				try
				{
					_bookStockService.ChangeBookStockStatus(bookStockId, BookStockStatus.Lost);
					XtraMessageBox.Show("Book stock status changed to 'Lost'.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					LoadDamagedLostBooks();
				}
				catch (Exception ex)
				{
					XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				XtraMessageBox.Show("Please select a book stock to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		private void btnNormal_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (gridViewDamagedLostBooks.FocusedRowHandle >= 0)
			{
				var bookStockId = (int)gridViewDamagedLostBooks.GetFocusedRowCellValue("BookStockId");
				try
				{
					_bookStockService.ChangeBookStockStatus(bookStockId, BookStockStatus.Normal);
					XtraMessageBox.Show("Book stock status changed to 'Normal'.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					LoadDamagedLostBooks();
				}
				catch (Exception ex)
				{
					XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				XtraMessageBox.Show("Please select a book stock to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}


		}
	}
}