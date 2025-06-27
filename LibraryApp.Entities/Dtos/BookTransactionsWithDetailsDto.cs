using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Entities.Dtos
{
	public class BookTransactionsWithDetailsDto
	{
		public int Id { get; set; }
		public string BookName { get; set; }
		public string StudentName { get; set; }
		public int? BookId { get; set; }
		public int? StudentId { get; set; }
		public DateTime BorrowedDate { get; set; } 
		public DateTime? ReturnDate { get; set; }


	}
}
