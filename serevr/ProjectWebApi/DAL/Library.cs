using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
namespace DAL
{
    public class Library : DbContext
    {
        public Library(DbContextOptions<Library> options) : base(options)
        {
        }
        public DbSet<Book> Book { get; set; }
        public DbSet<Borrower> Borrower { get; set; }
        public DbSet<Lendings> Lendings { get; set; }
        public DbSet<Category> category { get; set; }
    }
}
