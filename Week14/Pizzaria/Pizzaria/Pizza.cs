using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
   public class Pizza
    {
        public decimal Price { get; set; }
        readonly List<string> ingredients = new List<string>();
        public enum Size
        {
            Normal,Family
        }
    }


}
