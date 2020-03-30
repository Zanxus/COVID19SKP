using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    class Pizza
    {
        private Size size;
        private ObservableCollection<Ingredient> ingredients;

        public Pizza(Size size, ObservableCollection<Ingredient> ingredients, decimal price)
        {
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
