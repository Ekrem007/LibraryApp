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
	public class BookTransactionService : IBookTransactionService
	{
		private readonly IBookTransactionDal _bookTransactionDal;
		public BookTransactionService(IBookTransactionDal bookTransactionDal)
		{
			_bookTransactionDal = bookTransactionDal;
		}


		public void AddBookTransaction(BookTransfer bookTransfer)
		{
			var bookStock = _bookTransactionDal.GetBookStockById(bookTransfer.BookStockId);
			if (bookStock == null)
				throw new InvalidOperationException("Book stock not found.");

			if (!_bookTransactionDal.IsBookAvailable(bookStock.Id))
			{
				throw new InvalidOperationException("This book is not available for borrowing.");
			}
			if (bookStock.Book != null && bookStock.Book.IsPassive == true)
				throw new InvalidOperationException("not available because book is passive");
			if (_bookTransactionDal.GetStudentsActiveBorrowedBooksCount(bookTransfer.StudentId.Value) >= 2)
			{
				throw new InvalidOperationException("The student has reached the limit he can receive book ");
			}

			_bookTransactionDal.AddBookTransaction(bookTransfer);
		}


		public void DeleteBookTransaction(int bookTransactionId)
		{
			_bookTransactionDal.DeleteBookTransaction(bookTransactionId);
		}

		public List<BookTransactionsWithDetailsDto> GetAllBookTransactions()
		{
			return _bookTransactionDal.GetAllBookTransactions();
		}

		public List<BookTransactionsWithDetailsDto> GetBooksTransactionsByBookId(int bookId)
		{
			return _bookTransactionDal.GetBooksTransactionsByBookId(bookId);
		}

		public List<BookTransactionsWithDetailsDto> GetBooksTransactionsByStudentId(int studentId)
		{
			return _bookTransactionDal.GetBooksTransactionsByStudentId(studentId);
		}

		public BookTransactionsWithDetailsDto GetBookTransactionById(int bookTransactionId)
		{
			return _bookTransactionDal.GetBookTransactionById(bookTransactionId);
		}

		public StatisticsDto GetStatistics()
		{
			return _bookTransactionDal.GetStatistics();
		}

		public void ReturnBook(int bookStockId)
		{
			_bookTransactionDal.ReturnBook(bookStockId);
		}

		public List<StudentHasBooks> StudentHasBooks(int studentId)
		{

			var books = _bookTransactionDal.StudentHasBooks(studentId);
			if (books == null || books.Count == 0)
			{
				throw new Exception("Student does not have any borrowed books.");
			}
			return books;
		}

		public void UpdateBookTransactions(BookTransfer bookTransfer)
		{
			var existingTransfer = _bookTransactionDal.GetBookTransactionById(bookTransfer.Id);
			if (existingTransfer == null)
			{
				throw new InvalidOperationException("Book transaction not found.");
			}

			if (bookTransfer.BookStockId != existingTransfer.BookStockId)
			{
				if (!_bookTransactionDal.IsBookAvailable(bookTransfer.BookStockId))
				{
					throw new InvalidOperationException("This book is not available for borrowing.");
				}
				var newBookStock = _bookTransactionDal.GetBookStockById(bookTransfer.BookStockId);
				if (newBookStock == null)
				{
					throw new InvalidOperationException("Book stock not found.");
				}

				if (newBookStock.Book != null && newBookStock.Book.IsPassive == true)
				{
					throw new InvalidOperationException("Selected book is passive.");
				}

				if (_bookTransactionDal.GetStudentsActiveBorrowedBooksCount(bookTransfer.StudentId.Value) >= 3)
				{
					throw new InvalidOperationException("The student has reached the limit he can receive book.");
				}
			}

			if (bookTransfer.ReturnedDate == null)
			{
				var borrowedByOthers = _bookTransactionDal
					.GetAllBookTransactions()
					.Any(bt => bt.BookStockId == bookTransfer.BookStockId &&
							   bt.ReturnDate == null &&
							   bt.Id != bookTransfer.Id);

				if (borrowedByOthers)
				{
					throw new InvalidOperationException("This book is currently borrowed by another student.");
				}
			}
			var activeCount = _bookTransactionDal.GetStudentsActiveBorrowedBooksCount(bookTransfer.StudentId.Value);

			if (existingTransfer.ReturnDate == null)
			{
				activeCount--;
			}

			if (activeCount >= 2)
			{
				throw new InvalidOperationException("The student has reached the limit he can receive book.");
			}

			_bookTransactionDal.UpdateBookTransactions(bookTransfer);
		}




	}

}