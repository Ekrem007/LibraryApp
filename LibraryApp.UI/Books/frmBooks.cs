using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using LibraryApp.Business.Abstracts;
using LibraryApp.Business.Concretes;
using LibraryApp.Entities.Dtos;
using LibraryApp.UI.Books;
using LibraryApp.UI.BookTransactions;
using System;
using System.Windows.Forms;

namespace LibraryApp.UI
{
	public partial class frmBooks : DevExpress.XtraEditors.XtraForm
	{
		private readonly IBookService _bookService;
		private readonly ICategoryService _categoryService;
		private readonly IAuthorService _authorService;
		private readonly IBookTransactionService _bookTransactionService;
		private readonly IStudentService _studentService;
		private readonly IBookStockService _bookStockService;
		public frmBooks(IBookService bookService, ICategoryService categoryService, IAuthorService authorService,
			IBookTransactionService bookTransactionService,IStudentService studentService, IBookStockService bookStockService)
		{
			InitializeComponent();
			_bookService = bookService;
			_categoryService = categoryService;
			_authorService = authorService;
			_studentService = studentService;
			_bookTransactionService = bookTransactionService;
			_bookStockService = bookStockService;
			LoadBooks();
			gridViewBooks.MouseUp += gridView1_MouseUp;
			btnUpdateBook.ItemClick += btnUpdateBook_ItemClick;
			btnDeleteBook.ItemClick += btnDeleteBook_ItemClick;
			btnRefreshData.ItemClick += btnRefreshData_ItemClick;
			btnAdBook.ItemClick += btnAddBook_ItemClick;
			gridControlBooks.MouseUp += gridControlBooks_MouseUp;
			btnGiveBookToStudent.ItemClick += btnGiveBookToStudent_ItemClick;
			gridViewBooks.CellValueChanging += gridViewBooks_CellValueChanging;

		}

		private void LoadBooks()
		{
			var books = _bookService.GetAllBooks();
			gridControlBooks.DataSource = books;
			gridViewBooks.BestFitColumns();
		}
		private void OpenUpdateOrAddBookForm()
		{
			if (gridViewBooks.GetFocusedRow() is BookWithDetailsDto selectedBook)
			{
				int bookId = selectedBook.Id;
				AddBookForm addBookForm = new AddBookForm(_bookService, _categoryService, _authorService, bookId);
				addBookForm.Show();
			}
			else
			{
				MessageBox.Show("Please select a book to update.");
			}
		}
		private void gridView1_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
				var hitInfo = view.CalcHitInfo(e.Location);
				if (hitInfo.InRow || hitInfo.InRowCell)
				{
					view.FocusedRowHandle = hitInfo.RowHandle;
					popupMenuBooks.ShowPopup(Control.MousePosition);
				}
			}
		}
		private void gridControlBooks_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				popupMenuBooks.ShowPopup(Control.MousePosition);
			}
		}

		private void btnAddBook_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			AddBookForm addBookForm = new AddBookForm(_bookService, _categoryService, _authorService);
			addBookForm.ShowDialog();
			LoadBooks();
		}
		private void btnDeleteBook_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			var selectedRow = gridViewBooks.GetFocusedRow() as BookWithDetailsDto;
			if (selectedRow != null)
			{
				var result = XtraMessageBox.Show("Are you sure you want to delete this book?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.Yes)
				{
					_bookService.DeleteBook(selectedRow.Id);
					LoadBooks();
				}
			}
			else
			{
				XtraMessageBox.Show("Please select a book to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		private void btnRefreshData_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			LoadBooks();
			MessageBox.Show("Books refreshed successfully.");
		}

		private void gridControlBooks_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.F5)
			{
				LoadBooks();
				MessageBox.Show("Books refreshed successfully.");
			}

		}

		private void gridControlBooks_DoubleClick(object sender, System.EventArgs e)
		{
			OpenUpdateOrAddBookForm();
		}
		private void btnUpdateBook_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			OpenUpdateOrAddBookForm();
		}
		private void btnGiveBookToStudent_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frmAddBookTransaction addBookTransactionForm = new frmAddBookTransaction(_bookTransactionService, _studentService, _bookService,_bookStockService);
			addBookTransactionForm.Show();
		}
		private void ChangeBookStatus(int bookId)
		{
			var book = _bookService.GetBookById(bookId);
			if (book != null)
			{
				_bookService.ChangeBookStatus(bookId);
				LoadBooks();
				MessageBox.Show($"Book status changed successfully.");
			}
			else
			{
				MessageBox.Show("Book not found.");
			}


		}
		private void gridViewBooks_CellValueChanging(object sender, CellValueChangedEventArgs e)
		{
			if (e.Column.FieldName == "IsPassive")
			{
				int bookId = Convert.ToInt32(gridViewBooks.GetRowCellValue(e.RowHandle, "Id"));
				ChangeBookStatus(bookId); 
			}
		}

	}
}