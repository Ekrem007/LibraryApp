using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Entities.Concretes
{
	public class BookTransfer
	{
		public int Id { get; set; }

		public int? BookId { get; set; }
		public int? StudentId { get; set; }

		public DateTime BorrowedDate { get; set; }
		public DateTime? ReturnedDate { get; set; }

		public Book Book { get; set; }
		public Student Student { get; set; }
	}
}
