using LibraryApp.Entities.Concretes;
using LibraryApp.Entities.Dtos;
using LibraryAppDal.Abstracts;
using LibraryAppDal.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAppDal.Concretes
{
	public class EFBookTransactionDal : IBookTransactionDal
	{
		private readonly LibraryAppDbContext _context;
		public EFBookTransactionDal(LibraryAppDbContext context)
		{
			_context = context;
		}
		public void AddBookTransaction(BookTransfer bookTransfer)
		{
			_context.BookTransfer.Add(bookTransfer);
			_context.SaveChanges();
		}



		public void DeleteBookTransaction(int bookTransactionId)
		{

			var bookTransfer = _context.BookTransfer.Find(bookTransactionId);
			_context.BookTransfer.Remove(bookTransfer);
			_context.SaveChanges();


		}

		public List<BookTransactionsWithDetailsDto> GetAllBookTransactions()
		{
			return _context.BookTransfer
				.Include(bt => bt.Book)
				.Include(bt => bt.Student)
				.Select(bt => new BookTransactionsWithDetailsDto
				{
					Id = bt.Id,
					BookName = bt.Book.BookName,
					BookId = bt.BookId,
					StudentId = bt.StudentId,
					StudentName = bt.Student.Name,
					BorrowedDate = bt.BorrowedDate,
					ReturnDate = bt.ReturnedDate
				}).ToList();
		}

		public List<BookTransactionsWithDetailsDto> GetBooksTransactionsByBookId(int bookId)
		{
			return _context.BookTransfer
				.Include(bt => bt.Book)
				.Include(bt => bt.Student)
				.Where(bt => bt.BookId == bookId)
				.Select(bt => new BookTransactionsWithDetailsDto
				{
					Id = bt.Id,
					BookName = bt.Book.BookName,
					StudentName = bt.Student.Name,
					BorrowedDate = bt.BorrowedDate,
					ReturnDate = bt.ReturnedDate
				}).ToList();
		}

		public List<BookTransactionsWithDetailsDto> GetBooksTransactionsByStudentId(int studentId)
		{

			return _context.BookTransfer
				.Include(bt => bt.Book)
				.Include(bt => bt.Student)
				.Where(bt => bt.StudentId == studentId)
				.Select(bt => new BookTransactionsWithDetailsDto
				{
					Id = bt.Id,
					BookName = bt.Book.BookName,
					StudentName = bt.Student.Name,
					BorrowedDate = bt.BorrowedDate,
					ReturnDate = bt.ReturnedDate
				}).ToList();
		}

		public BookTransactionsWithDetailsDto GetBookTransactionById(int bookTransactionId)
		{

			var result = _context.BookTransfer
				.Include(bt => bt.Book)
				.Include(bt => bt.Student)
				.Where(bt => bt.Id == bookTransactionId)
				.Select(bt => new BookTransactionsWithDetailsDto
				{
					Id = bt.Id,
					BookName = bt.Book.BookName,
					StudentName = bt.Student.Name,
					BookId = bt.BookId,
					StudentId = bt.StudentId,
					BorrowedDate = bt.BorrowedDate,
					ReturnDate = bt.ReturnedDate
				}).SingleOrDefault();
			return result;

		}


		public bool IsBookAvailable(int bookId)
		{
			return !_context.BookTransfer.Any(bt => bt.BookId == bookId && bt.ReturnedDate == null);
		}

		public void ReturnBook(int bookId)
		{
			var bookTransfer = _context.BookTransfer
				.SingleOrDefault(bt => bt.BookId == bookId && bt.ReturnedDate == null);
			if (bookTransfer != null)
			{
				bookTransfer.ReturnedDate = DateTime.Now;
				_context.SaveChanges();
			}

		}

		public List<StudentHasBooks> StudentsHasBooks(int studentId)
		{
			return _context.BookTransfer
			.Include(bt => bt.Student)
			.Include(bt => bt.Book)
			.Where(bt => bt.StudentId == studentId && bt.ReturnedDate == null)
			.Select(bt => new StudentHasBooks
			{
				StudentName = bt.Student.Name,
				BookName = bt.Book.BookName,
				BorrowDate = bt.BorrowedDate
			}).ToList();
		}
		public StatisticsDto GetStatistics()
		{
			var mostPopularBookName = _context.BookTransfer
				.GroupBy(bt => new { bt.BookId, bt.Book.BookName })
				.OrderByDescending(g => g.Count())
				.Select(g => g.Key.BookName)
				.AsNoTracking()
				.FirstOrDefault();

			var mostPopularAuthorName = _context.BookTransfer
				.GroupBy(bt => new { bt.Book.AuthorId, bt.Book.Author.Name })
				.OrderByDescending(g => g.Count())
				.Select(g => g.Key.Name)
				.AsNoTracking()
				.FirstOrDefault();


			var mostPopularCategoryName = _context.BookTransfer
				.GroupBy(bt => new { bt.Book.CategoryId, bt.Book.Category.CategoryName })
				.OrderByDescending(g => g.Count())
				.Select(g => g.Key.CategoryName)
				.AsNoTracking()
				.FirstOrDefault();

			var counts = _context.Books
				.GroupBy(x => 0)
				.Select(g => new
			{
				TotalBooks = _context.Books.Count(),
				TotalAuthors = _context.Authors.Count(),
				TotalCategories = _context.Categories.Count(),
				TotalStudents = _context.Students.Count(),
				TotalBorrowedBooks = _context.BookTransfer.Count(bt => bt.BorrowedDate != null),
				TotalReturnedBooks = _context.BookTransfer.Count(bt => bt.ReturnedDate != null)
			})
				.AsNoTracking()
				.FirstOrDefault();

			return new StatisticsDto
			{
				MostPopularBook = mostPopularBookName,
				MostPopularAuthor = mostPopularAuthorName,
				MostPopularCategory = mostPopularCategoryName,
				TotalBooks = counts?.TotalBooks ?? 0,
				TotalAuthors = counts?.TotalAuthors ?? 0,
				TotalCategories = counts?.TotalCategories ?? 0,
				TotalStudents = counts?.TotalStudents ?? 0,
				TotalBorrowedBooks = counts?.TotalBorrowedBooks ?? 0,
				TotalReturnedBooks = counts?.TotalReturnedBooks ?? 0
			};
		}

	public void UpdateBookTransactions(BookTransfer bookTransfer)
		{

			var existingTransaction = _context.BookTransfer.Find(bookTransfer.Id);
			if (existingTransaction != null)
			{
				existingTransaction.BookId = bookTransfer.BookId;
				existingTransaction.StudentId = bookTransfer.StudentId;
				existingTransaction.BorrowedDate = bookTransfer.BorrowedDate;
				existingTransaction.ReturnedDate = bookTransfer.ReturnedDate;
				_context.SaveChanges();
			}

		}
	}
}
