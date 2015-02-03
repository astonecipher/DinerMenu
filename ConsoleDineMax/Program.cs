using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDineMax
{
    class Program
    {
        static void Main(string[] args)
        {
            FoodMenu summerMenu = new FoodMenu();
            summerMenu.name = "Summer Menu";
            summerMenu.AddMenuItem("Salmon", "Fresh Norwegian Salmon with Sandefjord butter.", 25.50);
            summerMenu.AddMenuItem("Tacos", "All Norwegians eat tacos on Fridays", 10);

            DrinkMenu outsideDrinks = new DrinkMenu();
            outsideDrinks.disclaimer = "Drink and Code!";
            outsideDrinks.AddMenuItem("Virgin Cuba Libre", "A Classis", 10);
            outsideDrinks.AddMenuItem("Screwdriver", "Premium Vodka and Flordia Orange Juice", 8);

            Order hungryGuestorder = new Order();
            
            for( int i = 0; i <= summerMenu.items.Count-1; i++)
            {
                MenuItem currentItem = summerMenu.items[i];
                hungryGuestorder.items.Add(currentItem);

            
            }

            foreach ( MenuItem currentItem in outsideDrinks.items)
            {
                hungryGuestorder.items.Add(currentItem);
            }

            Console.WriteLine("The total is {0}", hungryGuestorder.total.ToString("c"));
            Console.ReadKey();

        }
    }
}
