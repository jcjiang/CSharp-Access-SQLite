using Microsoft.Data.Sqlite;
using SQLiteNET;
using System;

string DbPath = Path.Join(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "blogging.db");

public class Blog
{
    public int BlogId { get; set; }
    public string Url { get; set; }
}

// Note: This sample requires the database to be created before running.
Console.WriteLine($"Database path: {DbPath}.");
var db = new SqliteConnection($"Data Source={DbPath};Version=3;");
// Read
Console.WriteLine("Querying for blogs");

var results =
    from blog in db.Table<Blog>()
    where blog.BlogId == 1
    select blog;

foreach (var s in results)
{
    Console.WriteLine("Blog id: " + s.BlogId + "    Blog URL: " + s.Url);
}
