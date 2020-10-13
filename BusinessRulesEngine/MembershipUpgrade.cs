using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessRulesEngine
{
    class MembershipUpgrade : IOrder
    {
        private readonly string _productType;
        public MembershipUpgrade()
        {
            _productType = "MembershipUpgrade";
        }
        public string OrderAction()
        {
            string message = "Your Membership has been Upgraded!";
            var notify = new NotificationManager();
            notify.SendEmail(message);
            return "Upgrade Membership";
        }

        public string ProductType
        {
            get { return _productType; }
        }
    }
}

