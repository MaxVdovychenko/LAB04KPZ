using System;
class Program
{
    static void Main()
    {
        while (true)
        {
            var basic = new BasicSupport();
            var tech = new TechnicalSupport();
            var billing = new BillingSupport();
            var manager = new ManagerSupport();

 
            basic.SetNext(tech);
            tech.SetNext(billing);
            billing.SetNext(manager);

            Console.WriteLine("\n--- Support System ---");

            bool handled = basic.Handle();

            if (!handled)
            {
                Console.WriteLine("No suitable support found. Restarting...\n");
            }
            else
            {
                Console.WriteLine("Issue handled successfully.\n");
                break;
            }
        }
    }
}