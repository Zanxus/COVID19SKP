using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    public class Pizza
    {
        public int PizzaID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public PizzaSize Size { get; set; }
        public ObservableCollection<string> Ingredients { get; set; }


        public Pizza(int pizzaID,string name, PizzaSize size, ObservableCollection<string> ingredients, decimal price)
        {
            this.PizzaID = pizzaID;
            this.Name = name;
            this.Size = size;
            this.Ingredients = ingredients;
            Price = price;
        }

        public enum PizzaSize
        {
            Normal = 1,Familiy
        }

        private decimal PizzaPrice()
        {
            decimal price = 60;
            if (Size == PizzaSize.Familiy)
            {
                price *= 2;
            };
            if (this.Ingredients.Count > 5)
            {
                price += 8;
            }
            return price;
        }
    }
}
