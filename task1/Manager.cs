using System;

class ManagerSupport : SupportHandler
{
    public override bool Handle()
    {
        if (AskUser("Do you want a manager?"))
        {
            Console.WriteLine("Manager: Handling your request.\n");
            return true;
        }

        return next != null && next.Handle();
    }
}