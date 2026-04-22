using System;

class BillingSupport : SupportHandler
{
    public override bool Handle()
    {
        if (AskUser("Is your issue about payments?"))
        {
            Console.WriteLine("Billing Support: Check transactions.\n");
            return true;
        }

        return next != null && next.Handle();
    }
}