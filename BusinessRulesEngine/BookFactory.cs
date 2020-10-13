using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessRulesEngine
{
    class BookFactory : OrderFactory
    {
        public override IOrder ProcessOrder()
        {
            return new Book();
        }
    }
}
