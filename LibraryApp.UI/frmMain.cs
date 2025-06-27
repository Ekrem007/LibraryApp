using DevExpress.XtraEditors;
using LibraryApp.Business.Abstracts;
using LibraryApp.Entities.Concretes;
using LibraryApp.UI.frmAuthor;
using LibraryApp.UI.frmBookTransaction;
using LibraryApp.UI.frmStudents;
using LibraryApp.UI.Statistics;
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
	public partial class frmMain : DevExpress.XtraEditors.XtraForm
	{
		private readonly IBookService _bookService;
		private readonly ICategoryService _categoryService;
		private readonly IAuthorService _authorService;
		private readonly IStudentService _studentService;
		private readonly IBookTransactionService _bookTransactionService;
		public frmMain(IBookService bookService, ICategoryService categoryService, IAuthorService authorService,
			IStudentService studentService, IBookTransactionService bookTransactionService)
		{
			InitializeComponent();
			_categoryService = categoryService;
			_authorService = authorService;
			_bookService = bookService;
			_studentService = studentService;
			_bookTransactionService = bookTransactionService;
		}
		private void ShowMdiChild<T>(Func<T> formFactory) where T : Form
		{
			foreach (var form in this.MdiChildren)
			{
				if (form is T)
				{
					form.Activate();
					return;
				}
			}
			var childForm = formFactory();
			childForm.MdiParent = this;
			childForm.Show();
		}

		private void navBarItemBooks_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
		{
			ShowMdiChild(() => new frmBooks(_bookService, _categoryService, _authorService, _bookTransactionService, _studentService));
		}

		private void navBarItemCategory_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
		{
			ShowMdiChild(() => new frmCategories(_categoryService));
		}

		private void navBarItemAuthors_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
		{
			ShowMdiChild(() => new frmAuthors(_authorService));
		}

		private void navBarItemStudents_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
		{
			ShowMdiChild(() => new UI.frmStudents.frmStudents(_studentService, _bookTransactionService));

		}
		private void navBarItemBookTransactions_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
		{
			ShowMdiChild(() => new frmBookTransactions(_bookTransactionService, _studentService, _bookService));
		}

		private void navBarItemStatistics_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
		{
			ShowMdiChild(() => new frmStatistics(_bookTransactionService));
		}
	}
}