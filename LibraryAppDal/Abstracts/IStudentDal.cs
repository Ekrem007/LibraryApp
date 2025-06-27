using LibraryApp.Entities.Concretes;
using LibraryApp.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAppDal.Abstracts
{
	public interface IStudentDal
	{
		void AddStudent(Student student);
		void UpdateStudent(Student student);
		void DeleteStudent(int studentId);
		List<StudentWithDetailsDto> GetAllStudents();
		Student GetbyStudentId(int studentId);
		BookTransfer GetStudentsLastBorrowedBook(int StudentId);
		bool IsStudentNameUnique(string studentName, int id);
		bool IsStudentNumberUnique(string studentNumber, int id);



	}
}
