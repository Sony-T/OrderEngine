using System;

namespace BusinessRulesEngine
{
    class Client
    {
        public void OrderProcessingEngine()
        {
            //Assigning null to Creator object  
            OrderFactory order = null;

            var input = Console.ReadLine().ToUpper();

            switch (input)
            {
                case "PHYSICAL":
                    order = new PhysicalFactory();
                    break;
                case "BOOK":
                    order = new BookFactory();
                    break;
                case "MEMBERSHIP":
                    order = new MembershipFactory();
                    break;
                case "MEMBERSHIPUPGRADE":
                    order = new MembershipUpgradeFactory();
                    break;
                case "VIDEO":
                    order = new VideoFactory();
                    break;

            }

            var output = order.ProcessOrder();
            //Print output
            Console.WriteLine(output.OrderAction());

            // Try to convert the string to an enum:
            //Product product = (Product)Enum.Parse(typeof(Product), input.ToUpper());

            // See if the conversion succeeded:
            //if (product == Product.PHYSICAL)
            //{
            //    order = new PhysicalFactory();
            //}

        }


    }
    enum Product
    {
        PHYSICAL,
        BOOK,
        MEMBERSHIP,
        MEMBERSHIP_UPGRADE,
        VIDEO
    }
}
