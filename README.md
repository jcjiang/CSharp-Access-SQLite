## Connect to a SQLite Database using C#
This repository contains a sample code project that demonstrates how to use the [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/) library to connect to and query data from a SQLite database using C#. 

The code in this repository connects to a SQLite database in the same folder named `blogging.db` and uses EF Core to read from its data. The code demonstrates how to map database entities to C# classes and use the C# classes in place of the database entities. The repository also shows the same functionality implemented in Dapper and ADO.NET, to demonstrate the amount of operations and tasks that is abstracted by EF Core.

This sample draws from this tutorial for [Getting Started with EF Core with SQLite](https://learn.microsoft.com/en-us/ef/core/get-started/overview/first-app).

### Prerequisites
- [.NET Core 6.0 or higher](https://dotnet.microsoft.com/en-us/download/dotnet/7.0) 
- [SQLite](https://www.sqlite.org/download.html)
    - 
- [Visual Studio](https://visualstudio.microsoft.com/downloads/)
- A basic understanding of C# and SQL 

### Installation
1. Clone or download the repository to your local machine.
2. Use Visual Studio to debug and run the project. 

### Create Database 

Run the code below in the project folder to create a SQLite database named `blogging.db` and insert a single blog post. Do this before you run the project! The sample code samples depend on having an existing database to connect to and query.

### Run

Each code sample has the same functionality implemented in a different way. When run, the code will generate a console app that connects to a SQL Server (or Azure SQL database with the appropriate connection string) and queries it for all the blog posts stored.

```
sqlite3 blogging.db
```

### Contribution

If you wish to contribute, you can submit a pull request. 

Overall, this code is intended to provide a basic understanding of how Entity Framework Core can be used to interact with a SQL database in a C# application, and should not be used as-is in a production environment. Instead, this code should be used as the beginning passage to build your database application.

Please let me know if you need more help by [creating an issue](https://github.com/jcjiang/CSharp-AccessSQL-Demo/issues).