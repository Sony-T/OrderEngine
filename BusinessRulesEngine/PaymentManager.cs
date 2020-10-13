using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessRulesEngine
{
    public class PaymentManager : IPayment
    {
        public decimal SendCommissionPayment(string productType)
        {
            decimal calculation=0.0M;

            //Commision payment calculation for the agent based on productType
            //TODO: some calculation 


            switch (productType)
            {
                case "Physical":
                    calculation=100000.0M;
                    break;
                case "Book":
                    calculation=10000.0M;
                    break;
                default:
                    calculation= 0.0M;
                    break;

            }
            return calculation;
        }

    }
}
