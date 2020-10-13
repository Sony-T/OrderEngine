using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessRulesEngine
{
    class Membership : IOrder
    {
        private readonly string _productType;
        public Membership()
        {
            _productType = "Membership";
        }
        public string OrderAction()
        {

            string message = "Your Membership has been activated!";
            var notify = new NotificationManager();
            notify.SendEmail(message);
            return "Activate Membership!";
        }

        public string ProductType
        {
            get { return _productType; }
        }
    }
}

