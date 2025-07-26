using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Entities.Dtos
{
	public class StudentWithDetailsDto
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string StudentNumber { get; set; }
		public string PhoneNumber { get; set; }
		public int? TotalBorrowedBookCount { get; set; }
		public string? LastBorrowedBookName { get; set; }
		public double? AverageReadingDays { get; set; } 
		public string? FavoriteCategory { get; set; }
	}
}
