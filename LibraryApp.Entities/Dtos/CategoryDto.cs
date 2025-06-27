using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Entities.Dtos
{
	public class CategoryDto
	{
		public int Id { get; set; }
		public string CategoryName { get; set; }
		public int TotalBooks { get; set; }
		public int TotalAvailableBooks { get; set; }
		public int TotalNotAvailableBooks { get; set; }
	}
}
