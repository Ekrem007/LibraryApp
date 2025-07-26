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
	public class BookService : IBookService
	{
		private readonly IBookDal _bookDal;
		public BookService(IBookDal bookDal)
		{
			_bookDal = bookDal;
		}
		public void AddBook(Book book)
		{
			if (string.IsNullOrWhiteSpace(book.BookName))
			{
				throw new ArgumentException("Book name cannot be empty.");
			}
			if (!_bookDal.IsBookNameUnique(book.BookName,book.Id))
			{
				throw new Exception("Book Name not unique.");
			}
			_bookDal.AddBook(book);
		}


		public void DeleteBook(int bookId)
		{
			_bookDal.DeleteBook(bookId);
		}

		public List<BookWithDetailsDto> GetAllBooks()
		{
			return _bookDal.GetAllBooks();
		}

		public Book GetBookById(int bookId)
		{
			return _bookDal.GetBookById(bookId);
		}

		public List<Book> GetBooksByAuthorId(int authorId)
		{
			return _bookDal.GetBooksByAuthorId(authorId);
		}

		public List<Book> GetBooksByCategoryId(int categoryId)
		{
			return _bookDal.GetBooksByCategoryId(categoryId);
		}

		public bool IsBookNameUnique(string bookName, int id)
		{
			throw new NotImplementedException();
		}

		public void UpdateBook(Book book)
		{
			if (string.IsNullOrWhiteSpace(book.BookName))
			{
				throw new ArgumentException("Book name cannot be empty.");
			}
			if (!_bookDal.IsBookNameUnique(book.BookName,book.Id))
			{
				throw new Exception("Book Name not unique.");
			}

			_bookDal.UpdateBook(book);
		}
		public void ChangeBookStatus(int bookId)
		{
			_bookDal.ChangeBookStatus(bookId);
		}
	}
}
