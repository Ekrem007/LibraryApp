using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Entities.Dtos
{
	public class BookWithDetailsDto
	{
		public int Id { get; set; }
		public string BookName { get; set; }
		public int? AuthorId { get; set; }
		public string AuthorName { get; set; }
		public int? CategoryId { get; set; }
		public string CategoryName { get; set; }
		public string IsAvailable { get; set; }
		public int? BookStock { get; set; }
		public int? AvailableStock { get; set; }
		public bool? IsPassive { get; set; }
	}
}
