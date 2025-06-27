using LibraryApp.Business.Abstracts;
using LibraryApp.Entities.Concretes;
using LibraryApp.Entities.Dtos;
using LibraryAppDal.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Business.Concretes
{
	public class StudentService : IStudentService
	{
		private readonly IStudentDal _studentDal;
		public StudentService(IStudentDal studentDal)
		{
			_studentDal = studentDal;
		}
		public void AddStudent(Student student)
		{
			if (string.IsNullOrEmpty(student.Name))
			{
				throw new ArgumentException("Student name cannot be empty.");
			}
			if (!_studentDal.IsStudentNameUnique(student.Name, student.Id))
			{
				throw new Exception("Student name must be unique.");
			}
			if (!_studentDal.IsStudentNumberUnique(student.StudentNumber, student.Id))
			{
				throw new Exception("Student number must be unique.");
			}
			_studentDal.AddStudent(student);

		}

		public void DeleteStudent(int studentId)
		{

			_studentDal.DeleteStudent(studentId);
		}

		public List<StudentWithDetailsDto> GetAllStudents()
		{
			return _studentDal.GetAllStudents();
		}

		public Student GetbyStudentId(int studentId)
		{
			return _studentDal.GetbyStudentId(studentId);
		}

		public void UpdateStudent(Student student)
		{

			if (string.IsNullOrEmpty(student.Name))
			{
				throw new ArgumentException("Student name cannot be empty.");
			}
			if (!_studentDal.IsStudentNameUnique(student.Name, student.Id))
			{
				throw new Exception("Student name must be unique.");
			}
			if (!_studentDal.IsStudentNumberUnique(student.StudentNumber, student.Id))
			{
				throw new Exception("Student number must be unique.");
			}
			_studentDal.UpdateStudent(student);
		}
		public BookTransfer GetStudentsLastBorrowedBook(int studentId)
		{
			return _studentDal.GetStudentsLastBorrowedBook(studentId);
		}

		
	}
}
