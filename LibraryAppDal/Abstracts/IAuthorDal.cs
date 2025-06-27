using LibraryApp.Entities.Concretes;
using LibraryApp.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAppDal.Abstracts
{
	public interface IAuthorDal
	{
		List<AuthorDto> GetAllAuthors();
		Author GetAuthorById(int authorId);
		void AddAuthor(Author author);
		void UpdateAuthor(Author author);
		void DeleteAuthor(int authorId);
		bool IsAuthorNameUnique(string authorName, int id);

	}
}
