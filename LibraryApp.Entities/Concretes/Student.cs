using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Entities.Concretes
{
	public class Student
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string StudentNumber { get; set; }
		public string PhoneNumber { get; set; }
		public ICollection<BookTransfer> BookTransfers { get; set; }

	}
}
