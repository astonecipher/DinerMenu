using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDineMax.Business
{
    public class MenuItem
    {
        public string Title;
        public string Description;
        public double Price
        {
            get { return _price; }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
                else
                {
                    throw new ApplicationException("Price is below minimum.");
                }
            }
        }
        private double _price;
    }
}
