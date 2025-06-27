using LibraryApp.Entities.Concretes;
using LibraryApp.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Business.Abstracts
{
	public interface IStudentService
	{
		void AddStudent(Student student);
		void UpdateStudent(Student student);
		void DeleteStudent(int studentId);
		List<StudentWithDetailsDto> GetAllStudents();
		Student GetbyStudentId(int studentId);
		BookTransfer GetStudentsLastBorrowedBook(int studentId);


	}
}
