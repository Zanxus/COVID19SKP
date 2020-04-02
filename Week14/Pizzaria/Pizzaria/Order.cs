using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    class Order
    {
        ObservableCollection<IOrderable> OrderItems { get; set; }

        public decimal TotalPrice()
        {
            decimal totalPrice = 0;
            foreach (var Item in OrderItems)
            {
                totalPrice += Item.Price;
            };
            return totalPrice;
        }
    }
}
