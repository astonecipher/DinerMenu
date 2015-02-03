using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDineMax
{
   public class Order
    {
       public List<MenuItem> items = new List<MenuItem>();

       public double total
       {
           get
           {
               double calculatedTotal = 0;
               foreach ( MenuItem item in items)
               {
                   calculatedTotal = calculatedTotal + item.price;
               }
               return calculatedTotal;
           }
       }
    }
}
