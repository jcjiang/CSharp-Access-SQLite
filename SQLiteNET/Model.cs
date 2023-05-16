using System;
using SQLite;

[Table("Blogs")]
public class Blog
{
    public int BlogId { get; set; }
    public string Url { get; set; }
}
