using LibraryApp.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Entities.Dtos
{
	public class BookStockDto
	{
		public int Id { get; set; }
		public Guid Barcode { get; set; } = Guid.NewGuid();
		public string IsAvailable { get; set; }
		public string BookName { get; set; }
		public BookStockStatus Status { get; set; } = BookStockStatus.Normal;
	}
}
