using LibraryApp.Entities.Concretes;

public class Book
{
	public int Id { get; set; }
	public string BookName { get; set; }
	public int? AuthorId { get; set; }
	public int? CategoryId { get; set; }
	public bool? IsPassive { get; set; } = false;
	public Author Author { get; set; }
	public Category Category { get; set; }
	public ICollection<BookStock> BookStocks { get; set; }
}