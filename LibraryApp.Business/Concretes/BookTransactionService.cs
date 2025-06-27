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
			if (bookTransfer.BookId == 0)
			{
				throw new Exception("Please select a book.");
			}
			if (!_bookTransactionDal.IsBookAvailable(bookTransfer.BookId.Value))
			{
				throw new InvalidOperationException("This book is not available");
			}

			if ( bookTransfer.StudentId == 0)
			{
				throw new ArgumentException("please Choose student");
			}
			if (bookTransfer.BorrowedDate > bookTransfer.ReturnedDate)
			{
				throw new ArgumentException("Borrowed time cant  be later than returned time ");
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

		public void ReturnBook(int bookId)
		{
			if (_bookTransactionDal.IsBookAvailable(bookId))
			{
				throw new InvalidOperationException("This book is already returned");
			}
			_bookTransactionDal.ReturnBook(bookId);
		}

		public List<StudentHasBooks> StudentHasBooks(int studentId)
		{
			var books = _bookTransactionDal.StudentsHasBooks(studentId);
			if (books == null || books.Count == 0)
			{
				throw new Exception("student does not have book");
			}
			return books;
		}

		public void UpdateBookTransactions(BookTransfer bookTransfer)
		{
			var existingTransaction = _bookTransactionDal.GetBookTransactionById(bookTransfer.Id);
			if (bookTransfer.BookId != existingTransaction.BookId && !_bookTransactionDal.IsBookAvailable(bookTransfer.BookId.Value))
			{
				throw new InvalidOperationException("This book is not available");
			}
			_bookTransactionDal.UpdateBookTransactions(bookTransfer);
		}
		public StatisticsDto GetStatistics()
		{
			return _bookTransactionDal.GetStatistics();
		}
	}
}
