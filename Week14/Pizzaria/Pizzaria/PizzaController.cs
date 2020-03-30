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
        static ObservableCollection<Pizza> PizzaList = new ObservableCollection<Pizza>();

        //CreatePizza -Makes the Pizza using the Pizza Class Constructor and addeds to the list of pizzas
        public static void CreatePizza(int pizzaID, Pizza.Size size, ObservableCollection<Ingredient> ingredients, decimal price)
        {
            if (PizzaList.First(x => x.PizzaID == pizzaID) == null)
            {
                throw new Exception("Pizza with that ID already exists");
            }
            else
            {
                PizzaList.Add(new Pizza(pizzaID, size, ingredients, price));
            }
            
        }
        //Reads a specific pizza
        public static Pizza ReadPizza(int pizzaID)
        {
            return PizzaList.FirstOrDefault(x => x.PizzaID == pizzaID);
        }



    }
}
