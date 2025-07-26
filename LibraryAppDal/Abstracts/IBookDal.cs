using LibraryApp.Entities.Concretes;
using LibraryApp.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAppDal.Abstracts
{
	public interface IBookDal
	{
		void AddBook(Book book);
		void DeleteBook(int bookId);
		Book GetBookById(int bookId);
		List<BookWithDetailsDto> GetAllBooks();
		void UpdateBook(Book book);
		List<Book> GetBooksByAuthorId(int authorId);
		List<Book> GetBooksByCategoryId(int categoryId);
		bool IsBookNameUnique(string bookName, int id);
		void ChangeBookStatus(int bookId);

	}
}
