using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

await using var db = new BloggingContext();

// Note: This sample requires the database to be created before running.
Console.WriteLine($"Database path: {db.DbPath}.");

// Read
Console.WriteLine("Querying for blogs");

var results =
    from blog in db.Blogs
    where blog.BlogId == 1
    select blog;

await foreach (var s in results.AsAsyncEnumerable())
{
    Console.WriteLine("Blog id: " + s.BlogId + "    Blog URL: " + s.Url);
}