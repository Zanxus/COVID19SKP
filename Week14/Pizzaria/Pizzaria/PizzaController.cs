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
        public static ObservableCollection<Pizza> PizzaList = new ObservableCollection<Pizza>();

        //CreatePizza -Makes the Pizza using the Pizza Class Constructor and addeds to the list of pizzas
        public static void CreatePizza(int pizzaID, string name, Pizza.PizzaSize size, Pizza.PizzaDough dough,Pizza.PizzaSauce sauce, ObservableCollection<Topping> toppings, decimal price)
        {
            if (PizzaList.FirstOrDefault(x => x.PizzaID == pizzaID) == null || PizzaList.Count == 0)
            {
                PizzaList.Add(new Pizza(pizzaID, name, size, dough, sauce, toppings, price));
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
        public static void UpdatePizza(int pizzaID, string name, Pizza.PizzaSize size,Pizza.PizzaDough dough,Pizza.PizzaSauce sauce, ObservableCollection<Topping> toppings, decimal price)
        {
            Pizza pizza = ReadPizza(pizzaID);
            pizza.Name = name;
            pizza.Toppings = toppings;
            pizza.Size = size;
            pizza.Dough = dough;
            pizza.Sauce = sauce;
            pizza.Price = price;
        }
        //Overload version of the update, with no price
        public static void UpdatePizza(int pizzaID, string name, Pizza.PizzaSize size, Pizza.PizzaDough dough, Pizza.PizzaSauce sauce, ObservableCollection<Topping> toppings)
        {
            Pizza pizza = ReadPizza(pizzaID);
            pizza.Name = name;
            pizza.Toppings = toppings;
            pizza.Size = size;
            pizza.Dough = dough;
            pizza.Sauce = sauce;
        }
        public static void UpdatePizza(int pizzaID, Pizza.PizzaSize size, decimal price)
        {
            Pizza pizza = ReadPizza(pizzaID);
            pizza.Size = size;
            pizza.Price = price;

            PizzaList.Add(pizza);
        }
        //Removes a Pizza by ID
        public static void RemovePizza(int pizzaID)
        {
            PizzaList.Remove(ReadPizza(pizzaID));
        }
    }
}
