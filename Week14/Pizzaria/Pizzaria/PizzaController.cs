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
        public static void CreatePizza(int pizzaID, string name, Pizza.Size size, ObservableCollection<Ingredient> ingredients, decimal price)
        {
            if (PizzaList.First(x => x.PizzaID == pizzaID) == null)
            {
                PizzaList.Add(new Pizza(pizzaID, name, size, ingredients, price));
            }
            else
            {
                throw new Exception("Pizza with that ID already exists");
            }
            
        }
        //Reads a Pizza by ID
        public static Pizza ReadPizza(int pizzaID)
        {
            if (PizzaList.First(x => x.PizzaID == pizzaID) == null)
            {
                throw new Exception("Pizza with that ID doesn't exists");
            }
            else
            {
                return PizzaList.FirstOrDefault(x => x.PizzaID == pizzaID);
            }

        }
        //Overrides old data with new data
        public static void UpdatePizza(int pizzaID, string name, Pizza.Size size, ObservableCollection<Ingredient> ingredients, decimal price)
        {
            Pizza pizza = ReadPizza(pizzaID);
            pizza.Name = name;
            pizza.Ingredents = ingredients;
            pizza.size = size;
            pizza.Price = price;
        }
        //Removes a Pizza by ID
        public static void RemovePizza(int pizzaID)
        {
            PizzaList.Remove(ReadPizza(pizzaID));
        }




    }
}
