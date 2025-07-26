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
		private readonly IBookStockService _bookStockService;
		private readonly int _bookTransactionId;

		public frmAddBookTransaction(IBookTransactionService bookTransactionService, IStudentService studentService,
	IBookService bookService, IBookStockService bookStockService, int bookTransactionId = 0)
		{
			InitializeComponent();
			_bookTransactionService = bookTransactionService;
			_studentService = studentService;
			_bookService = bookService;
			_bookTransactionId = bookTransactionId;
			_bookStockService = bookStockService;

			btnSaveBookOperation.Click += btnSaveBookOperation_Click;

			luStudentName.Properties.DataSource = _studentService.GetAllStudents();

			var books = _bookStockService.GetAllBookStocks().Where(bs => bs.IsAvailable == "Available").ToList();
			if (_bookTransactionId > 0)
			{
				var bookTransaction = _bookTransactionService.GetBookTransactionById(_bookTransactionId);
				if (bookTransaction != null)
				{
					if (!books.Any(bs => bs.Id == bookTransaction.BookStockId))
					{
						var currentBookStock = _bookStockService.GetAllBookStocks()
							.FirstOrDefault(bs => bs.Id == bookTransaction.BookStockId);
						if (currentBookStock != null)
							books.Add(currentBookStock);
					}
				}
			}
			luBookName.Properties.DataSource = books;
			luBookName.Properties.ValueMember = "Id";
			luBookName.Properties.DisplayMember = "BookName";

			if (_bookTransactionId > 0)
			{
				var bookTransaction = _bookTransactionService.GetBookTransactionById(_bookTransactionId);
				if (bookTransaction != null)
				{
					luStudentName.EditValue = bookTransaction.StudentId;
					luBookName.EditValue = bookTransaction.BookStockId;
					dateEditBorrowedTime.EditValue = bookTransaction.BorrowedDate;
					dateEditReturnedTime.EditValue = bookTransaction.ReturnDate;
					btnSaveBookOperation.Text = "Update Transaction";
				}
			}
		}

		private void btnSaveBookOperation_Click(object sender, EventArgs e)
		{
			if (dateEditBorrowedTime.EditValue == null)
			{
				MessageBox.Show("Choose Borrow time");
				return;
			}

			if (luBookName.EditValue == null)
			{
				MessageBox.Show("Please select a book.");
				return;
			}

			int selectedBookStockId = Convert.ToInt32(luBookName.EditValue);

			bool isChangingBook = true;
			if (_bookTransactionId > 0)
			{
				var existingTransfer = _bookTransactionService.GetBookTransactionById(_bookTransactionId);
				if (existingTransfer != null && existingTransfer.BookStockId == selectedBookStockId)
				{
					isChangingBook = false; 
				}
			}
			if (isChangingBook)
			{
				var availableBookStock = _bookStockService.GetAllBookStocks()
					.FirstOrDefault(bs => bs.Id == selectedBookStockId && bs.IsAvailable == "Available");

				if (availableBookStock == null)
				{
					MessageBox.Show("No available stock for the selected book.");
					return;
				}
			}

			var bookTransaction = new BookTransfer
			{
				Id = _bookTransactionId,
				StudentId = Convert.ToInt32(luStudentName.EditValue),
				BookStockId = selectedBookStockId,
				BorrowedDate = dateEditBorrowedTime.DateTime,
				ReturnedDate = (DateTime?)dateEditReturnedTime.EditValue
			};

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