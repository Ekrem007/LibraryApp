using LibraryApp.Entities.Concretes;
using LibraryApp.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Business.Abstracts
{
	public interface ICategoryService
	{
		void AddCategory(Category category);
		void DeleteCategory(int categoryId);
		Category GetCategoryById(int categoryId);
		List<CategoryDto> GetAllCategories();
		void UpdateCategory(Category category);
		bool IsCategoryNameUnique(string categoryName, int id);
		List<CategoryHasBooksDto> GetCategoriesHasBooks(int categoryId);
	}
}
