using LibraryApp.Entities.Concretes;
using LibraryApp.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Business.Abstracts
{
	public interface IBookTransactionService
	{
		void AddBookTransaction(BookTransfer bookTransfer);
		void DeleteBookTransaction(int bookTransactionId);
		BookTransactionsWithDetailsDto GetBookTransactionById(int bookTransactionId);
		List<BookTransactionsWithDetailsDto> GetAllBookTransactions();
		void UpdateBookTransactions(BookTransfer bookTransfer);
		List<BookTransactionsWithDetailsDto> GetBooksTransactionsByStudentId(int studentId);
		List<BookTransactionsWithDetailsDto> GetBooksTransactionsByBookId(int bookId);
		void ReturnBook(int bookId);
		List<StudentHasBooks> StudentHasBooks(int studentId);
		StatisticsDto GetStatistics();
	}
}
