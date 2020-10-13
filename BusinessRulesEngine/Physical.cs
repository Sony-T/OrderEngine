using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessRulesEngine
{
    class Physical : IOrder
    {
        private readonly string _productType;
        public Physical()
        {
            _productType = "Physical";
        }
        public string OrderAction()
        {
            var productMgr = new PaymentManager();
            var result = productMgr.SendCommissionPayment(_productType);
            return "Packing Slip with Commission included: " + result;
        }

        public string ProductType
        {
            get { return _productType; }
        }
    }
}
