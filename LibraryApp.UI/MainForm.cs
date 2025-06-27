using DevExpress.XtraEditors;
using LibraryApp.Business.Abstracts;
using LibraryApp.Entities.Dtos;
using LibraryApp.UI.Author;
using LibraryApp.UI.Books;
using LibraryApp.UI.Category;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp.UI
{
	public partial class MainForm : DevExpress.XtraEditors.XtraForm
	{
		private readonly IBookService _bookService;
		private readonly ICategoryService _categoryService;
		private readonly IAuthorService _authorService;
		public MainForm(IBookService bookService, ICategoryService category, IAuthorService authorService)
		{
			InitializeComponent();
			_bookService = bookService;
			_categoryService = category;
			_authorService = authorService;
			this.navigationPane1.SelectedPageChanged += navigationPane1_SelectedPageChanged;
			this.barManagerBooks.ItemClick += popupMenuBooks_ItemClick;
			this.barManagerBooks.ItemClick += popupMenuAuthors_ItemClick;
			this.barManagerBooks.ItemClick += popupMenuCategories_ItemClick;





		}


		private void LoadData()
		{
			if (navigationPane1.SelectedPage == nvpBooks)
			{
				if (gridControlBooks.DataSource == null)
					LoadBooks();
			}
			else if (navigationPane1.SelectedPage == nvpAuthors)
			{
				if (gridControlAuthors.DataSource == null)
					LoadAuthors();
			}
			else if (navigationPane1.SelectedPage == nvpCategories)
			{
				if (gridControlCategories.DataSource == null)
					LoadCategories();
			}
		}

		public void LoadBooks()
		{
			var books = _bookService.GetAllBooks();
			if (books != null && books.Count > 0)
			{
				gridControlBooks.DataSource = books;
			}
			else
			{
				MessageBox.Show("No books found.");
			}
		}
		private void btnAddBook_Click(object sender, EventArgs e)
		{
			AddBookForm addBookForm = new AddBookForm(_bookService, _categoryService, _authorService);
			addBookForm.Show();
		}
		private void btnDeleteBook_Click(object sender, EventArgs e)
		{

			if (gridView1.GetFocusedRow() is BookWithDetailsDto selectedBook)
			{
				_bookService.DeleteBook(selectedBook.Id);
				MessageBox.Show("Book deleted successfully.");
				LoadBooks();
			}
			else
			{
				MessageBox.Show("Please select a book to delete.");
			}
		}
		private void btnUpdateBook_Click(object sender, EventArgs e)
		{
			if (gridView1.GetFocusedRow() is BookWithDetailsDto selectedBook)
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

		private void gridControlBooks_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.F5)
			{
				LoadBooks();
			}
		}
		private void LoadAuthors()
		{
			var authors = _authorService.GetAllAuthors();

			if (authors != null && authors.Count > 0)
			{
				gridControlAuthors.DataSource = authors;

			}
			else
			{
				MessageBox.Show("No authors found.");
			}
		}
		private void btnUpdateAuthor_Click(object sender, EventArgs e)
		{

			if (gridView2.GetFocusedRow() is AuthorDto selectedAuthor)
			{
				int authorId = selectedAuthor.Id;
				AddAuthorForm addAuthorForm = new AddAuthorForm(_authorService, authorId);
				addAuthorForm.Show();
			}
			else
			{
				MessageBox.Show("Please select an author to update.");
			}
		}
		private void btnAddAuthor_Click(object sender, EventArgs e)
		{
			AddAuthorForm addAuthorForm = new AddAuthorForm(_authorService);
			addAuthorForm.Show();


		}

		private void btnDeleteAuthor_Click(object sender, EventArgs e)
		{
			if (gridView2.GetFocusedRow() is AuthorDto selectedAuthor)
			{
				try
				{
					_authorService.DeleteAuthor(selectedAuthor.Id);
					LoadAuthors();
					MessageBox.Show("Author deleted successfully.");
				}
				catch (Exception ex)
				{
					MessageBox.Show("Please delete the books that are related to this author first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			else
			{
				MessageBox.Show("Please select an author to delete.");
			}


		}
		private void gridControlAuthors_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.F5)
			{
				LoadAuthors();
			}

		}

		private void LoadCategories()
		{
			var categories = _categoryService.GetAllCategories();
			if (categories != null && categories.Count > 0)
			{
				gridControlCategories.DataSource = categories;
			}
			else
			{
				MessageBox.Show("No categories found.");
			}
		}

		private void gridControlCategories_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.F5)
			{
				LoadCategories();
			}
		}


		private void btnDeleteCategory_Click(object sender, EventArgs e)
		{
			if (gridView3.GetFocusedRow() is CategoryDto selectedCategory)
			{
				try
				{
					_categoryService.DeleteCategory(selectedCategory.Id);
					LoadCategories();
					MessageBox.Show("Category deleted successfully.");

				}
				catch (Exception ex)
				{
					MessageBox.Show("Please delete the books that are related to this category first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			else
			{
				MessageBox.Show("Please select a category to delete.");
			}
		}


		private void btnAddCategory_Click(object sender, EventArgs e)
		{

			AddCategoryForm addCategoryForm = new AddCategoryForm(_categoryService);
			addCategoryForm.Show();
		}


		private void btnUpdateCategory_Click(object sender, EventArgs e)
		{


			if (gridView3.GetFocusedRow() is CategoryDto selectedCategory)
			{
				int categoryId = selectedCategory.Id;
				AddCategoryForm addCategoryForm = new AddCategoryForm(_categoryService, categoryId);
				addCategoryForm.Show();
			}
			else
			{
				MessageBox.Show("Please select a category to update.");
			}
		}

		private void navigationPane1_SelectedPageChanged(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs e)
		{
			LoadData();
		}

		private void gridControlBooks_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				var hitInfo = gridView1.CalcHitInfo(e.Location);
				if (hitInfo.InRowCell)
				{
					gridView1.FocusedRowHandle = hitInfo.RowHandle;
					popupMenuBooks.ShowPopup(gridControlBooks.PointToScreen(e.Location));
				}

			}

		}
		private void popupMenuBooks_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (e.Item.Name == "btnPopUpUpdateBook")
			{
				if (gridView1.GetFocusedRow() is BookWithDetailsDto selectedBook)
				{
					int bookId = selectedBook.Id;
					AddBookForm addBookForm = new AddBookForm(_bookService, _categoryService, _authorService, bookId);
					addBookForm.Show();
				}
			}
			else if (e.Item.Name == "btnPopUpDeleteBook")
			{
				if (gridView1.GetFocusedRow() is BookWithDetailsDto selectedBook)
				{
					_bookService.DeleteBook(selectedBook.Id);
					MessageBox.Show("Book deleted successfully.");
					LoadBooks();
				}
			}
			else if (e.Item.Name == "btnPopUpAddBook")
			{
				AddBookForm addBookForm = new AddBookForm(_bookService, _categoryService, _authorService);
				addBookForm.Show();
			}
		}

		private void gridControlAuthors_MouseUp(object sender, MouseEventArgs e)
		{

			if (e.Button == MouseButtons.Right)
			{
				var hitInfo = gridView2.CalcHitInfo(e.Location);
				if (hitInfo.InRowCell)
				{
					gridView2.FocusedRowHandle = hitInfo.RowHandle;
					popupMenuAuthors.ShowPopup(gridControlAuthors.PointToScreen(e.Location));
				}
			}
		}
		private void popupMenuAuthors_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (e.Item.Name == "btnPopUpUpdateAuthor")
			{
				if (gridView2.GetFocusedRow() is AuthorDto selectedAuthor)
				{
					int authorId = selectedAuthor.Id;
					AddAuthorForm addAuthorForm = new AddAuthorForm(_authorService, authorId);
					addAuthorForm.Show();
				}
			}
			else if (e.Item.Name == "btnPopUpDeleteAuthor")
			{
				if (gridView2.GetFocusedRow() is AuthorDto selectedAuthor)
				{
					try
					{
						_authorService.DeleteAuthor(selectedAuthor.Id);
						LoadAuthors();
						MessageBox.Show("Author deleted successfully.");
					}
					catch (Exception ex)
					{
						MessageBox.Show("Please delete the books that are related to this author first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
				}
			}
			else if (e.Item.Name == "btnPopUpAddAuthor")
			{
				AddAuthorForm addAuthorForm = new AddAuthorForm(_authorService);
				addAuthorForm.Show();
			}
		}

		private void gridControlCategories_MouseUp(object sender, MouseEventArgs e)
		{

			if (e.Button == MouseButtons.Right)
			{
				var hitInfo = gridView3.CalcHitInfo(e.Location);
				if (hitInfo.InRowCell)
				{
					gridView3.FocusedRowHandle = hitInfo.RowHandle;
					popupMenuCategories.ShowPopup(gridControlCategories.PointToScreen(e.Location));
				}
			}
		}
		private void popupMenuCategories_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (e.Item.Name == "btnPopUpUpdateCategory")
			{
				if (gridView3.GetFocusedRow() is CategoryDto selectedCategory)
				{
					int categoryId = selectedCategory.Id;
					AddCategoryForm addCategoryForm = new AddCategoryForm(_categoryService, categoryId);
					addCategoryForm.Show();
				}
			}
			else if (e.Item.Name == "btnPopUpDeleteCategory")
			{
				if (gridView3.GetFocusedRow() is CategoryDto selectedCategory)
				{
					try
					{
						_categoryService.DeleteCategory(selectedCategory.Id);
						LoadCategories();
						MessageBox.Show("Category deleted successfully.");
					}
					catch (Exception ex)
					{
						MessageBox.Show("Please delete the books that are related to this category first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
				}
			}
			else if (e.Item.Name == "btnPopUpAddCategory")
			{
				AddCategoryForm addCategoryForm = new AddCategoryForm(_categoryService);
				addCategoryForm.Show();
			}
		}
	}
}
