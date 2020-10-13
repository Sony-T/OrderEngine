using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessRulesEngine
{
    // The Payment interface declares the operations related to special payment calculation and this is implemented in the concrete class based on the business rules
    interface IPayment
    {
        decimal SendCommissionPayment(string productType);
    }
}
