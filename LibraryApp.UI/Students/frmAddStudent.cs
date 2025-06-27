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

namespace LibraryApp.UI.Students
{
	public partial class frmAddStudent : DevExpress.XtraEditors.XtraForm
	{
		private readonly IStudentService _studentService;
		private readonly int _studentId;
		public frmAddStudent(IStudentService studentService, int studentId = 0)
		{
			InitializeComponent();
			_studentService = studentService;
			_studentId = studentId;

			if (_studentId > 0)
			{
				var student = _studentService.GetbyStudentId(_studentId);
				if (student != null)
				{
					txtStudentName.Text = student.Name;
					txtPhoneNumber.Text = student.PhoneNumber;
					txtStudentNumber.Text = student.StudentNumber;
					btnSaveStudent.Text = "Update Student";
				}
			}
			else
			{
				btnSaveStudent.Text = "Add Student";
			}

		}

		private void btnSaveStudent_Click(object sender, EventArgs e)
		{
			var student = new Student
			{
				Id = _studentId,
				Name = txtStudentName.Text,
				PhoneNumber = txtPhoneNumber.Text,
				StudentNumber = txtStudentNumber.Text
			};
			try
			{
				if (_studentId > 0)
				{
					_studentService.UpdateStudent(student);
					MessageBox.Show("Student updated successfully.");
				}
				else
				{
					_studentService.AddStudent(student);
					MessageBox.Show("Student added successfully.");
				}
				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An error occurred: {ex.Message}");
			}
		}

	}
}