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

namespace LibraryApp.UI.BookStocks
{
	public partial class frmAddBookStock : DevExpress.XtraEditors.XtraForm
	{
		private readonly IBookService _bookService;
		private readonly IBookStockService _bookStockService;
		public frmAddBookStock(IBookService bookService, IBookStockService bookStockService)
		{
			InitializeComponent();
			_bookService = bookService;
			_bookStockService = bookStockService;
			LoadBooks();
			btnSave.Click += btnAddBookStock_Click;



		}
		private void LoadBooks()
		{
			try
			{
				var books = _bookService.GetAllBooks();
				luBookName.Properties.DataSource = books;
				luBookName.Properties.DisplayMember = "BookName";
				luBookName.Properties.ValueMember = "Id";
			}
			catch (Exception ex)
			{
				XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void btnAddBookStock_Click(object sender, EventArgs e)
		{
			try
			{
				int stock = Convert.ToInt32(txtStock.Text);
				if (stock <= 0)
				{
					XtraMessageBox.Show("Stock must be bigger than zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				var bookStock = new BookStock
				{
					BookId = Convert.ToInt32(luBookName.EditValue),
				};
				_bookStockService.AddBookStock(bookStock, stock);
				XtraMessageBox.Show("Book stock added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			}
			catch (Exception ex)
			{
				XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}