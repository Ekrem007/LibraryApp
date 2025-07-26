using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using LibraryApp.Business.Abstracts;
using LibraryApp.Business.Concretes;
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
	public partial class frmGiveBookToStudent : DevExpress.XtraEditors.XtraForm
	{
		private string Barcode { get; set; }
		private string _bookName { get; set; }
		private readonly IBookTransactionService _bookTransactionService;
		private readonly IStudentService _studentService;
		private readonly IBookService _bookService;
		private readonly IBookStockService _bookStockService;
		private int _bookStockId;

		public frmGiveBookToStudent(IBookTransactionService bookTransactionService, IStudentService studentService, IBookService bookService,
			IBookStockService bookStockService, int bookStockId)
		{
			InitializeComponent();
			_bookTransactionService = bookTransactionService;
			_studentService = studentService;
			_bookService = bookService;
			_bookStockId = bookStockId;
			_bookStockService = bookStockService;
			txtBarcode.Text = Barcode;
			txtBookName.Text = _bookName;
			btnSave.Click += btnGiveBookToStudent_Click;
			luStudentName.Properties.DataSource = _studentService.GetAllStudents();

			var bookStock = _bookStockService.GetAllBookStocks().FirstOrDefault(bs => bs.Id == _bookStockId);
			txtBarcode.Text = bookStock.Barcode.ToString();
			txtBookName.Text = bookStock.BookName;




		}
		public void btnGiveBookToStudent_Click(object sender, EventArgs e)
		{
			if (luStudentName.EditValue == null)
			{
				XtraMessageBox.Show("Lütfen bir öğrenci seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			try
			{
				var bookTransfer = new BookTransfer
				{
					BookStockId = _bookStockId,
					StudentId = Convert.ToInt32(luStudentName.EditValue),
					BorrowedDate = dateEditBorrowedTime.DateTime,
					ReturnedDate = (DateTime?)dateEditReturnedTime.EditValue

				};

				_bookTransactionService.AddBookTransaction(bookTransfer);


				XtraMessageBox.Show("Kitap başarıyla öğrenciye verildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			}
			catch (Exception ex)
			{
				XtraMessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}