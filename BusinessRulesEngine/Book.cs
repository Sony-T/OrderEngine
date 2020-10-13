using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessRulesEngine
{
    class Book : IOrder
    {
        private readonly string _productType;
        public Book()
        {
            _productType = "Book";
        }
        public string OrderAction()
        {
            var productMgr = new PaymentManager();
            var result = productMgr.SendCommissionPayment(_productType);
            return "Duplicate Packing Slip included Commission: " + result;
        }

        public string ProductType
        {
            get { return _productType; }
        }
    }
}
