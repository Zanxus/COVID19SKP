using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria 
{
    class Drink : IOrderable
    {
        public decimal Price { get; set; }
        public string Name { get; set; }
    }
}
