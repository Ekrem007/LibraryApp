using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using LibraryApp.Business.Abstracts;
using LibraryApp.Entities.Concretes;
using LibraryApp.Entities.Dtos;
using LibraryApp.UI.BookTransactions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp.UI.BookStocks
{
	public partial class frmBookStocks : DevExpress.XtraEditors.XtraForm
	{
		private readonly IBookService _bookService;
		private readonly IStudentService _studentService;
		private readonly IBookTransactionService _bookTransactionService;
		private readonly IBookStockService _bookStockService;
		public frmBookStocks(IBookService bookService, IStudentService studentService, IBookTransactionService bookTransactionService,
			IBookStockService bookStockService)
		{
			InitializeComponent();
			_bookService = bookService;
			_studentService = studentService;
			_bookTransactionService = bookTransactionService;
			_bookStockService = bookStockService;
			btnAddBookStock.ItemClick += btnAddBookStock_ItemClick;
			gridViewBookStocks.MouseUp += gridControlBookStocks_MouseUp;
			btnDeleteBook.ItemClick += btnDeleteBookStock_ItemClick;
			btnGiveBookToStudent.ItemClick += btnGiveBookToStudent_ItemClick;
			btnDamaged.ItemClick += btnDamaged_ItemClick;
			btnLost.ItemClick += btnLost_ItemClick;
			btnNormal.ItemClick += btnNormal_ItemClick;
			gridViewBookStocks.RowStyle += gridViewBookStocks_RowStyle;
			LoadBookStocks();

		}
		private void gridControlBookStocks_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				popupMenuBookStocks.ShowPopup(Control.MousePosition);
			}
		}
		private void btnAddBookStock_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frmAddBookStock addBookStockForm = new frmAddBookStock(_bookService, _bookStockService);
			addBookStockForm.ShowDialog();
		}
		private void LoadBookStocks()
		{
			try
			{
				var bookStocks = _bookStockService.GetAllBookStocks();
				gridControlBookStocks.DataSource = bookStocks;
			}
			catch (Exception ex)
			{
				XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void btnDeleteBookStock_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (gridViewBookStocks.GetFocusedRow() is null)
			{
				XtraMessageBox.Show("Please select a book stock to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			var bookStock = gridViewBookStocks.GetFocusedRow() as BookStockDto;
			if (bookStock == null)
			{
				XtraMessageBox.Show("Invalid book stock selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			try
			{
				_bookStockService.DeleteBookStock(bookStock.Id);
				XtraMessageBox.Show("Book stock deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				LoadBookStocks();
			}
			catch (Exception ex)
			{
				XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void btnGiveBookToStudent_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (gridViewBookStocks.GetFocusedRow() is BookStockDto bookStock)
			{
				if (bookStock.IsAvailable == "Not Available")
				{
					XtraMessageBox.Show("This book Not available", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				int bookStockId = bookStock.Id;

				frmGiveBookToStudent giveBookForm = new frmGiveBookToStudent(_bookTransactionService, _studentService, _bookService, _bookStockService, bookStock.Id);
				giveBookForm.ShowDialog();
			}
			else
			{
				XtraMessageBox.Show("Please select a book stock to give.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void gridControlBookStocks_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.F5)
			{
				LoadBookStocks();
			}
		}
		private void btnDamaged_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (gridViewBookStocks.GetFocusedRow() is BookStockDto bookStock)
			{
				int bookStockId = bookStock.Id;
				_bookStockService.ChangeBookStockStatus(bookStockId, BookStockStatus.Damaged);
				XtraMessageBox.Show("Book stock status changed to 'Damaged'.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				LoadBookStocks();
			}
			else
			{
				XtraMessageBox.Show("Please select a book stock to mark as damaged.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		private void btnLost_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (gridViewBookStocks.GetFocusedRow() is BookStockDto bookStock)
			{
				int bookStockId = bookStock.Id;
				_bookStockService.ChangeBookStockStatus(bookStockId, BookStockStatus.Lost);
				XtraMessageBox.Show("Book stock status changed to 'Lost'.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				LoadBookStocks();
			}
			else
			{
				XtraMessageBox.Show("Please select a book stock to mark as lost.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		private void btnNormal_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (gridViewBookStocks.GetFocusedRow() is BookStockDto bookStock)
			{
				int bookStockId = bookStock.Id;
				_bookStockService.ChangeBookStockStatus(bookStockId, BookStockStatus.Normal);
				XtraMessageBox.Show("Book stock status changed to 'Normal'.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				LoadBookStocks();
			}
			else
			{
				XtraMessageBox.Show("Please select a book stock to mark as normal.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		private void gridViewBookStocks_RowStyle(object sender, RowStyleEventArgs e)
		{
			if (e.RowHandle >= 0)
			{
				GridView view = sender as GridView;
				var statusObj = view.GetRowCellValue(e.RowHandle, "Status");

				if (statusObj != null)
				{
					string statusString = statusObj.ToString();

					if (statusString == BookStockStatus.Damaged.ToString())
					{
						e.Appearance.ForeColor = Color.Red;
					}
					else if (statusString == BookStockStatus.Lost.ToString())
					{
						e.Appearance.ForeColor = Color.Goldenrod; 
					}
				}
			}
		}


	}
}