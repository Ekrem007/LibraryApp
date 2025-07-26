using LibraryApp.Entities.Concretes;

public class BookTransfer
{
	public int Id { get; set; }
	public int BookStockId { get; set; }
	public BookStock BookStock { get; set; }
	public int? StudentId { get; set; }
	public DateTime BorrowedDate { get; set; }
	public DateTime? ReturnedDate { get; set; }
	public Student Student { get; set; }
}