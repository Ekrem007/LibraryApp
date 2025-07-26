using LibraryApp.Business.Abstracts;
using LibraryApp.Entities.Concretes;
using LibraryApp.Entities.Dtos;
using LibraryAppDal.Abstracts;
using LibraryAppDal.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Business.Concretes
{
	public class BookStockService : IBookStockService
	{
		private readonly IBookStockDal _bookStockDal;
		public BookStockService(IBookStockDal bookDal)
		{
			_bookStockDal = bookDal;
		}
		public void AddBookStock(BookStock bookStock, int stock)
		{
			if (bookStock == null)
			{
				throw new ArgumentNullException(nameof(bookStock), "Book stock cannot be null.");
			}
			if (stock <= 0)
			{
				throw new ArgumentException("Stock must be bigger than zero.");
			}
			_bookStockDal.AddBookStock(bookStock, stock);
		}

		public void ChangeBookStockStatus(int bookStockId, BookStockStatus newStatus)
		{
			_bookStockDal.ChangeBookStockStatus(bookStockId, newStatus);
		}

		public void DeleteBookStock(int bookStockId)
		{
			_bookStockDal.DeleteBookStock(bookStockId);
		}
		public List<BookStockDto> GetAllBookStocks()
		{

			return _bookStockDal.GetAlLBookStocks();
		}

		public List<DamagedLostBooksDto> GetDamagedLostBooks()
		{
			return _bookStockDal.GetDamagedLostBooks();
		}
	}
}
