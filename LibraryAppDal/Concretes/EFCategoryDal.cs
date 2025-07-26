using LibraryApp.Entities.Concretes;
using LibraryApp.Entities.Dtos;
using LibraryAppDal.Abstracts;
using LibraryAppDal.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAppDal.Concretes
{
	public class EFCategoryDal : ICategoryDal
	{
		private readonly LibraryAppDbContext _context;
		private readonly IBookTransactionDal _bookTransactionDal;
		public EFCategoryDal(LibraryAppDbContext context, IBookTransactionDal bookTransactionDal)
		{
			_context = context;
			_bookTransactionDal = bookTransactionDal;
		}
		public void AddCategory(Category category)
		{
			_context.Categories.Add(category);
			_context.SaveChanges();
		}
		public void DeleteCategory(int categoryId)
		{
			var category = _context.Categories.Find(categoryId);
			_context.Categories.Remove(category);
			_context.SaveChanges();

		}
		public Category GetCategoryById(int categoryId)
		{
			return _context.Categories.Find(categoryId);
		}
		public List<CategoryDto> GetAllCategories()
		{
			var categories = _context.Categories
				.Include(c => c.Books)
					.ThenInclude(b => b.BookStocks)
				.Select(c => new CategoryDto
				{
					Id = c.Id,
					CategoryName = c.CategoryName,
					TotalBooks = c.Books.Count(),
					TotalAvailableBooks = c.Books
						.SelectMany(b => b.BookStocks)
						.Count(bs => bs.IsAvailable == "Available"),
					TotalNotAvailableBooks = c.Books
						.SelectMany(b => b.BookStocks)
						.Count(bs => bs.IsAvailable == "Not Available")
				})
				.ToList();
			return categories;
		}
		public void UpdateCategory(Category category)
		{
			var existingCategory = _context.Categories.Find(category.Id);
			existingCategory.CategoryName = category.CategoryName;
			_context.SaveChanges();

		}

		public bool IsCategoryNameUnıque(string categoryName, int id)
		{
			return !_context.Categories.Any(c => c.CategoryName == categoryName && c.Id != id);
		}

		public List<CategoryHasBooksDto> GetCategoriesHasBooks(int categoryId)
		{
			var books = _context.Books
				.Include(b => b.Category)
				.Where(b => b.CategoryId == categoryId)
				.ToList(); 

			var result = books.Select(b => new CategoryHasBooksDto
			{
				CategoryName = b.Category.CategoryName,
				BookName = b.BookName
			}).ToList();

			return result;
		}



	}
}
