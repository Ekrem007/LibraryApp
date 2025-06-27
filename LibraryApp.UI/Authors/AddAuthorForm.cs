using DevExpress.XtraEditors;
using LibraryApp.Business.Abstracts;
using LibraryApp.Business.Concretes;
using LibraryApp.Entities.Concretes;
using LibraryApp.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp.UI.Author
{
	public partial class AddAuthorForm : DevExpress.XtraEditors.XtraForm
	{
		private readonly IAuthorService _authorService;
		private readonly int _authorId;

		public AddAuthorForm(IAuthorService authorService, int authorId = 0)
		{
			InitializeComponent();
			_authorService = authorService;
			_authorId = authorId;

			if (_authorId > 0)
			{
				var book = _authorService.GetAuthorById(_authorId);
				if (book != null)
				{
					txtAuthorName.Text = book.Name;
					btnSaveAuthor.Text = "Update Author";
				}
			}
			else
			{
				btnSaveAuthor.Text = "Add Author";
			}
		}

		private void btnSaveAuthor_Click(object sender, EventArgs e)
		{

			var author = new Entities.Concretes.Author
			{
				Id = _authorId,
				Name = txtAuthorName.Text
			};
			try
			{
				if (_authorId > 0)
				{
					_authorService.UpdateAuthor(author);
					MessageBox.Show("Author updated successfully.");
				}
				else
				{
					_authorService.AddAuthor(author);
					MessageBox.Show("Author added successfully.");
				}
				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An error occurred: {ex.Message}");
			}


		}


	

	}
}
