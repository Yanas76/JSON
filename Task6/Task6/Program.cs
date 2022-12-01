using System;
using System.Text;
using System.Text.Json;

Console.OutputEncoding = Encoding.UTF8;
const string Path = "./Information.json";
var jsonContent = File.ReadAllText(Path);

BookList bookList = JsonSerializer.Deserialize<BookList>(jsonContent, new JsonSerializerOptions{PropertyNameCaseInsensitive = true});

foreach(var book in bookList.exclude)
{
    if(book.PublishingHouseId != 0)
    {
        Console.WriteLine(book.PublishingHouseId);
    }
    
    Console.WriteLine(book.Name);
    //Console.WriteLine(book.Title);
    Console.WriteLine(book.publishingHouse.Id);
    Console.WriteLine(book.publishingHouse.Name);
    Console.WriteLine(book.publishingHouse.Adress);
}


