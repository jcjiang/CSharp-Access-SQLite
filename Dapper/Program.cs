using Dapper;
using Microsoft.Data.Sqlite;

Console.WriteLine("Querying for blogs");

await using var connection = new SqliteConnection(@"Server=(localdb)\mssqllocaldb;Database=Blogging;Trusted_Connection=True;");

var sql = "SELECT * FROM Blogs WHERE BlogId = 1";

var results = await connection.QueryAsync<Blog>(sql);

foreach (var s in results)
{
    Console.WriteLine("Blog id: " + s.BlogId + "Blog URL: " + s.Url);
}
