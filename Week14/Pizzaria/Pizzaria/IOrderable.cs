using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    interface IOrderable
    {
        decimal Price { get; set; }
        string Name { get; set; }
    }
}
