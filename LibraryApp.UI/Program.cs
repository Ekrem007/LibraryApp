using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using LibraryApp.Business.Abstracts;
using LibraryApp.Business.Concretes;
using LibraryAppDal.Abstracts;
using LibraryAppDal.Concretes;
using LibraryAppDal.Context;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LibraryApp.UI
{
	internal static class Program
	{	
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			var services = new ServiceCollection();
			services.AddScoped<frmMain>();
			services.AddScoped<LibraryAppDbContext>();
			services.AddScoped<IAuthorDal, EFAuthorDal>();
			services.AddScoped<IBookDal, EFBookDal>();
			services.AddScoped<ICategoryDal, EFCategoryDal>();
			services.AddScoped<ICategoryService, CategoryService>();
			services.AddScoped<IAuthorService, AuthorService>();
			services.AddScoped<IBookService, BookService>();
			services.AddScoped<IStudentDal, EFStudentDal>();
			services.AddScoped<IStudentService, StudentService>();
			services.AddScoped<IBookTransactionDal, EFBookTransactionDal>();
			services.AddScoped<IBookTransactionService, BookTransactionService>();

			var serviceProvider = services.BuildServiceProvider();
			var form = serviceProvider.GetRequiredService<frmMain>();
			Application.Run(form);




		}
	}
}
