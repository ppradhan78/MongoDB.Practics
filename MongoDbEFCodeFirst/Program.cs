// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using MongoDbEFCodeFirst;

Console.WriteLine("Hello, World!");

var mongoClient = new MongoClient("mongodb://localhost:27017/");
var dbContextOptions =
    new DbContextOptionsBuilder<MongoDbContext>().UseMongoDB(mongoClient, "EFCode");
var db = new MongoDbContext(dbContextOptions.Options);
// Add a new customer and save it to the database
db.Customers.Add(new Customer() { CustomerId=1, Name = "John Doe", Order = "1 Green Tea" });
db.SaveChanges();
