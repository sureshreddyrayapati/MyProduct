// See https://aka.ms/new-console-template for more information
using MyProduct;
Console.WriteLine("Welcome to My Products.......!");
Products obj = new Products();
foreach (var item in obj.AllProducts())
{
    Console.WriteLine($"Product ID        : {item.Key}");
    Console.WriteLine($"Name              : {item.Value.Name}");
    Console.WriteLine($"Price             : {item.Value.Price}");
    Console.WriteLine($"Brand             : {item.Value.Brand}");
    Console.WriteLine($"Manufacturing Date: {item.Value.ManufacturingDate.ToShortDateString()}");
    Console.WriteLine($"Expiry Date       : {item.Value.ExporyDate.ToShortDateString()}");
    Console.WriteLine("-----------------------------------------");
}


