using LibraryApp.Entities.Concretes;
using LibraryApp.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAppDal.Abstracts
{
	public interface IBookStockDal
	{
		void DeleteBookStock(int bookStockId);
		void AddBookStock(BookStock bookStock, int stock);
		List<BookStockDto> GetAlLBookStocks();
		List<DamagedLostBooksDto> GetDamagedLostBooks();
		void ChangeBookStockStatus(int bookStockId, BookStockStatus newStatus);
	}
}
