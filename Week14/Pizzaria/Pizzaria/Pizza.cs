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
        public Size size;
        public ObservableCollection<Ingredient> ingredients;

        public Pizza(int pizzaID, Size size, ObservableCollection<Ingredient> ingredients, decimal price)
        {
            this.PizzaID = pizzaID;
            this.size = size;
            this.ingredients = ingredients;
            Price = price;
        }

        public ObservableCollection<Ingredient> Ingredents { get; set; }
        public decimal Price { get; set; }
        public enum Size
        {
            Normal,Familiy
        }
    }
}
