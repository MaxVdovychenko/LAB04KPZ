using System;
class BillingSupport : SupportHandler
{
    public override bool Handle()
    {
        Console.WriteLine("Is your issue about payments? (yes/no)");
        string input = Console.ReadLine();

        if (input.ToLower() == "yes")
        {
            Console.WriteLine("Billing Support: Check your transaction history.");
            return true;
        }

        return next?.Handle() ?? false;
    }
}