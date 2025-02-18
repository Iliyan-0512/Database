using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace entitiFrameworkWithMysql.Data.Models;

public partial class BookContext : DbContext
{
    

    public BookContext(DbContextOptions<BookContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<Member> Members { get; set; }

    public void AddBook(Book book)
    {
        Books.Add(book); 
        SaveChanges();
    }
}
