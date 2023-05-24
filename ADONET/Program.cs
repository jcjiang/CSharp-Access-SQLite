using Microsoft.Data.Sqlite;

Console.WriteLine("Querying for blogs");
string DbPath = "blogging.db";
Console.WriteLine($"Database path: {DbPath}");

await using var conn = new SqliteConnection($"Data Source={DbPath}");

await conn.OpenAsync();

await using var cmd = new SqliteCommand("SELECT * FROM Blogs WHERE BlogId = 1", conn);
await using var dataReader = await cmd.ExecuteReaderAsync();

while (await dataReader.ReadAsync())
{
    Console.WriteLine(dataReader["BlogId"]);
    Console.WriteLine(dataReader["Url"]); //not an object!
}
