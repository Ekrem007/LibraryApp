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

namespace LibraryApp.UI.Books
{
	public partial class AddBookForm : DevExpress.XtraEditors.XtraForm
	{
		private readonly IBookService _bookService;
		private readonly int _bookId;
		private readonly ICategoryService _categoryService;
		private readonly IAuthorService _authorService;

		public AddBookForm(IBookService bookService, ICategoryService categoryService, IAuthorService authorService, int bookId = 0)
		{
			InitializeComponent();
			_bookService = bookService;
			_categoryService = categoryService;
			_authorService = authorService;
			_bookId = bookId;

			luCategoryName.Properties.DataSource = _categoryService.GetAllCategories();
			luAuthorName.Properties.DataSource = _authorService.GetAllAuthors();

			if (_bookId > 0)
			{
				var book = _bookService.GetBookById(_bookId);
				if (book != null)
				{
					txtBookName.Text = book.BookName;
					luAuthorName.EditValue = book.AuthorId;
					luCategoryName.EditValue = book.CategoryId;
					btnSave.Text = "Update Book";
				}
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			var book = new Book
			{
				Id = _bookId,
				BookName = txtBookName.Text,
				AuthorId = Convert.ToInt32(luAuthorName.EditValue),
				CategoryId = Convert.ToInt32(luCategoryName.EditValue)
			};

			try
			{
				if (_bookId > 0)
				{
					_bookService.UpdateBook(book);
					MessageBox.Show("Book updated successfully.");
				}
				else
				{
					_bookService.AddBook(book);
					MessageBox.Show("Book added successfully.");
				}
				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
