using DevExpress.XtraEditors;
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

namespace LibraryApp.UI.Students
{
	public partial class frmStudentHasBooks : DevExpress.XtraEditors.XtraForm
	{
		private readonly IBookTransactionService _bookTransactionService;
		private readonly int _studentId;
		public frmStudentHasBooks(IBookTransactionService bookTransactionService, int studentId)
		{
			InitializeComponent();
			_bookTransactionService = bookTransactionService;
			_studentId = studentId;
			LoadStudentsHasBooks(_studentId);
		}
		private void LoadStudentsHasBooks(int _studentId)
		{

			var studentHasBooks = _bookTransactionService.StudentHasBooks(_studentId);

				gridControlStudentsHasBooks.DataSource = studentHasBooks;
				gridViewStudentsHasBooks.BestFitColumns();
			
		}

	}
}