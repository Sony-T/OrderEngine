using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessRulesEngine
{
    // The Order interface declares the operations that all concrete products
    // must implement.
    interface IOrder
    {
        string ProductType { get; } 
        string OrderAction();
    }
}
