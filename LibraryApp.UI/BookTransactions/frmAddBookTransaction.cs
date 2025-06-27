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

namespace LibraryApp.UI.BookTransactions
{
	public partial class frmAddBookTransaction : DevExpress.XtraEditors.XtraForm
	{
		private readonly IBookTransactionService _bookTransactionService;
		private readonly IStudentService _studentService;
		private readonly IBookService _bookService;
		private readonly int _bookTransactionId;
		public frmAddBookTransaction(IBookTransactionService bookTransactionService, IStudentService studentService,
			IBookService bookService, int bookTransactionId = 0)
		{
			InitializeComponent();
			_bookTransactionService = bookTransactionService;
			_studentService = studentService;
			_bookService = bookService;
			_bookTransactionId = bookTransactionId;

			btnSaveBookOperation.Click += btnSaveBookOperation_Click;

			luStudentName.Properties.DataSource = _studentService.GetAllStudents();
			luBookName.Properties.DataSource = _bookService.GetAllBooks();

			if (_bookTransactionId > 0)
			{
				var bookTransaction = _bookTransactionService.GetBookTransactionById(_bookTransactionId);
				if (bookTransaction != null)
				{
					luStudentName.EditValue = bookTransaction.StudentId;
					luBookName.EditValue = bookTransaction.BookId;
					dateEditBorrowedTime.EditValue = bookTransaction.BorrowedDate;
					if (bookTransaction.ReturnDate.HasValue)
					{
						dateEditReturnedTime.EditValue = bookTransaction.ReturnDate.Value;
					}
					else
					{
						dateEditReturnedTime.EditValue = null;
					}
					btnSaveBookOperation.Text = "Update Transaction";
				}
			}
		}
		private void btnSaveBookOperation_Click(object sender, EventArgs e)
		{
			var bookTransaction = new BookTransfer
			{
				Id = _bookTransactionId,
				StudentId = Convert.ToInt32(luStudentName.EditValue),
				BookId = Convert.ToInt32(luBookName.EditValue),
				BorrowedDate = dateEditBorrowedTime.DateTime,
				ReturnedDate = (DateTime?)dateEditReturnedTime.EditValue


			};
			if (dateEditBorrowedTime.EditValue == null)
			{
				MessageBox.Show("Choose Borrow time");
				return;
			}
			try
			{
				if (_bookTransactionId > 0)
				{
					_bookTransactionService.UpdateBookTransactions(bookTransaction);
					MessageBox.Show("Book transaction updated successfully.");
				}
				else
				{
					_bookTransactionService.AddBookTransaction(bookTransaction);
					MessageBox.Show("Book transaction added successfully.");
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