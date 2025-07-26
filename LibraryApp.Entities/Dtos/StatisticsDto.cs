using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Entities.Dtos
{
	public class StatisticsDto
	{
		public string MostPopularBook { get; set; }
		public string MostPopularAuthor { get; set; }
		public string MostPopularCategory { get; set; }
		public int TotalBooks { get; set; }
		public int TotalAuthors { get; set; }
		public int TotalCategories { get; set; }
		public int TotalStudents { get; set; }
		public int TotalBorrowedBooks { get; set; }
		public int TotalReturnedBooks { get; set; }
		public int TotalBookStocks { get; set; }
		public int TotalAvailableBookStocks { get; set; }
		public int TotalDamagedLostBooksStock { get; set; }
		public int TotalNotAvailableBooks { get; set; }

	}
}
