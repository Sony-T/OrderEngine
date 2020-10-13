using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessRulesEngine
{
    // Concrete Creators override the factory method in order to change the
    // resulting product's type.
    class PhysicalFactory : OrderFactory
    {
        public override IOrder ProcessOrder()
        {
            return new Physical();
        }
    }
}
