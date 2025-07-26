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
	public class EFAuthorDal : IAuthorDal
	{
		private readonly LibraryAppDbContext _context;
		private readonly IBookTransactionDal _bookTransactionDal;
		public EFAuthorDal(LibraryAppDbContext context, IBookTransactionDal bookTransactionDal)
		{
			_context = context;
			_bookTransactionDal = bookTransactionDal;
		}

		public void AddAuthor(Author author)
		{
			_context.Authors.Add(author);
			_context.SaveChanges();
		}
		public void DeleteAuthor(int authorId)
		{
			var author = _context.Authors.Find(authorId);
			_context.Authors.Remove(author);
			_context.SaveChanges();
			
		}
		public Author GetAuthorById(int authorId)
		{
			return _context.Authors.Find(authorId);
		}
		public List<AuthorDto> GetAllAuthors()
		{
			var authors = _context.Authors
				.Include(a => a.Books).ThenInclude(b => b.BookStocks)
				.Select(a => new AuthorDto
				{
					Id = a.Id,
					Name = a.Name,
					TotalBooks = a.Books.Count(),
					TotalAvailableBooks = a.Books
						.SelectMany(b => b.BookStocks)
						.Count(bs => bs.IsAvailable == "Available"),
					TotalNotAvailableBooks = a.Books
						.SelectMany(b => b.BookStocks)
						.Count(bs => bs.IsAvailable == "Not Available")
				})
				.ToList();

			return authors;
		}
		public void UpdateAuthor(Author author)
		{
			var existingAuthor = _context.Authors.Find(author.Id);
			if (existingAuthor != null)
			{
				existingAuthor.Name = author.Name;
				_context.SaveChanges();
			}
		}

		public bool IsAuthorNameUnique(string authorName, int id)
		{
			return !_context.Authors.Any(a => a.Name == authorName && a.Id != id);
		}
	}
}
