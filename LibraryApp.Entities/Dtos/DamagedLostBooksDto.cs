using LibraryApp.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Entities.Dtos
{
	public class DamagedLostBooksDto
	{
		public int BookStockId { get; set; }
		public Guid Barcode { get; set; } 
		public string BookName { get; set; }
		public string AuthorName { get; set; }
		public BookStockStatus Status { get; set; }


	}
}
