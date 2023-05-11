using Dapper;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;

Console.WriteLine("Querying for blogs");
string DbPath = "blogging.db";
Console.WriteLine($"Database path: {DbPath}.");

await using var connection = new SqliteConnection($"Data Source={DbPath}"); 

var sql = "SELECT * FROM Blogs WHERE BlogId = 1";

var results = await connection.QueryAsync<Blog>(sql);

foreach (var s in results)
{
    Console.WriteLine("Blog id: " + s.BlogId + "    Blog URL: " + s.Url);
}
