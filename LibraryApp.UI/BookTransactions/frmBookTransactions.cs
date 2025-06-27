using DevExpress.XtraEditors;
using LibraryApp.Business.Abstracts;
using LibraryApp.Business.Concretes;
using LibraryApp.Entities.Dtos;
using LibraryApp.UI.Books;
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

namespace LibraryApp.UI.frmBookTransaction
{
	public partial class frmBookTransactions : DevExpress.XtraEditors.XtraForm
	{
		private readonly IBookTransactionService _bookTransactionService;
		private readonly IStudentService _studentService;
		private readonly IBookService _bookService;
		public frmBookTransactions(IBookTransactionService bookTransactionService, IStudentService studentService, IBookService bookService)
		{
			InitializeComponent();
			_bookTransactionService = bookTransactionService;
			_studentService = studentService;
			_bookService = bookService;
			LoadBookTransactions();
			gridViewBookTransferOperations.MouseUp += gridViewBookTransactions_MouseUp;
			btnUpdateBookTransaction.ItemClick += btnUpdateBookTransaction_ItemClick;
			btnGiveBookToStudent.ItemClick += btnGiveBookToStudent_ItemClick;
			btnDeleteBookTransaction.ItemClick += btnDeleteBookTransaction_ItemClick;
			btnRefreshData.ItemClick += btnRefreshData_ItemClick;
			btnReturnBook.ItemClick += btnReturnBook_ItemClick;


		}
		private void LoadBookTransactions()
		{

			var bookTransactions = _bookTransactionService.GetAllBookTransactions();
			gridControlBookTransferOperations.DataSource = bookTransactions;
			gridViewBookTransferOperations.BestFitColumns();
		}

		private void btnGiveBookToStudent_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frmAddBookTransaction addBookTransactionForm = new frmAddBookTransaction(_bookTransactionService, _studentService, _bookService);
			addBookTransactionForm.Show();
		}
		private void gridViewBookTransactions_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
				var hitInfo = view.CalcHitInfo(e.Location);
				if (hitInfo.InRow || hitInfo.InRowCell)
				{
					view.FocusedRowHandle = hitInfo.RowHandle;
				}
				popupMenuBookTransactions.ShowPopup(Control.MousePosition);
			}
		}


		private void OpenUpdateForm()
		{
			if (gridViewBookTransferOperations.GetFocusedRow() is BookTransactionsWithDetailsDto selectedTransaction)
			{
				int bookTransactionId = selectedTransaction.Id;
				frmAddBookTransaction addBookTransactionForm = new frmAddBookTransaction(_bookTransactionService, _studentService, _bookService, bookTransactionId);
				addBookTransactionForm.Show();
			}
			else
			{
				MessageBox.Show("Please select a book transaction to update.");
			}
		}

		private void btnDeleteBookTransaction_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (gridViewBookTransferOperations.GetFocusedRow() is BookTransactionsWithDetailsDto selectedTransaction)
			{
				int bookTransactionId = selectedTransaction.Id;
				var result = MessageBox.Show("Are you sure you want to delete this book transaction?", "Confirm Delete", MessageBoxButtons.YesNo);
				if (result == DialogResult.Yes)
				{
					_bookTransactionService.DeleteBookTransaction(bookTransactionId);
					MessageBox.Show("Book transaction deleted successfully.");
					LoadBookTransactions();
				}
			}
			else
			{
				MessageBox.Show("Please select a book transaction to delete.");
			}
		}
		private void btnRefreshData_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			LoadBookTransactions();
			MessageBox.Show("Data refreshed successfully.");
		}

		private void frmBookTransactions_DoubleClick(object sender, EventArgs e)
		{
			OpenUpdateForm();
		}
		private void btnUpdateBookTransaction_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			OpenUpdateForm();
		}

		private void gridControlBookTransferOperations_KeyDown(object sender, KeyEventArgs e)
		{

			if (e.KeyCode == Keys.F5)
			{
				LoadBookTransactions();
				MessageBox.Show("Book transactions refreshed successfully.");
			}

		}
		private void btnReturnBook_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{


			if (gridViewBookTransferOperations.GetFocusedRow() is BookTransactionsWithDetailsDto selectedTransaction)
			{
				if (selectedTransaction.ReturnDate != null)
				{
					MessageBox.Show("book already returned");
					return;
				}
				int bookId = (int)selectedTransaction.BookId;
				_bookTransactionService.ReturnBook(bookId);
				MessageBox.Show("Book returned successfully.");
				LoadBookTransactions();
				if (selectedTransaction.ReturnDate != null)
				{
					MessageBox.Show("Bu kitap zaten iade edilmiş.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
			}
			else
			{
				MessageBox.Show("Please select a book transaction to return.");
			}
		}
	}
}