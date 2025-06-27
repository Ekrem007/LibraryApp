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
	public class AuthorService : IAuthorService
	{
		private readonly IAuthorDal _authorDal;
		public AuthorService(IAuthorDal authorDal)
		{
			_authorDal = authorDal;
		}
		public void AddAuthor(Author author)
		{
			if (string.IsNullOrWhiteSpace(author.Name))
			{
				throw new ArgumentException("Author name cannot be empty.");
			}
			if (!_authorDal.IsAuthorNameUnique( author.Name, author.Id)) 
			{
				throw new Exception("Author Name not unique.");
			}
			_authorDal.AddAuthor(author);


		}

		public void DeleteAuthor(int authorId)
		{
			_authorDal.DeleteAuthor(authorId);
		}

		public List<AuthorDto> GetAllAuthors()
		{
			return _authorDal.GetAllAuthors();
		}

		public Author GetAuthorById(int authorId)
		{
			var author = _authorDal.GetAuthorById(authorId);
			return author;

		}



		public void UpdateAuthor(Author author)
		{
			if (string.IsNullOrWhiteSpace(author.Name))
			{
				throw new ArgumentException("Author name cannot be empty.");
			}

			Author existingAuthor = _authorDal.GetAuthorById(author.Id);


			if (!_authorDal.IsAuthorNameUnique(author.Name, author.Id))
			{
				throw new InvalidOperationException("An author with the same name already exists.");
			}
			_authorDal.UpdateAuthor(author);
		}

	}
}
