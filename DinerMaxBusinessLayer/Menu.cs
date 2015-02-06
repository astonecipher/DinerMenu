using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDineMax.Business
{
    public class Menu
    {
        public Menu()
        {
            items = new List<MenuItem>();
        }

        public void AddMenuItem( string title, string description, double price)
        {
            MenuItem item = new MenuItem();
            item.Title = title;
            item.Description = description;
            item.Price = price;
            items.Add(item);

        }
        public string name;
        public List<MenuItem> items;


    }
}
