using System;

class Program
{
    static void Main()
    {
        var basic = new BasicSupport();
        var tech = new TechnicalSupport();
        var billing = new BillingSupport();
        var manager = new ManagerSupport();

        // chain
        basic
            .SetNext(tech)
            .SetNext(billing)
            .SetNext(manager);

        while (true)
        {
            Console.WriteLine("\n--- Support System ---");

            bool handled = basic.Handle();

            if (handled)
            {
                Console.WriteLine("Issue handled successfully.");
                break;
            }

            Console.WriteLine("No suitable support found. Restarting...\n");
        }
    }
}