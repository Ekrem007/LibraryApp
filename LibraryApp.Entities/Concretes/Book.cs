using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Entities.Concretes
{
	public class Book
	{
		public int Id { get; set; }
		public string BookName { get; set; }
		public int? AuthorId { get; set; }
		public int? CategoryId { get; set; }
		public Author Author { get; set; }
		public Category Category { get; set; }
		public ICollection<BookTransfer> BookTransfers { get; set; }

	}
}
