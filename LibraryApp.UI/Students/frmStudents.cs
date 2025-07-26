using DevExpress.XtraEditors;
using LibraryApp.Business.Abstracts;
using LibraryApp.Business.Concretes;
using LibraryApp.Entities.Concretes;
using LibraryApp.Entities.Dtos;
using LibraryApp.UI.Category;
using LibraryApp.UI.Students;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp.UI.frmStudents
{
	public partial class frmStudents : DevExpress.XtraEditors.XtraForm
	{
		private readonly IStudentService _studentService;
		private readonly IBookTransactionService _bookTransactionService;
		public frmStudents(IStudentService studentService, IBookTransactionService bookTransactionService)
		{
			InitializeComponent();
			_studentService = studentService;
			_bookTransactionService = bookTransactionService;
			gridViewStudents.MouseUp += gridViewStıdents_MouseUp;
			btnAddStudent.ItemClick += btnAddStudent_ItemClick;
			btnUpdateStudent.ItemClick += btnUpdateStudent_ItemClick;
			btnDeleteStudent.ItemClick += btnDeleteStudent_ItemClick;
			btnRefresh.ItemClick += btnRefreshData_ItemClick;
			gridControlStudents.KeyDown += frmStudents_KeyDown;
			btnGetStudentHasBooks.ItemClick += btnStudentHasBooks_ItemClick;


			LoadStudents();

		}
		private void LoadStudents()
		{
			var students = _studentService.GetAllStudents();
			gridControlStudents.DataSource = students;
			gridViewStudents.BestFitColumns();
		}
		private void OpenUpdateOrAddStudentsForm()
		{
			if (gridViewStudents.GetFocusedRow() is StudentWithDetailsDto selectedStudent)
			{
				int studentId = selectedStudent.Id;
				frmAddStudent addStudentForm = new frmAddStudent(_studentService, studentId);
				addStudentForm.ShowDialog();
			}
			else
			{
				XtraMessageBox.Show("Lütfen güncellemek istediğiniz öğrenciyi seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		private void gridViewStıdents_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
				var hitInfo = view.CalcHitInfo(e.Location);
				if (hitInfo.InRow || hitInfo.InRowCell)
				{
					view.FocusedRowHandle = hitInfo.RowHandle;
				}
				popupMenuStudents.ShowPopup(Control.MousePosition);
			}
		}
		private void btnAddStudent_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			var frm = new frmAddStudent(_studentService);
			if (frm.ShowDialog() == DialogResult.OK)
			{
				LoadStudents();
			}
		}
		private void btnUpdateStudent_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			OpenUpdateOrAddStudentsForm();
		}


		private void btnDeleteStudent_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			var selectedRow = gridViewStudents.GetFocusedRow();
			if (selectedRow != null)
			{
				var student = (StudentWithDetailsDto)selectedRow;
				if (XtraMessageBox.Show($"'{student.Name}' kategorisini silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					_studentService.DeleteStudent(student.Id);
					LoadStudents();
				}
			}
			else
			{
				XtraMessageBox.Show("Lütfen silmek istediğiniz kategoriyi seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		private void btnRefreshData_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			LoadStudents();
		}
		private void gridControlStudents_DoubleClick(object sender, EventArgs e)
		{
			OpenUpdateOrAddStudentsForm();
		}

		private void frmStudents_KeyDown(object sender, KeyEventArgs e)
		{

			if (e.KeyCode == Keys.F5)
			{
				LoadStudents();
				MessageBox.Show("Students refreshed successfully.");

			}

		}
		private void btnStudentHasBooks_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			try
			{
				if (gridViewStudents.GetFocusedRow() is StudentWithDetailsDto selectedStudent)
				{
					int studentId = selectedStudent.Id;
					var studentHasBooks = _bookTransactionService.StudentHasBooks(studentId);
					if (studentHasBooks != null && studentHasBooks.Count != 0)
					{
						frmStudentHasBooks studentHasBooksForm = new frmStudentHasBooks(_bookTransactionService, studentId);
						studentHasBooksForm.ShowDialog();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}