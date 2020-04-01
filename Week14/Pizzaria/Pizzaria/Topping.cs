using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    //not in use currently
    public class Topping
    {
        public string ToppingName { get; set; }
        public decimal ToppingPrice { get; set; }

        public Topping(string toppingName, decimal toppingPrice = 8)
        {
            ToppingName = toppingName;
            ToppingPrice = toppingPrice;
        }
    }

}
