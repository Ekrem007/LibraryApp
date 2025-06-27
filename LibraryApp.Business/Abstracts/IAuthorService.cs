using LibraryApp.Entities.Concretes;
using LibraryApp.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Business.Abstracts
{
	public interface IAuthorService
	{
		void AddAuthor(Author author);
		void DeleteAuthor(int authorId);
		Author GetAuthorById(int authorId);
		List<AuthorDto> GetAllAuthors();
		void UpdateAuthor(Author author);

	}
}
