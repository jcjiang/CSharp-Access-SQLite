using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

public class BloggingContext : DbContext
{
    public DbSet<Blog> Blogs { get; set; }

    public string DbPath { get; }

    public BloggingContext()
    {
        DbPath = Path.Join(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "blogging.db");
        //copy database on build - replace DbPath with the path to local database
    }

    // The following configures EF to use a Sqlite database file in the project folder.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}

public class Blog
{
    public int BlogId { get; set; }
    public string Url { get; set; }
}
