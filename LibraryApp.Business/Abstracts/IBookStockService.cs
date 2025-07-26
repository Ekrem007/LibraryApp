using LibraryApp.Entities.Concretes;
using LibraryApp.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Business.Abstracts
{
	public interface IBookStockService
	{
		void DeleteBookStock(int bookStockId);
		void AddBookStock(BookStock bookStock, int stock);
		List<BookStockDto> GetAllBookStocks();
		List<DamagedLostBooksDto> GetDamagedLostBooks();
		void ChangeBookStockStatus(int bookStockId, BookStockStatus newStatus);
	}
}
