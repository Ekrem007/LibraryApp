using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Entities.Concretes
{
	public class BookStock
	{
		public int Id { get; set; }
		public Guid Barcode { get; set; } = Guid.NewGuid();
		public int BookId { get; set; }
		public string IsAvailable { get; set; }
		public BookStockStatus Status { get; set; } = BookStockStatus.Normal;
		public Book Book { get; set; }
		public ICollection<BookTransfer> BookTransfers { get; set; }
	}
}
