using Microsoft.Data.Sqlite;

Console.WriteLine("Querying for blogs");

await using var conn = new SqliteConnection(@"Server=(localdb)\mssqllocaldb;Database=Blogging;Trusted_Connection=True;");

await conn.OpenAsync();

await using var cmd = new SqliteCommand("SELECT * FROM Blogs WHERE BlogId = 1", conn);
await using var dataReader = await cmd.ExecuteReaderAsync();

while (await dataReader.ReadAsync())
{
    Console.WriteLine(dataReader["BlogId"].ToString());
    Console.WriteLine(dataReader["Url"].ToString()); //not an object!
}
