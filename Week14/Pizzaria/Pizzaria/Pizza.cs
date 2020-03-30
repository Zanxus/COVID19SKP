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
        public ObservableCollection<Ingredient> Ingredents { get; set; }
        public decimal Price { get; set; }
        public enum Size
        {
            Normal,Familiy
        }
    }
}
