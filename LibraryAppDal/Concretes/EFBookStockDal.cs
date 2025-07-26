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
	public class EFBookStockDal : IBookStockDal
	{
		private readonly LibraryAppDbContext _context;
		public EFBookStockDal(LibraryAppDbContext context)
		{
			_context = context;
		}
		public void AddBookStock(BookStock bookStock, int stock)
		{
			for (int i = 0; i < stock; i++)
			{
				var newBookStock = new BookStock
				{
					BookId = bookStock.BookId,
					IsAvailable = "Available",
				};

				_context.BookStocks.Add(newBookStock);
			}

			_context.SaveChanges();
		}

		public void ChangeBookStockStatus(int bookStockId, BookStockStatus newStatus)
		{
			var bookStock = _context.BookStocks.Find(bookStockId);
			if (bookStock == null) return;

			bookStock.Status = newStatus;

			if (newStatus == BookStockStatus.Damaged || newStatus == BookStockStatus.Lost)
			{
				bookStock.IsAvailable = "Not Available";
			}
			else if (newStatus == BookStockStatus.Normal)
			{
				bool isOnShelf = !_context.BookTransfer
					.Any(x => x.BookStockId == bookStockId && x.ReturnedDate == null);

				bookStock.IsAvailable = isOnShelf ? "Available" : "Not Available";
			}

			_context.SaveChanges();
		}


		public void DeleteBookStock(int bookStockId)
		{
			var bookStock = _context.BookStocks.Find(bookStockId);
			if (bookStock != null)
			{
				_context.BookStocks.Remove(bookStock);
				_context.SaveChanges();
			}
		}

		public List<BookStockDto> GetAlLBookStocks()
		{
			return _context.BookStocks
				.Include(bs => bs.Book)
				.Select(bs => new BookStockDto
				{
					Id = bs.Id,
					Barcode = bs.Barcode,
					IsAvailable = bs.IsAvailable,
					BookName = bs.Book.BookName,
					Status = bs.Status
				})
				.ToList();
		}

		public List<DamagedLostBooksDto> GetDamagedLostBooks()
		{

			return _context.BookStocks
				.Include(bs => bs.Book)
				.Include(bs => bs.Book.Author )
				.Where(bs => bs.Status != BookStockStatus.Normal)
				.Select(bs => new DamagedLostBooksDto
				{
					BookStockId = bs.Id,
					Barcode = bs.Barcode,
					BookName = bs.Book.BookName,
					AuthorName = bs.Book.Author.Name,
					Status = bs.Status
				})
				.ToList();
		}
	}
}
