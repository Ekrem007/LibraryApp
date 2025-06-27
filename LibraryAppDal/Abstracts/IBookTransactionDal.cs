using LibraryApp.Entities.Concretes;
using LibraryApp.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAppDal.Abstracts
{
	public interface IBookTransactionDal
	{
		void AddBookTransaction(BookTransfer bookTransfer);
		void DeleteBookTransaction(int bookTransactionId);
		BookTransactionsWithDetailsDto GetBookTransactionById(int bookTransactionId);
		List<BookTransactionsWithDetailsDto> GetAllBookTransactions();
		void UpdateBookTransactions(BookTransfer bookTransfer);
		List<BookTransactionsWithDetailsDto> GetBooksTransactionsByStudentId(int studentId);
		List<BookTransactionsWithDetailsDto> GetBooksTransactionsByBookId(int bookId);
		bool IsBookAvailable(int bookId);
		void ReturnBook(int bookId);
		List<StudentHasBooks> StudentsHasBooks(int studentId);
		StatisticsDto GetStatistics();
	}
}
