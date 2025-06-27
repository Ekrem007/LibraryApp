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
	public class EFBookDal : IBookDal
	{
		private readonly LibraryAppDbContext _context;
		private readonly IBookTransactionDal _bookTransactionDal;
		public EFBookDal(LibraryAppDbContext context, IBookTransactionDal bookTransactionDal)
		{
			_context = context;
			_bookTransactionDal = bookTransactionDal;
		}
		public void AddBook(Book book)
		{
			_context.Books.Add(book);
			_context.SaveChanges();
		}
		public void DeleteBook(int bookId)
		{
			var book = _context.Books.Find(bookId);
			if (book != null)
			{
				_context.Books.Remove(book);
				_context.SaveChanges();
			}
		}
		public Book GetBookById(int bookId)
		{
			return _context.Books.Find(bookId);
		}
		public List<BookWithDetailsDto> GetAllBooks()
		{
			return _context.Books
				.Select(b => new BookWithDetailsDto
				{
					Id = b.Id,
					BookName = b.BookName,
					AuthorId = b.AuthorId,
					AuthorName = b.Author.Name,
					CategoryId = b.CategoryId,
					CategoryName = b.Category.CategoryName,
					IsAvailable = _bookTransactionDal.IsBookAvailable(b.Id) ? "available" : "not available"
				})
				.ToList();
		}
		public void UpdateBook(Book book)
		{
			var existingBook = _context.Books.Find(book.Id);

			existingBook.BookName = book.BookName;
			existingBook.AuthorId = book.AuthorId;
			existingBook.CategoryId = book.CategoryId;
			_context.SaveChanges();

		}
		public List<Book> GetBooksByAuthorId(int authorId)
		{
			return _context.Books.Where(b => b.AuthorId == authorId).ToList();
		}
		public List<Book> GetBooksByCategoryId(int categoryId)
		{
			return _context.Books.Where(b => b.CategoryId == categoryId).ToList();
		}
		public bool IsBookNameUnique(string bookName, int id)
		{
			return !_context.Books.Any(b => b.BookName == bookName && b.Id != id);
		}
	}
}