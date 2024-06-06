using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova
{
    internal class RestaurantMenu
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