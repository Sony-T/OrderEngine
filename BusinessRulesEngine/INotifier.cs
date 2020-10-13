using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessRulesEngine
{
    // The Notifier interface declares the operations related to sending notification and this is implemented in the concrete class based upon the business rules defined
    interface INotifier
    {
        void SendEmail(string htmlString);
    }
}
