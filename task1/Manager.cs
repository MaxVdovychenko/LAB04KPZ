using System;
class ManagerSupport : SupportHandler
{
    public override bool Handle()
    {
        Console.WriteLine("Do you want to speak with a manager? (yes/no)");
        string input = Console.ReadLine();

        if (input.ToLower() == "yes")
        {
            Console.WriteLine("Manager: Handling your request personally.");
            return true;
        }

        return next?.Handle() ?? false;
    }
}