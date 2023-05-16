﻿using System;
using SQLite;

string DbPath = "blogging.db";

// Note: This sample requires the database to be created before running.
Console.WriteLine($"Database path: {DbPath}.");
var db = new SQLiteAsyncConnection(DbPath);
// Read
Console.WriteLine("Querying for blogs");

var results = from blog in await db.Table<Blog>().ToListAsync()
              where blog.BlogId == 1
              select blog;

foreach (var s in results)
{
    Console.WriteLine("Blog id: " + s.BlogId + "    Blog URL: " + s.Url);
}
