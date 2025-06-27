using LibraryApp.Business.Abstracts;
using LibraryApp.Entities.Concretes;
using LibraryApp.Entities.Dtos;
using LibraryAppDal.Abstracts;
using LibraryAppDal.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Business.Concretes
{
	public class CategoryService : ICategoryService
	{
		private readonly ICategoryDal _categoryDal;
		public CategoryService(ICategoryDal categoryDal)
		{
			_categoryDal = categoryDal;

		}
		public void AddCategory(Category category)
		{
			if (string.IsNullOrWhiteSpace(category.CategoryName))
			{
				throw new ArgumentException("category name cannot be empty.");
			}
			if (!_categoryDal.IsCategoryNameUnıque(category.CategoryName, category.Id))
			{
				throw new Exception("Category name must be unique.");
			}
			_categoryDal.AddCategory(category);
		}

		public void DeleteCategory(int categoryId)
		{
			_categoryDal.DeleteCategory(categoryId);
		}

		public List<CategoryDto> GetAllCategories()
		{
			return _categoryDal.GetAllCategories();
		}

		public List<CategoryHasBooksDto> GetCategoriesHasBooks(int categoryId)
		{
			return _categoryDal.GetCategoriesHasBooks(categoryId);
		}

		public Category GetCategoryById(int categoryId)
		{
			return _categoryDal.GetCategoryById(categoryId);
		}

		public bool IsCategoryNameUnique(string categoryName, int id)
		{
			throw new NotImplementedException();
		}

		public void UpdateCategory(Category category)
		{
			if (string.IsNullOrWhiteSpace(category.CategoryName))
			{
				throw new ArgumentException("Book name cannot be empty.");
			}
			if (!_categoryDal.IsCategoryNameUnıque(category.CategoryName, category.Id))
			{
				throw new Exception("Category name must be unique.");
			}
			_categoryDal.UpdateCategory(category);

		}
	}
}
