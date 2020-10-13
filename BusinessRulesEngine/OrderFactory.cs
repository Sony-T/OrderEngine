using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessRulesEngine
{
    //The Creator's class
    abstract class OrderFactory
    {
        // The factory method
        public abstract IOrder ProcessOrder();

        // This class contains some business logic that relies on order objects, returned by the
        // factory method. Subclasses can indirectly change that business logic
        // by overriding the factory method and returning a different type of product.
        public string orderOperation()
        {
            var order = ProcessOrder();
            return order.OrderAction();
        }
    }
}
