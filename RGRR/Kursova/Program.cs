using System;
using System.Collections.Generic;
using System.Linq;

public class MenuItem
{
    public string Name { get; set; }
    public string Category { get; set; }
    public decimal Price { get; set; }
    public string MeasurementUnit { get; set; }
}

public class RestaurantMenu
{
    private List<MenuItem> menuItems = new List<MenuItem>();

    public void AddMenuItem(MenuItem item)
    {
        menuItems.Add(item);
    }

    public void PrintSortedMenu()
    {
        var sortedMenu = menuItems.OrderBy(mi => mi.Name);
        foreach (var item in sortedMenu)
        {
            Console.WriteLine($"{item.Name} ({item.Category}): {item.Price} {item.MeasurementUnit}");
        }
    }

    public void PrintSortedMenuByPrice()
    {
        var sortedMenu = menuItems.OrderBy(mi => mi.Price);
        foreach (var item in sortedMenu)
        {
            Console.WriteLine($"{item.Name} ({item.Category}): {item.Price} {item.MeasurementUnit}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        var menu = new RestaurantMenu();
        menu.AddMenuItem(new MenuItem { Name = "Салат Цезар", Category = "Перші страви", Price = 120M, MeasurementUnit = "grams" });
        menu.AddMenuItem(new MenuItem { Name = "Борщ", Category = "Перші страви", Price = 90M, MeasurementUnit = "grams" });
        menu.AddMenuItem(new MenuItem { Name = "Сок яблучний", Category = "Напої", Price = 30M, MeasurementUnit = "ml" });
        menu.AddMenuItem(new MenuItem { Name = "Стейк", Category = "Другі страви", Price = 350M, MeasurementUnit = "grams" });

        Console.WriteLine("Відсортоване меню за іменем:");
        menu.PrintSortedMenu();

        Console.WriteLine("\nВідсортоване меню за ціною:");
        menu.PrintSortedMenuByPrice();
    }
}