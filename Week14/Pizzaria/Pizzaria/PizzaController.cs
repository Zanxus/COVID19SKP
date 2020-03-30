using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{

   public static class PizzaController
    {
        //CRUD Class
        private ObservableCollection<Pizza> pizzaList = new ObservableCollection<Pizza>();

        internal ObservableCollection<Pizza> PizzaList { get => pizzaList; set => pizzaList = value; }

        //CreatePizza
        public static void CreatePizza(Pizza.Size size, ObservableCollection<Ingredient> ingredients, decimal price)
        {
            PizzaList.Add(new Pizza(size, ingredients, price));
        }

    }
}
