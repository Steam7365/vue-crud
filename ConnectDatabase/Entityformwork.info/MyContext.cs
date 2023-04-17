using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entityformwork.info
{
    public class MyContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<BookType> BooksTypes { get; set; }
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //添加种子数据
            BookType[] bookTypes = new BookType[]
            {
                new BookType() {Id=1, TypeName = "国语书籍" },
                new BookType() {Id=2, TypeName = "外语书籍" }
            };
            Book[] books = new Book[]
            {
                new Book() {Id=1, Name = "百草集", Author = "鲁迅", CreatedDate = DateTime.Now,BookTypeId=1},
                new Book() {Id=2, Name = "彷徨", Author = "鲁迅", CreatedDate = DateTime.Now,BookTypeId=1},
                new Book() {Id=3, Name = "活着", Author = "余华", CreatedDate = DateTime.Now,BookTypeId=1},
                new Book() {Id=4, Name = "老人与海", Author = "海明威", CreatedDate = Convert.ToDateTime("2021-02-12"),BookTypeId=2}
            };
            modelBuilder.Entity<BookType>().HasData(bookTypes);
            modelBuilder.Entity<Book>().HasData(books);
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }
    }
}
