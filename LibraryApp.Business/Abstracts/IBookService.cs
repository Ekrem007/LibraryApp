using LibraryApp.Entities.Concretes;
using LibraryApp.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Business.Abstracts
{
	public interface IBookService
	{
		void AddBook(Book book);
		void DeleteBook(int bookId);
		void UpdateBook(Book book);
		List<BookWithDetailsDto> GetAllBooks();
		Book GetBookById(int bookId);
		List<Book> GetBooksByAuthorId(int authorId);
		List<Book> GetBooksByCategoryId(int categoryId);
		bool IsBookNameUnique(string bookName, int id);
	}
}
