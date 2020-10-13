using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessRulesEngine
{
    class Video : IOrder
    {
        private readonly string _productType;
        public Video()
        {
            _productType = "Video";
        }
        public string OrderAction()
        {
            return "'First Aid' video to the Payment Slip!";
        }

        public string ProductType
        {
            get { return _productType; }
        }
    }
}

