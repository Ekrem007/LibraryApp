using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Entities.Dtos
{
	public class StudentHasBooks
	{
		public string StudentName { get; set; }
		public string BookName { get; set; }
		public DateTime BorrowDate { get; set; }
		
	}
}
