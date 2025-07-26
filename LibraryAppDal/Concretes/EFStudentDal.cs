using LibraryApp.Entities.Concretes;
using LibraryApp.Entities.Dtos;
using LibraryAppDal.Abstracts;
using LibraryAppDal.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAppDal.Concretes
{
	public class EFStudentDal : IStudentDal
	{
		private readonly LibraryAppDbContext _context;
		public EFStudentDal(LibraryAppDbContext context)
		{
			_context = context;
		}
		public void AddStudent(Student student)
		{
			_context.Students.Add(student);
			_context.SaveChanges();
		}

		public void DeleteStudent(int studentId)
		{
			var student = _context.Students.Find(studentId);
			_context.Students.Remove(student);
			_context.SaveChanges();
		}


		public Student GetbyStudentId(int studentId)
		{
			return _context.Students.Find(studentId);
		}

		public void UpdateStudent(Student student)
		{
			var existingStudent = _context.Students.Find(student.Id);
			existingStudent.Name = student.Name;
			existingStudent.PhoneNumber = student.PhoneNumber;
			existingStudent.StudentNumber = student.StudentNumber;
			_context.SaveChanges();

		}
		public BookTransfer GetStudentsLastBorrowedBook(int StudentId)
		{
			return _context.BookTransfer.Where(bt => bt.StudentId == StudentId).LastOrDefault();
		}

		public bool IsStudentNameUnique(string studentName, int id)
		{
			return !_context.Students.Any(s => s.Name == studentName && s.Id != id);
		}

		public bool IsStudentNumberUnique(string studentNumber, int id)
		{
			return !_context.Students.Any(s => s.StudentNumber == studentNumber && s.Id != id);
		}

		public List<StudentWithDetailsDto> GetAllStudents()
		{
			return _context.Students
				.Select(s => new StudentWithDetailsDto
				{
					Id = s.Id,
					Name = s.Name,
					StudentNumber = s.StudentNumber,
					PhoneNumber = s.PhoneNumber,
					TotalBorrowedBookCount = _context.BookTransfer.Count(bt => bt.StudentId == s.Id),
					LastBorrowedBookName = _context.BookTransfer
						.Where(bt => bt.StudentId == s.Id)
						.OrderByDescending(bt => bt.BorrowedDate)
						.Select(bt => bt.BookStock.Book.BookName)
						.FirstOrDefault(),
					AverageReadingDays = _context.BookTransfer
						.Where(bt => bt.StudentId == s.Id)
						.Average(bt => EF.Functions.DateDiffDay(bt.BorrowedDate, bt.ReturnedDate)),
					FavoriteCategory = _context.BookTransfer
						.Where(bt => bt.StudentId == s.Id)
						.GroupBy(bt => bt.BookStock.Book.Category.CategoryName)
						.OrderByDescending(g => g.Count())
						.Select(g => g.Key)
						.FirstOrDefault()
				}).ToList();


		}
	}
}
