using LibraryApp.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Diagnostics;


namespace LibraryAppDal.Context
{
	public class LibraryAppDbContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder option)
		{
			option.UseSqlServer("Server=DESKTOP-66LKAVD;Database=LibraryApp;Trusted_Connection=True;" +
				"TrustServerCertificate=True;" +
				"MultipleActiveResultSets=True;")
				.EnableSensitiveDataLogging()
				.LogTo(message => Debug.WriteLine(message), LogLevel.Information);


		}
		public DbSet<Book> Books { get; set; }
		public DbSet<Author> Authors { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Student> Students { get; set; }
		public DbSet<BookTransfer> BookTransfer { get; set; }
		public DbSet<BookStock> BookStocks { get; set; }


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Book>(entity =>
			{
				entity.HasOne(b => b.Category)
					  .WithMany(c => c.Books)
					  .HasForeignKey(b => b.CategoryId)
					  .OnDelete(DeleteBehavior.Cascade);

				entity.HasOne(b => b.Author)
					  .WithMany(a => a.Books)
					  .HasForeignKey(b => b.AuthorId)
					  .OnDelete(DeleteBehavior.Cascade);

				entity.HasIndex(b => b.BookName)
					  .IsUnique();
			});

			modelBuilder.Entity<BookTransfer>(entity =>
			{
				entity.HasOne(bt => bt.BookStock)
					  .WithMany(bs => bs.BookTransfers)
					  .HasForeignKey(bt => bt.BookStockId)
					  .OnDelete(DeleteBehavior.Restrict);

				entity.HasOne(bt => bt.Student)
					  .WithMany(s => s.BookTransfers)
					  .HasForeignKey(bt => bt.StudentId)
					  .OnDelete(DeleteBehavior.Cascade);
			});

			modelBuilder.Entity<Author>(entity =>
			{
				entity.HasIndex(a => a.Name)
					  .IsUnique();
			});

			modelBuilder.Entity<Category>(entity =>
			{
				entity.HasIndex(c => c.CategoryName)
					  .IsUnique();
			});

			modelBuilder.Entity<Student>(entity =>
			{
				entity.HasIndex(s => s.StudentNumber)
					  .IsUnique();
			});

			modelBuilder.Entity<BookStock>(entity =>
			{
				entity.HasOne(bs => bs.Book)
					  .WithMany(b => b.BookStocks)
					  .HasForeignKey(bs => bs.BookId)
					  .OnDelete(DeleteBehavior.Cascade);

				entity.HasIndex(bs => bs.Barcode)
					  .IsUnique();
			});
		}
	}
}