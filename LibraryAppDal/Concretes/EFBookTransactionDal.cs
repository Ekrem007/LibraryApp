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
			var bookStock = _context.BookStocks.FirstOrDefault(bs => bs.Id == bookTransfer.BookStockId);
			if (bookStock != null)
			{
				if (bookTransfer.ReturnedDate == null)
					bookStock.IsAvailable = "Not Available";
				else
					bookStock.IsAvailable = "Available";
			}
			_context.SaveChanges();
		}



		public void DeleteBookTransaction(int bookTransactionId)
		{
			var bookTransfer = _context.BookTransfer.Find(bookTransactionId);
			if (bookTransfer != null)
			{
				int bookStockId = bookTransfer.BookStockId;

				_context.BookTransfer.Remove(bookTransfer);
				_context.SaveChanges();

				bool hasActiveTransfer = _context.BookTransfer.Any(bt =>
					bt.BookStockId == bookStockId &&
					bt.ReturnedDate == null);

				var bookStock = _context.BookStocks.FirstOrDefault(bs => bs.Id == bookStockId);
				if (bookStock != null && !hasActiveTransfer)
				{
					bookStock.IsAvailable = "Available";
					_context.SaveChanges();
				}
			}
		}

		public List<BookTransactionsWithDetailsDto> GetAllBookTransactions()
		{
			return _context.BookTransfer
				.Include(bt => bt.Student)
				.Include(bt => bt.BookStock)
					.ThenInclude(bs => bs.Book)
				.Select(bt => new BookTransactionsWithDetailsDto
				{
					Id = bt.Id,
					BookStockId = bt.BookStockId,
					BookId = bt.BookStock.BookId,
					StudentName = bt.Student.Name,
					BookName = bt.BookStock.Book.BookName,
					BorrowedDate = bt.BorrowedDate,
					ReturnDate = bt.ReturnedDate,
					Barcode = bt.BookStock.Barcode,
					AuthorName = bt.BookStock.Book.Author.Name,
				})
				.ToList();
		}

		public BookStock GetBookStockById(int bookStockId)
		{

			return _context.BookStocks.Include(bs => bs.Book).SingleOrDefault(bs => bs.Id == bookStockId);
		}

		public List<BookTransactionsWithDetailsDto> GetBooksTransactionsByBookId(int bookId)
		{
			throw new NotImplementedException();
		}

		public List<BookTransactionsWithDetailsDto> GetBooksTransactionsByStudentId(int studentId)
		{
			return _context.BookTransfer
				.Include(bt => bt.Student)
				.Include(bt => bt.BookStock)
					.ThenInclude(bs => bs.Book)
				.Where(bt => bt.StudentId == studentId)
				.Select(bt => new BookTransactionsWithDetailsDto
				{
					Id = bt.Id,
					BookStockId = bt.BookStockId,
					Barcode = bt.BookStock.Barcode,
					BookId = bt.BookStock.BookId,
					StudentName = bt.Student.Name,
					BookName = bt.BookStock.Book.BookName,
					BorrowedDate = bt.BorrowedDate,
					ReturnDate = bt.ReturnedDate

				}).ToList();
		}

		public BookTransactionsWithDetailsDto GetBookTransactionById(int bookTransactionId)
		{
			return _context.BookTransfer
				.Include(bt => bt.Student)
				.Include(bt => bt.BookStock)
				.ThenInclude(bs => bs.Book)
				.Where(bt => bt.Id == bookTransactionId)
				.Select(bt => new BookTransactionsWithDetailsDto
				{
					Id = bt.Id,
					StudentId = bt.StudentId,
					BookStockId = bt.BookStockId,
					BookName = bt.BookStock.Book.BookName,
					StudentName = bt.Student.Name,
					BorrowedDate = bt.BorrowedDate,
					ReturnDate = bt.ReturnedDate,
					IsPassive = bt.BookStock.Book.IsPassive

				})
				.SingleOrDefault();
		}

		public bool IsBookAvailable(int bookStockId)
		{
			return !_context.BookTransfer.Any(bt => bt.BookStockId == bookStockId && bt.ReturnedDate == null);
		}


		public void ReturnBook(int bookStockId)
		{
			var bookTransaction = _context.BookTransfer
				.FirstOrDefault(bt => bt.BookStockId == bookStockId && bt.ReturnedDate == null);

			if (bookTransaction == null)
				throw new Exception("This book is already returned.");

			bookTransaction.ReturnedDate = DateTime.Now;
			var bookStock = _context.BookStocks.FirstOrDefault(bs => bs.Id == bookStockId);
			if (bookStock != null)
			{
				bookStock.IsAvailable = "Available";
			}

			_context.SaveChanges();
		}

		public List<StudentHasBooks> StudentHasBooks(int studentId)
		{
			return _context.BookTransfer
				.Include(bt => bt.Student)
				.Include(bt => bt.BookStock)
					.ThenInclude(bs => bs.Book)
				.Where(bt => bt.StudentId == studentId && bt.ReturnedDate == null)
				.Select(bt => new StudentHasBooks
				{
					StudentName = bt.Student.Name,
					BookName = bt.BookStock.Book.BookName,
					BorrowDate = bt.BorrowedDate
				}).ToList();
		}
		public StatisticsDto GetStatistics()
		{
			var mostPopularBookName = _context.BookTransfer
				.Include(bt => bt.BookStock)
					.ThenInclude(bs => bs.Book)
				.GroupBy(bt => new { bt.BookStock.BookId, bt.BookStock.Book.BookName })
				.OrderByDescending(g => g.Count())
				.Select(g => g.Key.BookName)
				.AsNoTracking()
				.FirstOrDefault();

			var mostPopularAuthorName = _context.BookTransfer
				.Include(bt => bt.BookStock)
					.ThenInclude(bs => bs.Book)
						.ThenInclude(b => b.Author)
				.GroupBy(bt => new { bt.BookStock.Book.AuthorId, bt.BookStock.Book.Author.Name })
				.OrderByDescending(g => g.Count())
				.Select(g => g.Key.Name)
				.AsNoTracking()
				.FirstOrDefault();

			var mostPopularCategoryName = _context.BookTransfer
				.Include(bt => bt.BookStock)
					.ThenInclude(bs => bs.Book)
						.ThenInclude(b => b.Category)
				.GroupBy(bt => new { bt.BookStock.Book.CategoryId, bt.BookStock.Book.Category.CategoryName })
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
				TotalReturnedBooks = counts?.TotalReturnedBooks ?? 0,
				TotalBookStocks = _context.BookStocks.Count(),
				TotalAvailableBookStocks = _context.BookStocks.Count(bs => bs.IsAvailable == "Available"),
				TotalDamagedLostBooksStock = _context.BookStocks.Count(bs => bs.Status != BookStockStatus.Normal),
				TotalNotAvailableBooks = _context.BookStocks.Count(bs => bs.IsAvailable != "Available" && bs.Status == BookStockStatus.Normal)


			};
		}

		public void UpdateBookTransactions(BookTransfer bookTransfer)
		{
			var existingTransfer = _context.BookTransfer.Find(bookTransfer.Id);
			if (existingTransfer == null)
				throw new Exception("Book transfer not found.");

			if (existingTransfer.BookStockId != bookTransfer.BookStockId)
			{
				var bookStock = _context.BookStocks.FirstOrDefault(bs => bs.Id == bookTransfer.BookStockId);
				if (bookStock == null)
					throw new Exception("Selected book stock not found.");

				if (!string.Equals(bookStock.IsAvailable?.Trim(), "Available", StringComparison.OrdinalIgnoreCase))
					throw new Exception("Selected book stock is not available.");
			}

			existingTransfer.StudentId = bookTransfer.StudentId;
			existingTransfer.BookStockId = bookTransfer.BookStockId;
			existingTransfer.BorrowedDate = bookTransfer.BorrowedDate;
			existingTransfer.ReturnedDate = bookTransfer.ReturnedDate;
			var bookStockToUpdate = _context.BookStocks.FirstOrDefault(bs => bs.Id == bookTransfer.BookStockId);
			if (bookStockToUpdate != null)
			{
				if (bookTransfer.ReturnedDate == null)
					bookStockToUpdate.IsAvailable = "Not Available";
				else
					bookStockToUpdate.IsAvailable = "Available";
			}
			_context.SaveChanges();
		}

		public int GetStudentsActiveBorrowedBooksCount(int studentId)
		{
			return _context.BookTransfer.Count(bt => bt.StudentId == studentId && bt.ReturnedDate == null);
		}
	}
}
